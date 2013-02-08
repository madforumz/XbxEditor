Imports DevComponents.DotNetBar
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Globalization
Imports XboxEditor.STFS
Imports XboxEditor.IO

Public Class Assassin_s2
    Public FilePath As String
    Dim Open As New OpenFileDialog
    Dim STFS As STFSPackage

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenAss.Click
        Open.Title = "Open An Xbox 360 Assassin's Creed II Gamesave"
        If Open.ShowDialog = Windows.Forms.DialogResult.OK Then
            FilePath = Open.FileName
            STFS = New STFSPackage(FilePath)
            If STFS.CheckTitleID("5553083B") Then
                ReadFile(FilePath)
            End If
        End If
    End Sub
    Public Sub ReadFile(ByVal Filepath As String)
        Save.Enabled = True
        Max.Enabled = True
        ModChanger.Enabled = True
        ResignBB.Enabled = True
        STFS.IO.Position = &H13DAE
        ModChanger.Value = STFS.IO.ReadInt32()
    End Sub
    Public Sub resetform()
        Save.Enabled = False
        Max.Enabled = False
        ModChanger.Enabled = False
        ResignBB.Enabled = False
    End Sub
    
    Private Sub Max_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Max.Click
        ModChanger.Value = ModChanger.MaxValue
    End Sub
    Private Sub Writefile()
        STFS.IO.Position = &H13DAE
        STFS.IO.WriteInt32(ModChanger.Value)
    End Sub
    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        Try
            STFS.RehashResign()
            Writefile()
            MessageBoxEx.EnableGlass = False
            MessageBoxEx.Show("Saved And Rehash And Resigned", "Assassin's Creed II", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBoxEx.EnableGlass = False
            MessageBoxEx.Show(ex.Message)
        End Try
    End Sub
  
    Private Sub ResignBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResignBB.Click
        Dim xbox As New XboxManager
        XboxManager.ReadFile(STFS)
        xbox.FilePath = FilePath
        xbox.ReadFile(xbox.FilePath)
        xbox.MdiParent = Home
        xbox.Show()
        xbox.ProfileID.Enabled = True
        Me.Close()
    End Sub

    Private Sub Assassin_s2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class