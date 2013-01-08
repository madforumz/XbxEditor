Imports DevComponents.DotNetBar

Public Class Login

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ForgotLL.LinkClicked
        Process.Start("http://www.game-tuts.com/community/login.php?do=lostpw")
    End Sub

    Private Sub LoginBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBB.Click
        If LoginModule(txtusername.Text, txtpassword.Text) = True Then
            MessageBoxEx.Show("Logged In.... Welcome - " + txtusername.Text, Home.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Home.OpenLogin.Text = txtusername.Text
            Home.OpenLogin.ButtonStyle = eButtonStyle.ImageAndText
            Me.Close()
            Home.LoggedIn()
            My.Settings.Username = txtusername.Text
            My.Settings.Password = txtpassword.Text
        Else
            MessageBoxEx.Show("Unable ToLog In... You have entered an invalid username or password. Please enter the correct details and try again. Don't forget that the password is case sensitive.", Home.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles RegisterLL.LinkClicked
        Process.Start("http://www.game-tuts.com/community/register.php")
    End Sub

    Private Sub Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If LoginModule(txtusername.Text, txtpassword.Text) = True Then
                MessageBoxEx.Show("Logged In.... Welcome - " + txtusername.Text, Home.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Home.OpenLogin.Text = txtusername.Text
                Home.OpenLogin.ButtonStyle = eButtonStyle.ImageAndText
                Me.Close()
            Else
                MessageBoxEx.Show("Unable To Log In... You have entered an invalid username or password. Please enter the correct details and try again. Don't forget that the password is case sensitive.", Home.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        KeyPreview = True
    End Sub
End Class