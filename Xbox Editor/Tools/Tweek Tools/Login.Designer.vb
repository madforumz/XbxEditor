<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.txtusername = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.txtpassword = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LoginBB = New DevComponents.DotNetBar.ButtonX()
        Me.ForgotLL = New System.Windows.Forms.LinkLabel()
        Me.RegisterLL = New System.Windows.Forms.LinkLabel()
        Me.LogOutBB = New DevComponents.DotNetBar.ButtonX()
        Me.SuspendLayout()
        '
        'txtusername
        '
        '
        '
        '
        Me.txtusername.Border.Class = "TextBoxBorder"
        Me.txtusername.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtusername.Location = New System.Drawing.Point(12, 3)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(160, 20)
        Me.txtusername.TabIndex = 0
        Me.txtusername.WatermarkText = "Username"
        '
        'txtpassword
        '
        '
        '
        '
        Me.txtpassword.Border.Class = "TextBoxBorder"
        Me.txtpassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtpassword.Location = New System.Drawing.Point(12, 29)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(160, 20)
        Me.txtpassword.TabIndex = 1
        Me.txtpassword.UseSystemPasswordChar = True
        Me.txtpassword.WatermarkText = "Password"
        '
        'LoginBB
        '
        Me.LoginBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.LoginBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.LoginBB.Image = Global.Xbox_Editor.My.Resources.Resources.login
        Me.LoginBB.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.LoginBB.Location = New System.Drawing.Point(178, 3)
        Me.LoginBB.Name = "LoginBB"
        Me.LoginBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.LoginBB.Size = New System.Drawing.Size(75, 20)
        Me.LoginBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LoginBB.TabIndex = 2
        Me.LoginBB.Text = "Login"
        '
        'ForgotLL
        '
        Me.ForgotLL.AutoSize = True
        Me.ForgotLL.BackColor = System.Drawing.Color.Transparent
        Me.ForgotLL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.ForgotLL.Location = New System.Drawing.Point(9, 52)
        Me.ForgotLL.Name = "ForgotLL"
        Me.ForgotLL.Size = New System.Drawing.Size(95, 13)
        Me.ForgotLL.TabIndex = 3
        Me.ForgotLL.TabStop = True
        Me.ForgotLL.Text = "Forgot Password ?"
        '
        'RegisterLL
        '
        Me.RegisterLL.AutoSize = True
        Me.RegisterLL.BackColor = System.Drawing.Color.Transparent
        Me.RegisterLL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.RegisterLL.Location = New System.Drawing.Point(109, 52)
        Me.RegisterLL.Name = "RegisterLL"
        Me.RegisterLL.Size = New System.Drawing.Size(144, 13)
        Me.RegisterLL.TabIndex = 4
        Me.RegisterLL.TabStop = True
        Me.RegisterLL.Text = "Not Registered Sign Up Now"
        '
        'LogOutBB
        '
        Me.LogOutBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.LogOutBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.LogOutBB.Enabled = False
        Me.LogOutBB.Image = CType(resources.GetObject("LogOutBB.Image"), System.Drawing.Image)
        Me.LogOutBB.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.LogOutBB.Location = New System.Drawing.Point(178, 29)
        Me.LogOutBB.Name = "LogOutBB"
        Me.LogOutBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.LogOutBB.Size = New System.Drawing.Size(73, 20)
        Me.LogOutBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.LogOutBB.TabIndex = 5
        Me.LogOutBB.Text = "Log Out"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 69)
        Me.Controls.Add(Me.LogOutBB)
        Me.Controls.Add(Me.RegisterLL)
        Me.Controls.Add(Me.ForgotLL)
        Me.Controls.Add(Me.LoginBB)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtusername As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents txtpassword As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LoginBB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ForgotLL As System.Windows.Forms.LinkLabel
    Friend WithEvents RegisterLL As System.Windows.Forms.LinkLabel
    Friend WithEvents LogOutBB As DevComponents.DotNetBar.ButtonX
End Class
