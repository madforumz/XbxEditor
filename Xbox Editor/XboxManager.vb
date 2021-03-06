Imports DevComponents.DotNetBar
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Globalization
Imports XboxEditor.IO
Imports XboxEditor.STFS

Public Class XboxManager
    Public FilePath As String
    Dim STFS As STFSPackage

    Public Sub ReadFile(ByVal FilePath As String)
        STFS = New STFSPackage(FilePath)
        PackageImage.Image = STFS.PackageImage
        TitleImage.Image = STFS.TitleImage
        TitleID.Text = Conversions.BytesToString(STFS.TitleID)
        DisplayName.Text = STFS.DisplayName
        TitleName.Text = STFS.TitleName
        ProfileID.Text = Conversions.BytesToString(STFS.ProfileID)
        DeviceID.Text = Conversions.BytesToString(STFS.DeviceID)
        ConsoleID.Text = Conversions.BytesToString(STFS.ConsoleID)
        ParseLicenseTable()
    End Sub

    Public Sub ReadFile(ByRef STFS As STFSPackage)
        Me.STFS = STFS
        PackageImage.Image = STFS.PackageImage
        TitleImage.Image = STFS.TitleImage
        TitleID.Text = Conversions.BytesToString(STFS.TitleID)
        DisplayName.Text = STFS.DisplayName
        TitleName.Text = STFS.TitleName
        ProfileID.Text = Conversions.BytesToString(STFS.ProfileID)
        DeviceID.Text = Conversions.BytesToString(STFS.DeviceID)
        ConsoleID.Text = Conversions.BytesToString(STFS.ConsoleID)
        ParseLicenseTable()
    End Sub

    Sub ParseLicenseTable()
        For Each l As LicenseEntry In STFS.Licenses
            Dim i As New ListViewItem(l.LicenseID.ToString())
            i.SubItems.Add(l.LicenseBits)
            i.SubItems.Add(l.LicenseFlags)
            listLicenses.Items.Add(i)
        Next
    End Sub

    Public Sub WriteFile()
        Dim profile As Byte() = Conversions.StringToBytes(ProfileID.Text)
        Dim device As Byte() = Conversions.StringToBytes(DeviceID.Text)
        Dim console As Byte() = Conversions.StringToBytes(ConsoleID.Text)
        STFS.WriteIDs(profile, device, console)
        STFS.WriteDisplayName(DisplayName.Text)
        STFS.RehashResign()
    End Sub

    Private Sub Extract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SaveFileDialog1.ShowDialog()
        TitleImage.Image.Save(SaveFileDialog1.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png)
    End Sub

    Private Sub RehashBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            WriteFile()
            MessageBoxEx.Show("Your File Has Beeen Saved And Resigned", "Xbox Editor")
        Catch ex As Exception
            MessageBoxEx.Show(ex.Message, "Oops...")
        End Try
    End Sub

    Private Sub EToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        PackageImage.Image.Save(SaveFileDialog1.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png)
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        SaveFileDialog1.ShowDialog()
        TitleImage.Image.Save(SaveFileDialog1.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png)
    End Sub

    Private Sub ResignBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResignBB.Click
        WriteFile()
    End Sub
    Public Sub modsfile()
        
    End Sub

    Private Sub OpenBB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenBB.Click
        
    End Sub

    Private Sub btnNullAll_Click(sender As Object, e As EventArgs) Handles btnNullAll.Click
        STFS.NullAllLicenseEntries()
        ParseLicenseTable()
    End Sub
End Class