Public NotInheritable Class Loading

    'TODO: This form can easily be set as the splash screen for the application by going to the "Application" tab
    '  of the Project Designer ("Properties" under the "Project" menu).


    Private Sub Loading_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Elapsed(ByVal sender As System.Object, ByVal e As System.Timers.ElapsedEventArgs) Handles Timer1.Elapsed
        ProgressBar1.Increment(2)
        PersentLL.Text = ProgressBar1.Value
        If ProgressBar1.Value = 100 Then
            Home.Show()
            Me.Close()
            Timer1.Stop()
        End If
    End Sub
End Class
