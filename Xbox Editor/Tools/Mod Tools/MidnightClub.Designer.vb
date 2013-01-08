<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MidnightClub
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MidnightClub))
        Me.SaveBB = New DevComponents.DotNetBar.ButtonX()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.OpenAss = New DevComponents.DotNetBar.ButtonX()
        Me.Save = New DevComponents.DotNetBar.ButtonX()
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem2 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.Money = New DevComponents.Editors.IntegerInput()
        Me.Rep = New DevComponents.Editors.IntegerInput()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.MaxBB = New DevComponents.DotNetBar.ButtonX()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        CType(Me.Money, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SaveBB
        '
        Me.SaveBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.SaveBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.SaveBB.Location = New System.Drawing.Point(182, 2)
        Me.SaveBB.Name = "SaveBB"
        Me.SaveBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.SaveBB.Size = New System.Drawing.Size(188, 23)
        Me.SaveBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SaveBB.TabIndex = 2
        Me.SaveBB.Text = "Save"
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.Controls.Add(Me.OpenAss)
        Me.Bar1.Controls.Add(Me.Save)
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ControlContainerItem1, Me.ControlContainerItem2})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(269, 31)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 14
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'OpenAss
        '
        Me.OpenAss.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.OpenAss.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.OpenAss.Image = CType(resources.GetObject("OpenAss.Image"), System.Drawing.Image)
        Me.OpenAss.Location = New System.Drawing.Point(3, 2)
        Me.OpenAss.Name = "OpenAss"
        Me.OpenAss.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.OpenAss.Size = New System.Drawing.Size(128, 26)
        Me.OpenAss.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.OpenAss.TabIndex = 10
        Me.OpenAss.Text = "Open"
        '
        'Save
        '
        Me.Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Save.Enabled = False
        Me.Save.Image = CType(resources.GetObject("Save.Image"), System.Drawing.Image)
        Me.Save.ImageFixedSize = New System.Drawing.Size(18, 18)
        Me.Save.Location = New System.Drawing.Point(135, 2)
        Me.Save.Name = "Save"
        Me.Save.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.Save.Size = New System.Drawing.Size(130, 26)
        Me.Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Save.TabIndex = 11
        Me.Save.Text = "Save"
        '
        'ControlContainerItem1
        '
        Me.ControlContainerItem1.AllowItemResize = False
        Me.ControlContainerItem1.Control = Me.OpenAss
        Me.ControlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem1.Name = "ControlContainerItem1"
        '
        'ControlContainerItem2
        '
        Me.ControlContainerItem2.AllowItemResize = False
        Me.ControlContainerItem2.Control = Me.Save
        Me.ControlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem2.Name = "ControlContainerItem2"
        '
        'Money
        '
        '
        '
        '
        Me.Money.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Money.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Money.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Money.Enabled = False
        Me.Money.Location = New System.Drawing.Point(3, 3)
        Me.Money.Name = "Money"
        Me.Money.ShowUpDown = True
        Me.Money.Size = New System.Drawing.Size(128, 20)
        Me.Money.TabIndex = 15
        Me.Money.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.Money.WatermarkText = "Your Cash"
        '
        'Rep
        '
        '
        '
        '
        Me.Rep.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Rep.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Rep.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Rep.Enabled = False
        Me.Rep.Location = New System.Drawing.Point(3, 29)
        Me.Rep.Name = "Rep"
        Me.Rep.ShowUpDown = True
        Me.Rep.Size = New System.Drawing.Size(128, 20)
        Me.Rep.TabIndex = 16
        Me.Rep.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.Rep.WatermarkText = "Your Rep"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.MaxBB)
        Me.PanelEx1.Controls.Add(Me.Money)
        Me.PanelEx1.Controls.Add(Me.Rep)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEx1.Location = New System.Drawing.Point(0, 31)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(275, 54)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 17
        '
        'MaxBB
        '
        Me.MaxBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.MaxBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.MaxBB.Enabled = False
        Me.MaxBB.Image = Global.Xbox_Editor.My.Resources.Resources.StockIndexUp
        Me.MaxBB.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.MaxBB.Location = New System.Drawing.Point(135, 3)
        Me.MaxBB.Name = "MaxBB"
        Me.MaxBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.MaxBB.Size = New System.Drawing.Size(130, 46)
        Me.MaxBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MaxBB.TabIndex = 17
        Me.MaxBB.Text = "Max"
        '
        'MidnightClub
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 85)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.Bar1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MidnightClub"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Midnight Club LA"
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        CType(Me.Money, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveBB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents OpenAss As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Save As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ControlContainerItem2 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents Money As DevComponents.Editors.IntegerInput
    Friend WithEvents Rep As DevComponents.Editors.IntegerInput
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents MaxBB As DevComponents.DotNetBar.ButtonX
End Class
