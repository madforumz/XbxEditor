Imports DevComponents.DotNetBar
Imports System.Net
Imports System.ComponentModel
Public Class Loading1
    Public Property MinimumSplashScreenDisplayTime As Integer
    Private Sub Loading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver
        Timer1.Start()
        MinimumSplashScreenDisplayTime = 80000 'Milliseconds
    End Sub
   
    Private Sub Timer1_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles Timer1.Elapsed
        ProgressBar1.Increment(8)
    End Sub
End Class