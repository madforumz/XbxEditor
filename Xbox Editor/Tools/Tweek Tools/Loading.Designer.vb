<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Loading))
        Me.PersentLL = New DevComponents.DotNetBar.LabelX()
        Me.LoadingLL = New DevComponents.DotNetBar.LabelX()
        Me.MadeByLL = New DevComponents.DotNetBar.LabelX()
        Me.VersionLL = New DevComponents.DotNetBar.LabelX()
        Me.NameLL = New DevComponents.DotNetBar.LabelX()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Timers.Timer()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PersentLL
        '
        Me.PersentLL.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.PersentLL.BackgroundStyle.Class = ""
        Me.PersentLL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PersentLL.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.PersentLL.Location = New System.Drawing.Point(435, 158)
        Me.PersentLL.Name = "PersentLL"
        Me.PersentLL.Size = New System.Drawing.Size(38, 15)
        Me.PersentLL.TabIndex = 14
        '
        'LoadingLL
        '
        Me.LoadingLL.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LoadingLL.BackgroundStyle.Class = ""
        Me.LoadingLL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LoadingLL.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LoadingLL.Location = New System.Drawing.Point(5, 93)
        Me.LoadingLL.Name = "LoadingLL"
        Me.LoadingLL.Size = New System.Drawing.Size(62, 15)
        Me.LoadingLL.TabIndex = 13
        Me.LoadingLL.Text = "Loading ..."
        '
        'MadeByLL
        '
        Me.MadeByLL.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.MadeByLL.BackgroundStyle.Class = ""
        Me.MadeByLL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MadeByLL.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MadeByLL.ForeColor = System.Drawing.Color.DarkRed
        Me.MadeByLL.Location = New System.Drawing.Point(4, 115)
        Me.MadeByLL.Name = "MadeByLL"
        Me.MadeByLL.Size = New System.Drawing.Size(469, 45)
        Me.MadeByLL.TabIndex = 12
        Me.MadeByLL.Text = "Made By Hohoswithcans Tutorials | And | Modding"
        '
        'VersionLL
        '
        Me.VersionLL.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.VersionLL.BackgroundStyle.Class = ""
        Me.VersionLL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.VersionLL.Font = New System.Drawing.Font("Franklin Gothic Medium", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VersionLL.ForeColor = System.Drawing.Color.DarkRed
        Me.VersionLL.Location = New System.Drawing.Point(83, 61)
        Me.VersionLL.Name = "VersionLL"
        Me.VersionLL.Size = New System.Drawing.Size(128, 17)
        Me.VersionLL.TabIndex = 11
        Me.VersionLL.Text = "Version : Boot Beta 0.0.2"
        '
        'NameLL
        '
        Me.NameLL.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.NameLL.BackgroundStyle.Class = ""
        Me.NameLL.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.NameLL.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLL.ForeColor = System.Drawing.Color.DarkRed
        Me.NameLL.Location = New System.Drawing.Point(83, 21)
        Me.NameLL.Name = "NameLL"
        Me.NameLL.Size = New System.Drawing.Size(118, 45)
        Me.NameLL.TabIndex = 10
        Me.NameLL.Text = "Xbox Editor"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(67, 93)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(357, 16)
        Me.ProgressBar1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 66)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.SynchronizingObject = Me
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelX1.Location = New System.Drawing.Point(428, 93)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(38, 15)
        Me.LabelX1.TabIndex = 15
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.BackgroundImage = Global.Xbox_Editor.My.Resources.Resources.backagrong
        Me.ClientSize = New System.Drawing.Size(478, 165)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.PersentLL)
        Me.Controls.Add(Me.LoadingLL)
        Me.Controls.Add(Me.MadeByLL)
        Me.Controls.Add(Me.VersionLL)
        Me.Controls.Add(Me.NameLL)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Loading"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Timer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PersentLL As DevComponents.DotNetBar.LabelX
    Friend WithEvents LoadingLL As DevComponents.DotNetBar.LabelX
    Friend WithEvents MadeByLL As DevComponents.DotNetBar.LabelX
    Friend WithEvents VersionLL As DevComponents.DotNetBar.LabelX
    Friend WithEvents NameLL As DevComponents.DotNetBar.LabelX
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Timers.Timer
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX

End Class
