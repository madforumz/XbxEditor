Imports DevComponents.DotNetBar
Imports System.Net
Imports System.ComponentModel

Public Class Updater
    Dim Response As Integer
    Dim webc As New WebClient()

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckUpdateBB.Click
        updating()
    End Sub

    Private Sub wec_DownloadFileCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        Try
            MessageBoxEx.Show("Xbox Editor New Update Has Downloaded To Your Desktop !", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Label1.Text = "Download Complete...."
            If MessageBoxEx.Show("Would You Like To Open The New Version File ?", "Xbox Editor New Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            End If
            Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Xbox Editor.zip")
            CheckUpdateBB.Enabled = False
        Catch ex As Exception
            If MessageBoxEx.Show("Your New Update Download Is Corrupted Please Redownload The New Update Again... Would You Like To Redownload The Update Again ?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Error) = Windows.Forms.DialogResult.Yes Then
                updating()
            End If
        End Try
    End Sub

    Private Sub wec_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        ProgressBar1.Value = (e.ProgressPercentage)
        Label1.Text = "% " & e.ProgressPercentage
    End Sub

    Private Sub Updater_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHandler webc.DownloadFileCompleted, New AsyncCompletedEventHandler(AddressOf wec_DownloadFileCompleted)
    End Sub
    Public Sub updating()
        Try

            'It is downloading your textfile with version in and changing the update buttons text to the version number
            Dim web As New Net.WebClient
            Dim UpdateTXTFile As String = "https://dl.dropbox.com/u/53532004/Xbox%20Editor%20Updates/UpdateInfo.txt" '<<<<<CHANGE ME
            'Me.CheckUpdateBB.Text = web.DownloadString(UpdateTXTFile)
            Dim UpdateCheckTest As String = web.DownloadString(UpdateTXTFile)
            Dim UpdateCheck As Decimal
            If IsNumeric(UpdateCheckTest) Then
                UpdateCheck = Val(UpdateCheckTest)
            End If
            'it is asking if the buttons text(version number) is greater then it will run a command for you to download if not it will just open like normal saying no update needed
            If UpdateCheck > 0.5 Then
                Label1.Text = "Checking Version..."
                'A message box is displayed and it offers you to update or cancel, if you cancel the button will say update avalible and become enabled
                Dim Response As Integer
                Label1.Text = "A Newer Version Is Avaliable !"
                Response = MessageBoxEx.Show("There is a Update Avaliable. We Will Download It To Your Desktop.", "Update Avaliable", MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Information)
                Label1.Text = "Downloading...."
                'If you press ok then It will open your EXE's Dropbox link then close its self
                If Response = vbOK Then
                    AddHandler webc.DownloadProgressChanged, New DownloadProgressChangedEventHandler(AddressOf wec_DownloadProgressChanged)
                    webc.DownloadFileAsync(New Uri("https://dl.dropbox.com/u/53532004/Xbox%20Editor.zip"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Xbox Editor.zip") '<<<<<CHANGE ME
                End If
            Else
                Label1.Text = "Your On The Latest Version !"
                CheckUpdateBB.Enabled = False
            End If

        Catch ex As Exception
            MessageBoxEx.Show("Can't Download File Your Not Connected To A Network Or No Internet Access", Text, MessageBoxButtons.OK)
        End Try
    End Sub
    Public Sub updateHome()
        Try
            Label1.Text = "Checking Version..."
            'A message box is displayed and it offers you to update or cancel, if you cancel the button will say update avalible and become enabled
            Dim Response As Integer
            Label1.Text = "A Newer Version Is Avaliable !"
            Response = MessageBoxEx.Show("There is a Update Avaliable. We Will Download It To Your Desktop.", "Update Avaliable", MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Information)
            Label1.Text = "Downloading...."
            'If you press ok then It will open your EXE's Dropbox link then close its self
            If Response = vbOK Then
                AddHandler webc.DownloadProgressChanged, New DownloadProgressChangedEventHandler(AddressOf wec_DownloadProgressChanged)
                webc.DownloadFileAsync(New Uri("https://dl.dropbox.com/u/53532004/Xbox%20Editor.zip"), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Xbox Editor.zip") '<<<<<CHANGE ME
            Else : Label1.Text = "Your On The Latest Version !" And
                CheckUpdateBB.Enabled = False
            End If


        Catch ex As Exception
            MessageBoxEx.Show("Can't Download File Your Not Connected To A Network Or No Internet Access", Text, MessageBoxButtons.OK)
        End Try
    End Sub
End Class