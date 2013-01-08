Public Class MyPcInfo

    Private Sub MyPcInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PanelEx1.Text = My.Computer.Info.OSFullName
        PanelEx2.Text = My.Computer.Info.OSPlatform
        PanelEx3.Text = ("Memory " & My.Computer.Info.TotalVirtualMemory)
        PanelEx4.Text = My.Computer.Name
    End Sub
End Class