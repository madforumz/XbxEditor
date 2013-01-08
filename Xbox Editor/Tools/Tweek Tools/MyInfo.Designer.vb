<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyInfo))
        Me.InfoP = New DevComponents.DotNetBar.PanelEx()
        Me.lblEmail = New DevComponents.DotNetBar.PanelEx()
        Me.lblUserTitle = New DevComponents.DotNetBar.PanelEx()
        Me.lblUserGroup = New DevComponents.DotNetBar.PanelEx()
        Me.lblUsername = New DevComponents.DotNetBar.PanelEx()
        Me.PCinfoBB = New DevComponents.DotNetBar.ButtonX()
        Me.InfoP.SuspendLayout()
        Me.SuspendLayout()
        '
        'InfoP
        '
        Me.InfoP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoP.CanvasColor = System.Drawing.SystemColors.Control
        Me.InfoP.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.InfoP.Controls.Add(Me.lblEmail)
        Me.InfoP.Controls.Add(Me.lblUserTitle)
        Me.InfoP.Controls.Add(Me.lblUserGroup)
        Me.InfoP.Controls.Add(Me.lblUsername)
        Me.InfoP.Controls.Add(Me.PCinfoBB)
        Me.InfoP.Location = New System.Drawing.Point(3, 2)
        Me.InfoP.Name = "InfoP"
        Me.InfoP.Size = New System.Drawing.Size(252, 183)
        Me.InfoP.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.InfoP.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.InfoP.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.InfoP.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.InfoP.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.InfoP.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.InfoP.Style.GradientAngle = 90
        Me.InfoP.TabIndex = 0
        '
        'lblEmail
        '
        Me.lblEmail.CanvasColor = System.Drawing.SystemColors.Control
        Me.lblEmail.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.lblEmail.Location = New System.Drawing.Point(9, 111)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(230, 28)
        Me.lblEmail.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.lblEmail.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.lblEmail.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.lblEmail.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.lblEmail.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.lblEmail.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.lblEmail.Style.GradientAngle = 90
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.Text = "Email"
        '
        'lblUserTitle
        '
        Me.lblUserTitle.CanvasColor = System.Drawing.SystemColors.Control
        Me.lblUserTitle.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.lblUserTitle.Location = New System.Drawing.Point(9, 77)
        Me.lblUserTitle.Name = "lblUserTitle"
        Me.lblUserTitle.Size = New System.Drawing.Size(230, 28)
        Me.lblUserTitle.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.lblUserTitle.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.lblUserTitle.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.lblUserTitle.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.lblUserTitle.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.lblUserTitle.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.lblUserTitle.Style.GradientAngle = 90
        Me.lblUserTitle.TabIndex = 7
        Me.lblUserTitle.Text = "User Title"
        '
        'lblUserGroup
        '
        Me.lblUserGroup.CanvasColor = System.Drawing.SystemColors.Control
        Me.lblUserGroup.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.lblUserGroup.Location = New System.Drawing.Point(9, 43)
        Me.lblUserGroup.Name = "lblUserGroup"
        Me.lblUserGroup.Size = New System.Drawing.Size(230, 28)
        Me.lblUserGroup.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.lblUserGroup.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.lblUserGroup.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.lblUserGroup.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.lblUserGroup.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.lblUserGroup.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.lblUserGroup.Style.GradientAngle = 90
        Me.lblUserGroup.TabIndex = 6
        Me.lblUserGroup.Text = "Group"
        '
        'lblUsername
        '
        Me.lblUsername.CanvasColor = System.Drawing.SystemColors.Control
        Me.lblUsername.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.lblUsername.Location = New System.Drawing.Point(9, 9)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(230, 28)
        Me.lblUsername.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.lblUsername.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.lblUsername.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.lblUsername.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.lblUsername.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.lblUsername.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.lblUsername.Style.GradientAngle = 90
        Me.lblUsername.TabIndex = 5
        Me.lblUsername.Text = "Username"
        '
        'PCinfoBB
        '
        Me.PCinfoBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.PCinfoBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.PCinfoBB.Image = Global.Xbox_Editor.My.Resources.Resources.key_services
        Me.PCinfoBB.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.PCinfoBB.Location = New System.Drawing.Point(8, 145)
        Me.PCinfoBB.Name = "PCinfoBB"
        Me.PCinfoBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.PCinfoBB.Size = New System.Drawing.Size(231, 27)
        Me.PCinfoBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PCinfoBB.TabIndex = 4
        Me.PCinfoBB.Text = "My Pc Info"
        '
        'MyInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(256, 187)
        Me.Controls.Add(Me.InfoP)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MyInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Info"
        Me.InfoP.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InfoP As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PCinfoBB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents lblUsername As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblEmail As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblUserTitle As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblUserGroup As DevComponents.DotNetBar.PanelEx
End Class
