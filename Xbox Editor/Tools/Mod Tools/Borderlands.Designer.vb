<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borderlands
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Borderlands))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Level = New DevComponents.Editors.IntegerInput()
        Me.Max = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem4 = New DevComponents.DotNetBar.ButtonItem()
        Me.Money = New DevComponents.Editors.IntegerInput()
        Me.Skillpoints = New DevComponents.Editors.IntegerInput()
        Me.Save = New DevComponents.DotNetBar.ButtonX()
        Me.OpenAss = New DevComponents.DotNetBar.ButtonX()
        Me.Xpoints = New DevComponents.Editors.IntegerInput()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem2 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.PanelEx1.SuspendLayout()
        CType(Me.Level, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Money, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Skillpoints, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Xpoints, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Level)
        Me.PanelEx1.Controls.Add(Me.Max)
        Me.PanelEx1.Controls.Add(Me.Money)
        Me.PanelEx1.Controls.Add(Me.Skillpoints)
        Me.PanelEx1.Controls.Add(Me.Xpoints)
        Me.PanelEx1.Location = New System.Drawing.Point(0, 34)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(260, 85)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1
        '
        'Level
        '
        '
        '
        '
        Me.Level.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Level.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Level.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Level.Enabled = False
        Me.Level.Location = New System.Drawing.Point(7, 3)
        Me.Level.MinValue = 0
        Me.Level.Name = "Level"
        Me.Level.ShowUpDown = True
        Me.Level.Size = New System.Drawing.Size(115, 20)
        Me.Level.TabIndex = 17
        Me.Level.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.Level.WatermarkText = "Level"
        '
        'Max
        '
        Me.Max.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Max.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Max.Enabled = False
        Me.Max.Image = Global.Xbox_Editor.My.Resources.Resources.StockIndexUp
        Me.Max.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.Max.Location = New System.Drawing.Point(7, 55)
        Me.Max.Name = "Max"
        Me.Max.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.Max.Size = New System.Drawing.Size(246, 21)
        Me.Max.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Max.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem1, Me.ButtonItem2, Me.ButtonItem3, Me.ButtonItem4})
        Me.Max.TabIndex = 16
        Me.Max.Text = "Max"
        '
        'ButtonItem1
        '
        Me.ButtonItem1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonItem1.GlobalItem = False
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonItem1.Text = "Level"
        '
        'ButtonItem2
        '
        Me.ButtonItem2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonItem2.GlobalItem = False
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonItem2.Text = "XP Points"
        '
        'ButtonItem3
        '
        Me.ButtonItem3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonItem3.GlobalItem = False
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonItem3.Text = "Skill Points"
        '
        'ButtonItem4
        '
        Me.ButtonItem4.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonItem4.GlobalItem = False
        Me.ButtonItem4.Name = "ButtonItem4"
        Me.ButtonItem4.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ButtonItem4.Text = "Money/Cash"
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
        Me.Money.Location = New System.Drawing.Point(128, 29)
        Me.Money.MinValue = 0
        Me.Money.Name = "Money"
        Me.Money.ShowUpDown = True
        Me.Money.Size = New System.Drawing.Size(125, 20)
        Me.Money.TabIndex = 15
        Me.Money.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.Money.WatermarkText = "Money/Cash"
        '
        'Skillpoints
        '
        '
        '
        '
        Me.Skillpoints.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Skillpoints.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Skillpoints.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Skillpoints.Enabled = False
        Me.Skillpoints.Location = New System.Drawing.Point(7, 29)
        Me.Skillpoints.MinValue = 0
        Me.Skillpoints.Name = "Skillpoints"
        Me.Skillpoints.ShowUpDown = True
        Me.Skillpoints.Size = New System.Drawing.Size(115, 20)
        Me.Skillpoints.TabIndex = 14
        Me.Skillpoints.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.Skillpoints.WatermarkText = "Skill Points"
        '
        'Save
        '
        Me.Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Save.Enabled = False
        Me.Save.Image = CType(resources.GetObject("Save.Image"), System.Drawing.Image)
        Me.Save.ImageFixedSize = New System.Drawing.Size(18, 18)
        Me.Save.Location = New System.Drawing.Point(126, 2)
        Me.Save.Name = "Save"
        Me.Save.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.Save.Size = New System.Drawing.Size(127, 26)
        Me.Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Save.TabIndex = 13
        Me.Save.Text = "Save"
        '
        'OpenAss
        '
        Me.OpenAss.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.OpenAss.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.OpenAss.Image = CType(resources.GetObject("OpenAss.Image"), System.Drawing.Image)
        Me.OpenAss.Location = New System.Drawing.Point(3, 2)
        Me.OpenAss.Name = "OpenAss"
        Me.OpenAss.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.OpenAss.Size = New System.Drawing.Size(119, 26)
        Me.OpenAss.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.OpenAss.TabIndex = 12
        Me.OpenAss.Text = "Open"
        '
        'Xpoints
        '
        '
        '
        '
        Me.Xpoints.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Xpoints.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Xpoints.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Xpoints.Enabled = False
        Me.Xpoints.Location = New System.Drawing.Point(128, 3)
        Me.Xpoints.MinValue = 0
        Me.Xpoints.Name = "Xpoints"
        Me.Xpoints.ShowUpDown = True
        Me.Xpoints.Size = New System.Drawing.Size(125, 20)
        Me.Xpoints.TabIndex = 1
        Me.Xpoints.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.Xpoints.WatermarkText = "XP Points"
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
        Me.Bar1.Size = New System.Drawing.Size(260, 31)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 2
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
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
        'Borderlands
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 114)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.PanelEx1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Borderlands"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Borderlands"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.Level, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Money, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Skillpoints, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Xpoints, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Money As DevComponents.Editors.IntegerInput
    Friend WithEvents Skillpoints As DevComponents.Editors.IntegerInput
    Friend WithEvents Save As DevComponents.DotNetBar.ButtonX
    Friend WithEvents OpenAss As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Max As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem4 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Level As DevComponents.Editors.IntegerInput
    Friend WithEvents Xpoints As DevComponents.Editors.IntegerInput
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ControlContainerItem2 As DevComponents.DotNetBar.ControlContainerItem
End Class
