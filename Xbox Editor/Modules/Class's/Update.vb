Imports System.Net
Imports System.IO
Imports DevComponents.DotNetBar
Imports System.ComponentModel

Public Class Update
    Public client As WebClient
    Public thisVer As String
    Public RealVer As String

    Public Sub New(ByVal DownloadFile As String)
        client = New WebClient()
        thisVer = Application.ProductVersion
        RealVer = client.DownloadString(DownloadFile)
    End Sub

    Public Function UpdateIsAvailable(ByVal OnlineFile As String) As Boolean
        If thisVer <> OnlineFile Then
            DownloadUpdates()
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub DownloadUpdates()
        If (UpdateIsAvailable(RealVer) = True) Then
            MessageBoxEx.Show("Theres a New Update available We Are Going To Download It To Your Desktop.", Home.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
            client.DownloadFileAsync(New Uri("https://dl.dropbox.com/u/53532004/Xbox%20Editor.zip"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Xbox Editor.zip")
        Else
            Return
        End If
    End Sub

    Private Sub client_DownloadFileCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        Try
            If MessageBoxEx.Show("Your New Xbox Editor Update Has Downloaded, Would You Like Us To Open The New Update ?", Home.Text, MessageBoxButtons.OK, MessageBoxIcon.Question) = DialogResult.OK Then
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Xbox Editor.zip")
            End If
 Catch ex As Exception
            If MessageBoxEx.Show("Your New Update Download Is Corrupted Please Redownload The New Update Again... Would You Like To Redownload The Update Again ?", Home.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Yes Then
                DownloadUpdates()
            End If
        End Try
    End Sub
End Class
