Imports DevComponents.DotNetBar
Imports PackageIO
Imports System.IO
Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Text
Public Class AssassinsRevelations
    Dim open As New OpenFileDialog
    Dim filepath As String
    Private Sub OpenAss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAss.Click
        open.Title = "Open An Xbox 360 Assassin's Revelations Gamesave"
        If open.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                filepath = open.FileName
                TitleIDVerify(filepath)
            Catch ex As Exception
                MessageBoxEx.Show("Invalid Package... This Is Not A Assassin's Creed Revelations Gamesave", Home.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                resetform()
            End Try
        End If
    End Sub
    Public Sub resetform()
        Save.Enabled = False
        MaxBB.Enabled = False
        MoneyII.Enabled = False
    End Sub
    Public Function TitleIDVerify(ByVal filepath As String)
        Dim FS As New FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        Dim BR As New System.IO.BinaryReader(FS)
        BR.BaseStream.Position = &H360 ' The TitleID Offsets
        Dim TitleID As String = BitConverter.ToString(BR.ReadBytes(4)).Replace("-", "")
        BR.Close()
        If TitleID = "55530879" Then ' Enter Ur TitleID Here ?
            'ReadFile()
            MoneyII.Enabled = True
            Save.Enabled = True
            MaxBB.Enabled = True
            Return True ' Return True If TitleID Matches ?
        Else
            resetform()
            MessageBoxEx.Show("Invalid Package... This Is Not A Assassin's Creed Revelations Gamesave", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' Return False If TitleID Does Not Match ?
        End If
    End Function
End Class