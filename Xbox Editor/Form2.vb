Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Xbox_Editor.GameTuts
Imports DevComponents.DotNetBar

Partial Public Class Form2
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub cmdLogin_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim GTL As New GameTutsLogin()
        If GTL.Login(txtUsername.Text, txtPassword.Text) Then
            lblUserGroup.Text = String.Format("User Group: {0}", GTL.ConvertUserGroupToName(Convert.ToInt32(GTL.ReadUserDetail("group"))))
            lblUsername.Text = String.Format("Username: {0}", GTL.ReadUserDetail("usf"))
            lblUserTitle.Text = String.Format("User Title: {0}", GTL.ReadUserDetail("usertitle"))
            lblEmail.Text = String.Format("Email: {0}", GTL.ReadUserDetail("e"))
        Else
            MessageBoxEx.Show("Incorrect username or password!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End If
    End Sub

    Private Sub cmdLogin_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click

    End Sub
End Class