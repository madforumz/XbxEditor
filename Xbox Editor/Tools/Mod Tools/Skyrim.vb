Imports System.IO
Imports DevComponents.DotNetBar
Imports PackageIO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Globalization

Public Class Skyrim
    Dim filepath As String
    Dim open As New OpenFileDialog
    Private Sub OpenAss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenBB.Click
        open.Title = "Open An Skyrim Gamesave"
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            filepath = open.FileName
            TitleIDVerify(filepath)
        End If
    End Sub
    Public Function TitleIDVerify(ByVal filepath As String)
            Dim FS As New FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite)
            Dim BR As New System.IO.BinaryReader(FS)
            BR.BaseStream.Position = &H360 ' The TitleID Offsets
            Dim TitleID As String = BitConverter.ToString(BR.ReadBytes(4)).Replace("-", "")
            BR.Close()
            If TitleID = "425307E6" Then ' Enter Ur TitleID Here ?
                readfile()
                enabledII()
                Return True
            ' Return True If TitleID Matches ? 
        Else
            MessageBoxEx.Show("Invalid Package... This Is Skyrim Gamesave", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            formreset()
            ' Return False If TitleID Does Not Match ?
            Return False
        End If
    End Function
    Public Sub enabledII()
        II1.Enabled = True
        II2.Enabled = True
        II3.Enabled = True
        II4.Enabled = True
        II5.Enabled = True
        II6.Enabled = True
        II7.Enabled = True
        II8.Enabled = True
        II9.Enabled = True
        II10.Enabled = True
        II11.Enabled = True
        II12.Enabled = True
        II13.Enabled = True
        II14.Enabled = True
        II15.Enabled = True
        II16.Enabled = True
        II17.Enabled = True
        II18.Enabled = True
        II19.Enabled = True
        II20.Enabled = True
        II21.Enabled = True
        SaveBB.Enabled = True
        MaxBB.Enabled = True
        ResignBB.Enabled = True
    End Sub
    Public Sub readfile()
        Dim reader As New PackageIO.Reader(filepath, Endian.Little)
        reader.Position = &H3A2F0
        II1.Value = reader.ReadInt32
        reader.Position = &H3A308
        II2.Value = reader.ReadInt32
        reader.Position = &H3A2DF
        II3.Value = reader.ReadInt32
        reader.Position = &H3A29D
        II4.Value = reader.ReadInt32
        reader.Position = &H3A105
        II5.Value = reader.ReadInt32
        reader.Position = &H3A11B
        II6.Value = reader.ReadInt32
        reader.Position = &H3A332
        II7.Value = reader.ReadInt32
        reader.Position = &H3A349
        II8.Value = reader.ReadInt32
        reader.Position = &H3A35A
        II9.Value = reader.ReadInt32
        reader.Position = &H3A383
        II10.Value = reader.ReadInt32
        reader.Position = &H3A396
        II11.Value = reader.ReadInt32
        reader.Position = &H3A3A9
        II12.Value = reader.ReadInt32
        reader.Position = &H3A3C2
        II13.Value = reader.ReadInt32
        reader.Position = &H3A41D
        II14.Value = reader.ReadInt32
        reader.Position = &H3A434
        II15.Value = reader.ReadInt32
        reader.Position = &H3A5A0
        II16.Value = reader.ReadInt32
        reader.Position = &H3A64D
        II17.Value = reader.ReadInt32
        reader.Position = &H3A674
        II18.Value = reader.ReadInt32
        reader.Position = &H3A685
        II19.Value = reader.ReadInt32
        reader.Position = &H3A6B4
        II20.Value = reader.ReadInt32
        reader.Position = &H3A78C
        II21.Value = reader.ReadInt32
        reader.Close()
    End Sub
    Public Sub formreset()
        II1.Enabled = False
        II2.Enabled = False
        II3.Enabled = False
        II4.Enabled = False
        II5.Enabled = False
        II6.Enabled = False
        II7.Enabled = False
        II8.Enabled = False
        II9.Enabled = False
        II10.Enabled = False
        II11.Enabled = False
        II12.Enabled = False
        II13.Enabled = False
        II14.Enabled = False
        II15.Enabled = False
        II16.Enabled = False
        II17.Enabled = False
        II18.Enabled = False
        II19.Enabled = False
        II20.Enabled = False
        II21.Enabled = False
        SaveBB.Enabled = False
        ResignBB.Enabled = False
        MaxBB.Enabled = False
    End Sub
    Public Sub savefile()
        Dim writer As New PackageIO.Writer(filepath, Endian.Little)
        writer.Position = &H3A2F0
        writer.WriteInt32(II1.Value)
        writer.Position = &H3A308
        writer.WriteInt32(II2.Value)
        writer.Position = &H3A2DF
        writer.WriteInt32(II3.Value)
        writer.Position = &H3A29D
        writer.WriteInt32(II4.Value)
        writer.Position = &H3A105
        writer.WriteInt32(II5.Value)
        writer.Position = &H3A11B
        writer.WriteInt32(II6.Value)
        writer.Position = &H3A332
        writer.WriteInt32(II7.Value)
        writer.Position = &H3A349
        writer.WriteInt32(II8.Value)
        writer.Position = &H3A35A
        writer.WriteInt32(II9.Value)
        writer.Position = &H3A383
        writer.WriteInt32(II10.Value)
        writer.Position = &H3A396
        writer.WriteInt32(II11.Value)
        writer.Position = &H3A3A9
        writer.WriteInt32(II12.Value)
        writer.Position = &H3A3C2
        writer.WriteInt32(II13.Value)
        writer.Position = &H3A41D
        writer.WriteInt32(II14.Value)
        writer.Position = &H3A434
        writer.WriteInt32(II15.Value)
        writer.Position = &H3A5A0
        writer.WriteInt32(II16.Value)
        writer.Position = &H3A64D
        writer.WriteInt32(II17.Value)
        writer.Position = &H3A674
        writer.WriteInt32(II18.Value)
        writer.Position = &H3A685
        writer.WriteInt32(II19.Value)
        writer.Position = &H3A6B4
        writer.WriteInt32(II20.Value)
        writer.Position = &H3A78C
        writer.WriteInt32(II21.Value)
        writer.Close()
    End Sub

    Private Sub SaveBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBB.Click
        Try
            savefile()
            Resign()
            MessageBoxEx.EnableGlass = False
            MessageBoxEx.Show("Saved And Rehash And Resigned", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBoxEx.EnableGlass = False
            MessageBoxEx.Show(ex.Message)
        End Try
    End Sub

    Private Sub MaxBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaxBB.Click
        II1.Value = II1.MaxValue
        II2.Value = II2.MaxValue
        II3.Value = II3.MaxValue
        II4.Value = II4.MaxValue
        II5.Value = II5.MaxValue
        II6.Value = II6.MaxValue
        II7.Value = II7.MaxValue
        II8.Value = II8.MaxValue
        II9.Value = II9.MaxValue
        II10.Value = II10.MaxValue
        II11.Value = II11.MaxValue
        II12.Value = II12.MaxValue
        II13.Value = II13.MaxValue
        II14.Value = II14.MaxValue
        II15.Value = II15.MaxValue
        II16.Value = II16.MaxValue
        II17.Value = II17.MaxValue
        II18.Value = II18.MaxValue
        II19.Value = II19.MaxValue
        II20.Value = II20.MaxValue
        II21.Value = II21.MaxValue
    End Sub
    Public Sub Resign()
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
            MessageBoxEx.Show(ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub ResignBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResignBB.Click
        Dim xbox As New XboxManager
        XboxManager.ReadFile(filepath)
        xbox.FilePath = filepath
        xbox.ReadFile(xbox.FilePath)
        xbox.MdiParent = Home
        xbox.Show()
        xbox.ProfileID.Enabled = True
        Me.Close()
    End Sub
End Class