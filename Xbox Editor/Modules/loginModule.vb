Imports System.Security.Cryptography
Imports System.Text
Imports System.Net
Imports System.IO
Module GTlog
    Dim data As String
    Public Function LoginModule(ByVal Username As String, ByVal Password As String)
        data = "vb_login_username=" & Username & "vb_login_md5password" & Password & "&vb_login_md5password_utf=" & MD5(Password)
        Try

            Dim request As HttpWebRequest = WebRequest.Create("http://www.xboxmb.com/login/login")
            request.Method = WebRequestMethods.Http.Post
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = data.Length
            Dim rStream As New StreamWriter(request.GetRequestStream)
            rStream.Write(data)
            rStream.Flush()
            rStream.Close()
            Dim response As HttpWebResponse = request.GetResponse
            Dim resReader As New StreamReader(response.GetResponseStream)
            Dim str As String = resReader.ReadToEnd
            If str.Contains("Thank you for logging in") Then
                Return True
            Else
                Return False
            End If
            response.Close()
        Catch ex As Exception
            Return False
        End Try
    End Function

    Friend Function MD5(ByVal number As String) As String
        Dim ASCIIenc As New ASCIIEncoding
        Dim strReturn As String = String.Empty
        Dim ByteSourceText() As Byte = ASCIIenc.GetBytes(number)
        Dim Md5Hash As New MD5CryptoServiceProvider
        Dim ByteHash() As Byte = MD5Hash.ComputeHash(ByteSourceText)
        For Each b As Byte In ByteHash
            strReturn &= b.ToString("x2")
        Next
        Return strReturn
    End Function
End Module