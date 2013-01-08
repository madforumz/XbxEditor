Imports System.Net
Imports DevComponents.DotNetBar

Public Class loginCode
    Dim BaseURL As String = "http://madforumz.forumotion.com/"

    Public Sub New(ByVal Username, ByVal Password)
        If CheckSite(Username, Password) Then
            Try
                Login(Username, Password)
            Catch ex As Exception
                MessageBoxEx.Show("Login Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else
            MessageBoxEx.Show("MadForumz Server Is Unvailable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub New()
        ' TODO: Complete member initialization 
    End Sub

    Public Function CheckSite()
        Try
            If My.Computer.Network.Ping(BaseURL) Then
                Return True

                Return False
            End If
        Catch ex As Exception
            MessageBoxEx.Show("MadForumz Server Is Unavailable", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        End
    End Function
    Public Sub Login(ByVal Username, ByVal Password)
        Dim LoginURL As String = BaseURL + "/login"
        Dim Client As New WebBrowser()

        Try
            Client.Navigate(LoginURL)

            Client.Document.GetElementById("username").SetAttribute("value", Username)
            Client.Document.GetElementById("password").SetAttribute("value", Password)

            Client.Document.GetElementById("login").InvokeMember("click")

            If Client.DocumentText.Contains("Welcome To MadForumz") Then
                MessageBoxEx.Show("Welcome" + Username + "!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBoxEx.Show("Error Logging In", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

End Class
