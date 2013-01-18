<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FarCry3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FarCry3))
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.OpenAss = New DevComponents.DotNetBar.ButtonX()
        Me.Save = New DevComponents.DotNetBar.ButtonX()
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem2 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.MoneyII = New DevComponents.Editors.IntegerInput()
        Me.MoneyGP = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.MaxBB = New DevComponents.DotNetBar.ButtonX()
        Me.ResignBB = New DevComponents.DotNetBar.ButtonX()
        Me.ControlContainerItem3 = New DevComponents.DotNetBar.ControlContainerItem()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        CType(Me.MoneyII, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MoneyGP.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.Controls.Add(Me.ResignBB)
        Me.Bar1.Controls.Add(Me.OpenAss)
        Me.Bar1.Controls.Add(Me.Save)
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ControlContainerItem1, Me.ControlContainerItem2, Me.ControlContainerItem3})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(274, 31)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 13
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
        Me.OpenAss.Size = New System.Drawing.Size(123, 26)
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
        Me.Save.Location = New System.Drawing.Point(130, 2)
        Me.Save.Name = "Save"
        Me.Save.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.Save.Size = New System.Drawing.Size(110, 26)
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
        'MoneyII
        '
        '
        '
        '
        Me.MoneyII.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.MoneyII.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MoneyII.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.MoneyII.Enabled = False
        Me.MoneyII.Location = New System.Drawing.Point(3, 3)
        Me.MoneyII.MaxValue = 890004201
        Me.MoneyII.Name = "MoneyII"
        Me.MoneyII.ShowUpDown = True
        Me.MoneyII.Size = New System.Drawing.Size(120, 20)
        Me.MoneyII.TabIndex = 14
        Me.MoneyII.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.MoneyII.WatermarkText = "Money"
        '
        'MoneyGP
        '
        Me.MoneyGP.CanvasColor = System.Drawing.SystemColors.Control
        Me.MoneyGP.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.MoneyGP.Controls.Add(Me.MaxBB)
        Me.MoneyGP.Controls.Add(Me.MoneyII)
        Me.MoneyGP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MoneyGP.Location = New System.Drawing.Point(0, 31)
        Me.MoneyGP.Name = "MoneyGP"
        Me.MoneyGP.Size = New System.Drawing.Size(274, 48)
        '
        '
        '
        Me.MoneyGP.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.MoneyGP.Style.BackColorGradientAngle = 90
        Me.MoneyGP.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.MoneyGP.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MoneyGP.Style.BorderBottomWidth = 1
        Me.MoneyGP.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.MoneyGP.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MoneyGP.Style.BorderLeftWidth = 1
        Me.MoneyGP.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MoneyGP.Style.BorderRightWidth = 1
        Me.MoneyGP.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.MoneyGP.Style.BorderTopWidth = 1
        Me.MoneyGP.Style.Class = ""
        Me.MoneyGP.Style.CornerDiameter = 4
        Me.MoneyGP.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.MoneyGP.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.MoneyGP.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.MoneyGP.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.MoneyGP.StyleMouseDown.Class = ""
        Me.MoneyGP.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.MoneyGP.StyleMouseOver.Class = ""
        Me.MoneyGP.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MoneyGP.TabIndex = 15
        Me.MoneyGP.Text = "Customize Money"
        '
        'MaxBB
        '
        Me.MaxBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.MaxBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.MaxBB.Enabled = False
        Me.MaxBB.Image = Global.Xbox_Editor.My.Resources.Resources.StockIndexUp
        Me.MaxBB.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.MaxBB.Location = New System.Drawing.Point(127, 3)
        Me.MaxBB.Name = "MaxBB"
        Me.MaxBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.MaxBB.Size = New System.Drawing.Size(140, 20)
        Me.MaxBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MaxBB.TabIndex = 15
        Me.MaxBB.Text = "Max"
        '
        'ResignBB
        '
        Me.ResignBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ResignBB.BackColor = System.Drawing.Color.Transparent
        Me.ResignBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ResignBB.Enabled = False
        Me.ResignBB.Image = Global.Xbox_Editor.My.Resources.Resources.Tools_Icon
        Me.ResignBB.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.ResignBB.Location = New System.Drawing.Point(244, 2)
        Me.ResignBB.Name = "ResignBB"
        Me.ResignBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ResignBB.Size = New System.Drawing.Size(26, 26)
        Me.ResignBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ResignBB.TabIndex = 17
        '
        'ControlContainerItem3
        '
        Me.ControlContainerItem3.AllowItemResize = False
        Me.ControlContainerItem3.Control = Me.ResignBB
        Me.ControlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem3.Name = "ControlContainerItem3"
        '
        'FarCry3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 79)
        Me.Controls.Add(Me.MoneyGP)
        Me.Controls.Add(Me.Bar1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FarCry3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Far Cry 3"
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        CType(Me.MoneyII, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MoneyGP.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents OpenAss As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Save As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ControlContainerItem2 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents MoneyII As DevComponents.Editors.IntegerInput
    Friend WithEvents MoneyGP As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents MaxBB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ResignBB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ControlContainerItem3 As DevComponents.DotNetBar.ControlContainerItem
End Class
