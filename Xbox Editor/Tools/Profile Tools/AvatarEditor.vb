Imports System.IO
Imports DevComponents.DotNetBar
Imports PackageIO
Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Text

Public Class AvatarEditor
    Dim filepath As String
    Dim C1C8F1Location As Integer
    Dim OFD As New OpenFileDialog

    Private Sub AvatarEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBoxEx.EnableGlass = False
    End Sub

    Private Sub OpenAss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAss.Click
        OFD.Title = "Open  An XBOX 360 Profile Only!"
        If OFD.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                filepath = OFD.FileName
                TitleIDVerify(filepath)
            Catch ex As Exception
                MessageBoxEx.Show("Invalid Package... This Is Not A Xbox 360 Profile With a Avatar !", Home.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                resetform()
            End Try
        End If
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        SaveAvatar()
    End Sub
    Public Function TitleIDVerify(ByVal filepath As String)
        Dim FS As New FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim BR As New System.IO.BinaryReader(FS)
        BR.BaseStream.Position = &H360 ' The TitleID Offsets
        Dim TitleID As String = BitConverter.ToString(BR.ReadBytes(4)).Replace("-", "")
        BR.Close()
        If TitleID = "FFFE07D1" Then ' Enter Ur TitleID Here ?
            BlockSearch("C1C8F1")
            Save.Enabled = True
            Skin.Enabled = True
            Paint1.Enabled = True
            Paint2.Enabled = True
            Eye.Enabled = True
            Lip.Enabled = True
            Brow.Enabled = True
            Shadow.Enabled = True
            Face.Enabled = True
            Hair.Enabled = True
            RandomBB.Enabled = True
            ResignBB.Enabled = True
            Return True ' Return True If TitleID Matches ?
        Else
            MessageBoxEx.Show("Invalid Package... This Is Not A Xbox 360 Profile With a Avatar !", Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            resetform()
            Return False ' Return False If TitleID Does Not Match ?
        End If
    End Function
    Public Sub resetform()
        Save.Enabled = False
        Skin.Enabled = False
        Paint1.Enabled = False
        Paint2.Enabled = False
        Eye.Enabled = False
        Lip.Enabled = False
        Brow.Enabled = False
        Shadow.Enabled = False
        Face.Enabled = False
        Hair.Enabled = False
        RandomBB.Enabled = False
        ResignBB.Enabled = False
    End Sub


    Private Sub BlockSearch(ByVal find As String)
        Try
            Dim i As Integer = 0
            Dim Found As Boolean = False
            Dim Block As String = Nothing
            Dim Length As Integer = (find.Length / 2)
            Dim reader As New PackageIO.Reader(filepath, Endian.Little)
            While Found = False
                If i <> 0 Then
                    reader.Position = (32 * i) - Length
                    Block = ArrayToHexString(reader.ReadBytes(32 + Length))
                    If Block.Contains(find) Then
                        Found = True
                    Else
                        i += 1
                    End If
                Else
                    i += 1
                End If
            End While
            Dim offset As Integer = (i * 32)
            Dim B As Integer = 0
            Found = False
            While B < 32 - Length AndAlso Found = False
                reader.Position = offset + B
                Dim HexStr As String = ArrayToHexString(reader.ReadBytes(Length))
                If HexStr = find Then
                    Found = True
                Else
                    B += 1
                End If
            End While
            reader.Close()
            offset = offset + B
            C1C8F1Location = offset
            ReadAvatarColors()
        Catch ex As Exception
        End Try
    End Sub
    Public Function ArrayToHexString(ByVal input As Byte()) As String
        Dim len As Integer = input.Length
        Dim output As String = ""
        For i As Integer = 0 To len - 1
            output += [String].Format("{0:X2}", input(i))
        Next
        Return output
    End Function
    Public Function HexStringToArray(ByVal input As String) As Byte()


        Dim output As Byte() = New Byte(input.Length / 2 - 1) {}
        If (input.Length Mod 2) <> 0 Then
            Throw New ArgumentException("Input string incorrect length.")
        Else
            For i As Integer = 0 To input.Length - 1 Step 2
                output(i / 2) = Convert.ToByte(input.Substring(i, 2), 16)
            Next
        End If
        Return output
    End Function
    Private Function GetColor(ByVal input As Byte()) As Integer
        Return Integer.Parse(ArrayToHexString(input), System.Globalization.NumberStyles.HexNumber)
    End Function


    Private Sub SaveAvatar()
        Try
            Dim output As String = ""
            output += Skin.SelectedColor.A.ToString("X2") + Skin.SelectedColor.R.ToString("X2") + Skin.SelectedColor.G.ToString("X2") + Skin.SelectedColor.B.ToString("X2")
            output += Hair.SelectedColor.A.ToString("X2") + Hair.SelectedColor.R.ToString("X2") + Hair.SelectedColor.G.ToString("X2") + Hair.SelectedColor.B.ToString("X2")
            output += Lip.SelectedColor.A.ToString("X2") + Lip.SelectedColor.R.ToString("X2") + Lip.SelectedColor.G.ToString("X2") + Lip.SelectedColor.B.ToString("X2")
            output += Eye.SelectedColor.A.ToString("X2") + Eye.SelectedColor.R.ToString("X2") + Eye.SelectedColor.G.ToString("X2") + Eye.SelectedColor.B.ToString("X2")
            output += Brow.SelectedColor.A.ToString("X2") + Brow.SelectedColor.R.ToString("X2") + Brow.SelectedColor.G.ToString("X2") + Brow.SelectedColor.B.ToString("X2")
            output += Shadow.SelectedColor.A.ToString("X2") + Shadow.SelectedColor.R.ToString("X2") + Shadow.SelectedColor.G.ToString("X2") + Shadow.SelectedColor.B.ToString("X2")
            output += Face.SelectedColor.A.ToString("X2") + Face.SelectedColor.R.ToString("X2") + Face.SelectedColor.G.ToString("X2") + Face.SelectedColor.B.ToString("X2")
            output += Paint1.SelectedColor.A.ToString("X2") + Paint1.SelectedColor.R.ToString("X2") + Paint1.SelectedColor.G.ToString("X2") + Paint1.SelectedColor.B.ToString("X2")
            output += Paint2.SelectedColor.A.ToString("X2") + Paint2.SelectedColor.R.ToString("X2") + Paint2.SelectedColor.G.ToString("X2") + Paint2.SelectedColor.B.ToString("X2")
            Dim writer As New PackageIO.Writer(filepath, Endian.Little)
            writer.Position = C1C8F1Location
            writer.Position += 232
            writer.Write(HexStringToArray(output))
            writer.Close()
            Try
                Resign()
            Catch ex As Exception
                MessageBoxEx.EnableGlass = False
                MessageBoxEx.Show(ex.Message)
            End Try
            MessageBoxEx.EnableGlass = False
            MessageBoxEx.Show("Avatar Successfuly Modded And Rehashed And Resigned!", "Avatar Modded!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch generatedExceptionName As Exception
            MessageBoxEx.Show("Unable to save file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub ReadAvatarColors()
        Try
            Dim color1 As New Color
            Dim reader As New PackageIO.Reader(filepath, Endian.Little)
            reader.Position = C1C8F1Location
            reader.Position += 232
            color1 = Color.FromArgb(GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)))
            Skin.SelectedColor = color1
            color1 = Color.FromArgb(GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)))
            Hair.SelectedColor = color1
            color1 = Color.FromArgb(GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)))
            Lip.SelectedColor = color1
            color1 = Color.FromArgb(GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)))
            Eye.SelectedColor = color1
            color1 = Color.FromArgb(GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)))
            Brow.SelectedColor = color1
            color1 = Color.FromArgb(GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)))
            Shadow.SelectedColor = color1
            color1 = Color.FromArgb(GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)))
            Face.SelectedColor = color1
            color1 = Color.FromArgb(GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)))
            Paint1.SelectedColor = color1
            color1 = Color.FromArgb(GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)), GetColor(reader.ReadBytes(1)))
            Paint2.SelectedColor = color1
        Catch ex As Exception
            MessageBoxEx.Show("Not A Xbox 360 Profile With Avatar ! ", "Not A Xbox Profile !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub RandomBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RandomBB.Click
        Hair.SelectedColor = Color.Blue
        Skin.SelectedColor = Color.DarkOrange
        Eye.SelectedColor = Color.RoyalBlue
        Brow.SelectedColor = Color.Gold
        Face.SelectedColor = Color.LightPink
        Paint1.SelectedColor = Color.Green
        Paint2.SelectedColor = Color.BlanchedAlmond
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
            MessageBoxEx.Show(ex.Message, "Aavtar Editor", MessageBoxButtons.OK, MessageBoxIcon.Error)
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