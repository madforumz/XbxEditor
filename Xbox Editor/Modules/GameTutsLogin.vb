'
' * Created by Risk
' * -----------------
' * 
' * This uses the offical Modio login way.
' * Don't ask me how I know this as I wont tell you.
' * 
' * Everything works except I never actually got around to finishing the Banned date calculation as I don't have a banned account.
' * The user groups need completing as I have no list.
' * 
' * I take no responsibility for how you use this class.
' * 
' * 
' * GameTutsDetails Keys
' * ---------------------
' * logresu - ?
' * usf - Username
' * e - Email
' * ni - ?
' * icl - ?
' * iv - Is VIP
' * ia - Is Admin?
' * ib - Is Banned
' * bt - ?
' * ui - User ID
' * npm - ?
' * ava - Avatar Image
' * usertitle - User Title
' * group - User Group
' * nvm - ?
'

Imports System.IO
Imports System.Net
Imports System.Xml
Imports System.Xml.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Security.Cryptography

Namespace GameTuts
    Class GameTutsLogin
        'The url used to login
        Private Const ModioLoginLink As String = "http://www.game-tuts.com/modio/files/services/login.php"
        'The information being sent to the login script
        Private LoginInformation As String
        'Dictionary that stores all the login information
        Private GameTutsDetails As New Dictionary(Of String, String)()

        Friend Function Login(ByVal Username As String, ByVal Password As String) As Boolean
            Try
                'Encrypt the password and build the Login string to be sent to the login script
                LoginInformation = String.Format("&1=null&2=null&usern={0}&userp={1}", Username, BitConverter.ToString(MD5Cng.Create().ComputeHash(Encoding.ASCII.GetBytes(Password))).Replace("-", "").ToString().ToLower())
                Dim ModioLogin As New WebClient()
                ModioLogin.Headers.Add("Content-Type", "application/x-www-form-urlencoded")
                'Send the login information and retrieve the response
                If ParseDetails(Encoding.ASCII.GetString(ModioLogin.UploadData(ModioLoginLink, "POST", Encoding.ASCII.GetBytes(LoginInformation)))) Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return False
            End Try
        End Function

        Friend Function ReadUserDetail(ByVal KeyValue As String) As String
            If GameTutsDetails.ContainsKey(KeyValue) Then
                Return GameTutsDetails(KeyValue)
            Else
                Return Nothing
            End If
        End Function

        Private Function ParseDetails(ByVal LoginResponse As String) As Boolean
            Try
                'Clear the previous login details
                GameTutsDetails.Clear()
                'Remove the hash at the beginning
                LoginResponse = LoginResponse.Remove(0, LoginResponse.IndexOf("<"c)).Trim()
                'Read the details and store them]
                Using XTR As XmlReader = XmlReader.Create(New StringReader(LoginResponse))
                    While XTR.Read()
                        If XTR.IsStartElement() Then
                            If Not String.IsNullOrEmpty(XTR.Name.Trim()) Then
                                Dim SElement As String = XTR.Name.Trim()
                                If XTR.Read() Then
                                    If Not String.IsNullOrEmpty(XTR.Value.Trim()) Then
                                        GameTutsDetails.Add(SElement, XTR.Value.Trim())
                                    End If
                                End If
                            End If
                        End If
                    End While
                End Using
                If GameTutsDetails.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.[Error])
                Return False
            End Try
        End Function

        'Add more if you know them
        Friend Function ConvertUserGroupToName(ByVal UserGroup As Integer) As String
            Select Case UserGroup
                Case 25
                    Return "VIP"
                Case Else
                    Return "Unknown"
            End Select
        End Function
    End Class
End Namespace
