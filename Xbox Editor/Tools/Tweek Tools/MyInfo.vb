Imports DevComponents.DotNetBar
Imports Xbox_Editor.GameTuts
Imports Xbox_Editor.Home

Public Class MyInfo
    Dim panel As PanelEx


    Private Sub PCinfoBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCinfoBB.Click
        MyPcInfo.MdiParent = Home
        MyPcInfo.Show()
    End Sub

    Private Sub MyInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim GTL As New GameTutsLogin()
        If GTL.Login(Home.TxtUsername.Text, Home.TxtPassword.Text) Then

            lblUserGroup.Text = String.Format("User Group: {0}", GTL.ConvertUserGroupToName(Convert.ToInt32(GTL.ReadUserDetail("group"))))
            lblUsername.Text = String.Format("Username: {0}", GTL.ReadUserDetail("usf"))
            lblUserTitle.Text = String.Format("User Title: {0}", GTL.ReadUserDetail("usertitle"))
            lblEmail.Text = String.Format("Email: {0}", GTL.ReadUserDetail("e"))
        End If
    End Sub
End Class