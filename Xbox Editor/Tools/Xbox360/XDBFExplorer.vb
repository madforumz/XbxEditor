Imports XboxEditor.Profile

Public Class XDBFExplorer
    Dim ofd As New OpenFileDialog()
    Dim XDBF As XDBF
    Public FilePath As String

    Private Sub XDBFExplorer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        ofd.Title = "Open an Xbox 360 GPD File"
        If (ofd.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            FilePath = ofd.FileName
            ReadFile(FilePath)
        Else
            Return
        End If
    End Sub

    Sub ReadFile(ByVal Filepath As String)
        XDBF = New XDBF(Filepath)
        For Each e As XDBFEntry In XDBF.Entries
            Dim i As New ListViewItem(e.Namespace.ToString())
            i.SubItems.Add(e.ID)
            i.SubItems.Add(e.OffsetSpec)
            i.SubItems.Add(e.Length)
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub
End Class