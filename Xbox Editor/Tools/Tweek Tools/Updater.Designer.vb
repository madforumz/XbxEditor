<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Updater
    Inherits DevComponents.DotNetBar.Office2007Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Updater))
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.CheckUpdateBB = New DevComponents.DotNetBar.ButtonX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 64)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(195, 15)
        Me.ProgressBar1.TabIndex = 0
        '
        'CheckUpdateBB
        '
        Me.CheckUpdateBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CheckUpdateBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.CheckUpdateBB.Image = CType(resources.GetObject("CheckUpdateBB.Image"), System.Drawing.Image)
        Me.CheckUpdateBB.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.CheckUpdateBB.Location = New System.Drawing.Point(3, 9)
        Me.CheckUpdateBB.Name = "CheckUpdateBB"
        Me.CheckUpdateBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.CheckUpdateBB.Size = New System.Drawing.Size(195, 36)
        Me.CheckUpdateBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CheckUpdateBB.TabIndex = 1
        Me.CheckUpdateBB.Text = "Check For Updates And Download"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome...."
        '
        'Save
        '
        Me.Save.FileName = "Xbox Editor"
        Me.Save.Filter = "Zip Files|*.zip"
        '
        'Updater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(203, 84)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckUpdateBB)
        Me.Controls.Add(Me.ProgressBar1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Updater"
        Me.Text = "Update Xbox Editor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents CheckUpdateBB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Save As System.Windows.Forms.SaveFileDialog
End Class
