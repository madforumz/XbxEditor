﻿Imports System.Security.Cryptography
Imports System.Globalization
Imports DevComponents.DotNetBar
Imports PackageIO
Imports System.IO
Imports System.Text

Module Rehash
    Public filepath As String
    Public Sub ResignXboxmanager()
        Dim rsaEncryptor As New RSACryptoServiceProvider()
        Dim rsaParamaters1 As New RSAParameters()
        Dim publicKey As Byte()
        Try
            Dim ms = New MemoryStream(My.Resources.KV, False)
            Dim binaryReader2 As New BinaryReader(ms)
            binaryReader2.BaseStream.Position = 652
            rsaParamaters1.Exponent = binaryReader2.ReadBytes(4)
            binaryReader2.BaseStream.Position += 8
            rsaParamaters1.Modulus = FlipBytesBy8(binaryReader2.ReadBytes(128))
            rsaParamaters1.P = FlipBytesBy8(binaryReader2.ReadBytes(64))
            rsaParamaters1.Q = FlipBytesBy8(binaryReader2.ReadBytes(64))
            rsaParamaters1.DP = FlipBytesBy8(binaryReader2.ReadBytes(64))
            rsaParamaters1.DQ = FlipBytesBy8(binaryReader2.ReadBytes(64))
            rsaParamaters1.InverseQ = FlipBytesBy8(binaryReader2.ReadBytes(64))
            Dim asciiEncoder As New ASCIIEncoding()
            rsaParamaters1.D = AsciiToHex("6D4CCF3DE86551FF2DACC190E747EBC67458D02D1908AC79CED01DA31CC32E398EC7EF66FAE42F1042A84EE7A1FDF4F0CB6467A6104D6D3A569D1FEC51FCC22645C2DEF99B4C4C934DA82B48ACEDD7FCEAE972FBB23988C107346F2A077E9781F50221FACDDD30DDE541B34A227380892B9E90AFC40A8A50150FBD6ED4953779")
            binaryReader2.BaseStream.Position = 2488
            publicKey = binaryReader2.ReadBytes(424)
            binaryReader2.Close()
            ms.Close()
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Xbox Manager", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        rsaEncryptor.ImportParameters(rsaParamaters1)
        Dim xReader As Reader
        Dim xWriter As Writer

        xReader = New Reader(filepath, Endian.Big)
        xWriter = New Writer(filepath, Endian.Big)

        Dim sha1Algorythm2 As New SHA1CryptoServiceProvider()
        Try
            Dim rsaSignature As New RSAPKCS1SignatureFormatter(rsaEncryptor)
            rsaSignature.SetHashAlgorithm("SHA1")
            xReader.Position = 836
            Dim hash As Byte() = sha1Algorythm2.ComputeHash(xReader.ReadBytes(40124))
            xWriter.Position = 812
            xWriter.Write(hash)
            xReader.Position = 556
            hash = sha1Algorythm2.ComputeHash(xReader.ReadBytes(280))
            xWriter.Position = 428
            Dim signature As Byte() = rsaSignature.CreateSignature(hash)
            Array.Reverse(signature)
            xWriter.Write(signature)
            xWriter.Position = 4
            xWriter.Write(publicKey)
        Catch
            Return
        End Try

        Dim noOfHashes As Integer
        Dim sha1Algorythm As New SHA1CryptoServiceProvider()
        Try
            Dim noOfBlocksHashed As Integer = 0
            Dim hashArray As Byte()
            xReader.Position = 917
            noOfHashes = xReader.ReadInt32()
            If noOfHashes > 29070 Then
                xReader.Close()
                Throw New Exception("It is not physically possible using the SHA1 algorithm to rehash " & noOfHashes & " the highest amound of hashes is 29070.")


            End If
            xReader.Position = 893
            Dim tableOffset As Integer = 40960
            If xReader.ReadInt32() <> 0 Then
                tableOffset = 45056
            End If
            Dim hashCount As Integer = 170
            If noOfHashes <= 170 Then
                hashCount = noOfHashes
            End If
            For i As Integer = 0 To hashCount - 1
                xReader.Position = 49152 + (i * 4096)
                hashArray = sha1Algorythm.ComputeHash(xReader.ReadBytes(4096))
                xWriter.Position = tableOffset + (i * 24)
                xWriter.Write(hashArray)
                noOfBlocksHashed += 1
            Next
            xReader.Position = tableOffset
            hashArray = sha1Algorythm.ComputeHash(xReader.ReadBytes(4096))
            If noOfHashes < 170 Then
                xWriter.Position = 897
                xWriter.Write(hashArray)
                Return
            Else
                xWriter.Position = 745472
                xWriter.Write(hashArray)
                noOfBlocksHashed += 1
            End If
            Dim myMasterTableOffset As Integer = 745472
            Dim noOfSubTables As Integer = (noOfHashes - (noOfHashes Mod 170)) \ 170
            For tableNo As Integer = 0 To noOfSubTables - 1
                Dim mySubTableOffset As Integer = 49152 + ((170 * (tableNo + 1)) * 4096) + (8192 * tableNo) + 8192
                Dim dataBegins As Integer = mySubTableOffset + 8192
                hashCount = 170
                If (noOfHashes - noOfBlocksHashed) <= 170 Then
                    hashCount = (noOfHashes - noOfBlocksHashed)
                End If
                For i As Integer = 0 To hashCount - 1
                    xReader.Position = dataBegins + (i * 4096)
                    hashArray = sha1Algorythm.ComputeHash(xReader.ReadBytes(4096))
                    xWriter.Position = mySubTableOffset + (i * 24)
                    xWriter.Write(hashArray)
                    noOfBlocksHashed += 1
                Next
                xReader.Position = mySubTableOffset
                hashArray = sha1Algorythm.ComputeHash(xReader.ReadBytes(4096))
                xWriter.Position = (myMasterTableOffset + 24) + (24 * tableNo)
                xWriter.Write(hashArray)
                noOfBlocksHashed += 1
            Next

            xReader.Position = 745472
            hashArray = sha1Algorythm.ComputeHash(xReader.ReadBytes(4096))
            xWriter.Position = 897
            xWriter.Write(hashArray)

        Catch
            MessageBox.Show("Your file could not be rehashed", "zChrome Error:", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            xReader.Close()
            Return
        Finally
            xReader.Close()
        End Try
    End Sub
    Public Function FlipBytesBy8(ByVal input As Byte()) As Byte()
        Dim flippedBytes As Byte() = New Byte(input.Length - 1) {}
        Dim posInput As Integer = input.Length - 8
        Dim posFlipped As Integer = 0
        For i As Integer = 0 To input.Length \ 8 - 1
            For x As Integer = 0 To 7
                flippedBytes(posFlipped + x) = input(posInput + x)
            Next

            posInput -= 8
            posFlipped += 8
        Next

        Return flippedBytes
    End Function
    Public Function AsciiToHex(ByVal ascii As String) As Byte()
        Dim bytes As Byte() = New Byte(ascii.Length \ 2 - 1) {}
        For i As Integer = 0 To ascii.Length \ 2 - 1
            Dim temp As Byte = Byte.Parse(ascii.Substring(i * 2, 2), NumberStyles.HexNumber)
            bytes(i) = temp
        Next
        Return bytes
    End Function
End Module
