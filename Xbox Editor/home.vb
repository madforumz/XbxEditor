Imports DevComponents.DotNetBar
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Xbox_Editor.GameTuts

Public Class Home
    Private Sub OpenLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenLogin.Click
        TxtUsername.Select()
        UpdatesEP.Expanded = True
        If UpdatesEP.Expanded = True Then
            TxtUsername.Select()
        Else : UpdatesEP.Expanded = False
        End If
    End Sub
    
    Public Sub Mdi()
        Login.MdiParent = Me
        Assassin_s2.MdiParent = Me
        brotherhood.MdiParent = Me
        Bulletstorm.MdiParent = Me
        AvatarEditor.MdiParent = Me
        Borderlands.MdiParent = Me
        brotherhood.MdiParent = Me
        Emailer.MdiParent = Me
        TigerWoods11.MdiParent = Me
        TigerWoods12.MdiParent = Me
        TigerWoods13.MdiParent = Me
        XboxManager.MdiParent = Me
    End Sub

    Private Sub home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MessageBoxEx.EnableGlass = False
        KeyPreview = True
        TxtUsername.Text = My.Settings.Username
        TxtPassword.Text = My.Settings.Password
    End Sub
    Public Sub LoggedIn()
        LoginBB.Enabled = False
        TxtUsername.Enabled = False
        TxtPassword.Enabled = False
        LoginBB.ColorTable = eButtonColor.OrangeWithBackground
        LogOutBB.Enabled = True
        Login.ForgotLL.Enabled = False
        RegisterBB.Enabled = False
        ForgotBB.Enabled = False
        ForgotBB.Visible = False
        RegisterBB.Visible = False
        AutoLoginBB.Visible = False
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub LoginBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginBB.Click
        Try
            Dim Logi222 As New loginCode()
            If Logi222.CheckSite(TxtUsername.Text, TxtPassword.Text) Then
                MessageBoxEx.Show("Logged In.... Welcome - " + TxtUsername.Text, Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                OpenLogin.ButtonStyle = eButtonStyle.ImageAndText
                LoggedIn()
                LogOutBB.Enabled = True
                OpenLogin.Enabled = False
                AboutBB.Enabled = True
                auto()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub auto()
        If AutoLoginBB.Checked Then
            My.Settings.Username = TxtUsername.Text
            My.Settings.Password = TxtPassword.Text
            My.Settings.AutoLogin = 1
            My.Settings.Save()
        Else
            My.Settings.AutoLogin = 0
            My.Settings.Save()
        End If
    End Sub

    Private Sub LogOutBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutBB.Click
        LoginBB.Enabled = True
        OpenLogin.Enabled = True
        OpenLogin.ButtonStyle = eButtonStyle.ImageAndText
        TxtUsername.Enabled = True
        TxtPassword.Enabled = True
        LoginBB.ColorTable = eButtonColor.OrangeWithBackground
        LogOutBB.Enabled = False
        Login.ForgotLL.Enabled = True
        RegisterBB.Enabled = True
        ForgotBB.Enabled = True
        TxtUsername.Text = ""
        OpenLogin.Text = "Login"
        TxtPassword.Text = ""
        AboutBB.Enabled = False
        ForgotBB.Visible = True
        RegisterBB.Enabled = True
        RegisterBB.Visible = True
        AutoLoginBB.Visible = True
    End Sub

    Private Sub AssassinsCreed2BB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssassinsCreedIIBB1.Click
        Assassin_s2.MdiParent = Me
        Assassin_s2.Show()
    End Sub

    Private Sub AssassinsCreedBHBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssassinsCreedBHBB1.Click
        brotherhood.MdiParent = Me
        brotherhood.Show()
    End Sub

    Private Sub BorderlandsBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorderlandsBB1.Click
        Borderlands.MdiParent = Me
        Borderlands.Show()
    End Sub

    Private Sub BulletstormBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BulletstormBB1.Click
        Bulletstorm.MdiParent = Me
        Bulletstorm.Show()
    End Sub

    Private Sub TigerWoods11BB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TigerWoods11BB.Click
        TigerWoods11.MdiParent = Me
        TigerWoods11.Show()
    End Sub

    Private Sub TigerWoods12BB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TigerWoods12BB.Click
        TigerWoods12.MdiParent = Me
        TigerWoods12.Show()
    End Sub

    Private Sub TigerWoods13BB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TigerWoods13BB.Click
        TigerWoods13.MdiParent = Me
        TigerWoods13.Show()
    End Sub

    Private Sub AvatarEditorBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvatarEditorBB.Click
        AvatarEditor.MdiParent = Me
        AvatarEditor.Show()
    End Sub
    Private Sub home_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragEnter
        e.Effect = DragDropEffects.All
    End Sub
    Dim xbox As New XboxManager
    Private Sub home_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles MyBase.DragDrop
        Try
            Dim files As String() = DirectCast(e.Data.GetData(DataFormats.FileDrop, False), String())
            For Each file As String In files
                xbox.FilePath = file
                xbox.ReadFile(xbox.FilePath)
                xbox.MdiParent = Me
                xbox.Show()
                xbox.ProfileID.Enabled = True
            Next
        Catch ex As Exception
            MessageBoxEx.Show("This File May Be Corrupted.....", "Xbox Editor", MessageBoxButtons.OK, MessageBoxIcon.Error)
            xbox.Close()
        End Try
    End Sub

    Private Sub home_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        My.Settings.Save()
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://madforumz.forumotion.com/")
    End Sub

    Private Sub AssassinsCreed3BB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AssassinsCreed3BB1.Click
        AssassinsCreed3.MdiParent = Me
        AssassinsCreed3.Show()
    End Sub

    Private Sub WetBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WetBB.Click
        Wet.MdiParent = Me
        Wet.Show()
    End Sub

    Private Sub FarCry3BB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FarCry3BB1.Click
        FarCry3.MdiParent = Me
        FarCry3.Show()
    End Sub
    Dim BtnClickCount As Integer = 0
    Private Sub AutoLoginBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoLoginBB.Click
        If BtnClickCount = 0 Then
            AutoLoginBB.Checked = True
            BtnClickCount = 1
            My.Settings.AutoLogin = 1
            My.Settings.Save()
        Else
            AutoLoginBB.Checked = False
            BtnClickCount = 0
            My.Settings.AutoLogin = 0
            My.Settings.Save()
        End If
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        XboxManager.SaveFileDialog1.ShowDialog()
        XboxManager.ContentImage.BackgroundImage.Save(XboxManager.SaveFileDialog1.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png)
    End Sub

    Private Sub NeedForSpeed2012BB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        NeedForSpeed2012.MdiParent = Me
        NeedForSpeed2012.Show();
    End Sub

    Private Sub ButtonItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XboxManagerBB.Click
        Try
            Dim open As New OpenFileDialog
            Dim xbox As New XboxManager
            If open.ShowDialog() = Windows.Forms.DialogResult.OK Then
                xbox.FilePath = open.FileName
                xbox.ReadFile(xbox.FilePath)
                xbox.MdiParent = Me
                xbox.ProfileID.Enabled = True
                xbox.Show()
            End If
        Catch ex As Exception

            If MessageBoxEx.Show("This File May Be Corrupted....." & "Would You Like To Try Again ?", "Xbox Editor", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) = Windows.Forms.DialogResult.OK Then
                Dim open As New OpenFileDialog
                Dim xbox As New XboxManager
                If open.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    xbox.FilePath = open.FileName
                    xbox.ReadFile(xbox.FilePath)
                    xbox.MdiParent = Me
                    xbox.ProfileID.Enabled = True
                    xbox.Show()
                End If
            End If

        End Try
    End Sub

    Private Sub ButtonItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyInfoBB.Click
        MyInfo.MdiParent = Me
        MyInfo.Show()
    End Sub

    Private Sub AboutBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        About.MdiParent = Me
        About.Show()
    End Sub

    Private Sub labelItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub EditorToolsBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditorToolsBB.Click

    End Sub

    Private Sub Office2007StartButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutBB.Click
        About.MdiParent = Me
        About.Show()
    End Sub

    Private Sub MidnightClubLaBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MidnightClubLaBB.Click
        MidnightClub.MdiParent = Me
        MidnightClub.Show()
    End Sub

    Private Sub ExpandablePanel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpandablePanel1.Click
        ItemPanel1.Size = GalleryContainer3.DefaultSize + ItemPanel1.Size
    End Sub

    Private Sub AavtarEditorBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AvatarEditorBB.Click

    End Sub
End Class