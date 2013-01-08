Public Class Loading1
    Public Property MinimumSplashScreenDisplayTime As Integer
    Private Sub Loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver
        Timer1.Start()
        Me.MinimumSplashScreenDisplayTime = 8000 'Milliseconds

    End Sub


    Private Sub Timer1_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles Timer1.Elapsed
        ProgressBarX1.Increment(6)


    End Sub

    Private Sub MadeByLL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ProgressBarx1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBarx1.Click

    End Sub
End Class