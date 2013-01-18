<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NeedForSpeed2012
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NeedForSpeed2012))
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.ResignBB = New DevComponents.DotNetBar.ButtonX()
        Me.OpenAss = New DevComponents.DotNetBar.ButtonX()
        Me.Save = New DevComponents.DotNetBar.ButtonX()
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem2 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem3 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.MaxBB = New DevComponents.DotNetBar.ButtonX()
        Me.ResultsII = New DevComponents.Editors.IntegerInput()
        Me.DrivingII = New DevComponents.Editors.IntegerInput()
        Me.SpII = New DevComponents.Editors.IntegerInput()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        Me.GroupPanel1.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.ResultsII, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DrivingII, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpII, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.Controls.Add(Me.OpenAss)
        Me.Bar1.Controls.Add(Me.Save)
        Me.Bar1.Controls.Add(Me.ResignBB)
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ControlContainerItem1, Me.ControlContainerItem2, Me.ControlContainerItem3})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(264, 31)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 14
        Me.Bar1.TabStop = False
        Me.Bar1.Text = "Bar1"
        '
        'ResignBB
        '
        Me.ResignBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ResignBB.BackColor = System.Drawing.Color.Transparent
        Me.ResignBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ResignBB.Enabled = False
        Me.ResignBB.Image = Global.Xbox_Editor.My.Resources.Resources.Tools_Icon
        Me.ResignBB.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.ResignBB.Location = New System.Drawing.Point(233, 2)
        Me.ResignBB.Name = "ResignBB"
        Me.ResignBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ResignBB.Size = New System.Drawing.Size(26, 26)
        Me.ResignBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ResignBB.TabIndex = 17
        '
        'OpenAss
        '
        Me.OpenAss.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.OpenAss.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.OpenAss.Image = CType(resources.GetObject("OpenAss.Image"), System.Drawing.Image)
        Me.OpenAss.Location = New System.Drawing.Point(3, 2)
        Me.OpenAss.Name = "OpenAss"
        Me.OpenAss.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.OpenAss.Size = New System.Drawing.Size(109, 26)
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
        Me.Save.Location = New System.Drawing.Point(116, 2)
        Me.Save.Name = "Save"
        Me.Save.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.Save.Size = New System.Drawing.Size(113, 26)
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
        'ControlContainerItem3
        '
        Me.ControlContainerItem3.AllowItemResize = False
        Me.ControlContainerItem3.Control = Me.ResignBB
        Me.ControlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem3.Name = "ControlContainerItem3"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.PanelEx1)
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 31)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(264, 62)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.Class = ""
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.Class = ""
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.Class = ""
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 15
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.MaxBB)
        Me.PanelEx1.Controls.Add(Me.ResultsII)
        Me.PanelEx1.Controls.Add(Me.DrivingII)
        Me.PanelEx1.Controls.Add(Me.SpII)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(258, 56)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'MaxBB
        '
        Me.MaxBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.MaxBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.MaxBB.Enabled = False
        Me.MaxBB.Image = Global.Xbox_Editor.My.Resources.Resources.StockIndexUp
        Me.MaxBB.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.MaxBB.Location = New System.Drawing.Point(113, 29)
        Me.MaxBB.Name = "MaxBB"
        Me.MaxBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.MaxBB.Size = New System.Drawing.Size(143, 20)
        Me.MaxBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MaxBB.TabIndex = 3
        Me.MaxBB.Text = "Max"
        '
        'ResultsII
        '
        '
        '
        '
        Me.ResultsII.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.ResultsII.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ResultsII.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.ResultsII.Enabled = False
        Me.ResultsII.Location = New System.Drawing.Point(2, 29)
        Me.ResultsII.Name = "ResultsII"
        Me.ResultsII.ShowUpDown = True
        Me.ResultsII.Size = New System.Drawing.Size(105, 20)
        Me.ResultsII.TabIndex = 2
        Me.ResultsII.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.ResultsII.WatermarkText = "SP Race Results"
        '
        'DrivingII
        '
        '
        '
        '
        Me.DrivingII.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DrivingII.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DrivingII.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DrivingII.Enabled = False
        Me.DrivingII.Location = New System.Drawing.Point(113, 3)
        Me.DrivingII.Name = "DrivingII"
        Me.DrivingII.ShowUpDown = True
        Me.DrivingII.Size = New System.Drawing.Size(142, 20)
        Me.DrivingII.TabIndex = 1
        Me.DrivingII.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.DrivingII.WatermarkText = "Driving Milestone"
        '
        'SpII
        '
        '
        '
        '
        Me.SpII.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.SpII.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SpII.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.SpII.Enabled = False
        Me.SpII.Location = New System.Drawing.Point(2, 3)
        Me.SpII.Name = "SpII"
        Me.SpII.ShowUpDown = True
        Me.SpII.Size = New System.Drawing.Size(105, 20)
        Me.SpII.TabIndex = 0
        Me.SpII.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.SpII.WatermarkText = "SP Points"
        '
        'NeedForSpeed2012
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 93)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.Bar1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NeedForSpeed2012"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NFS Most Wanted"
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        Me.GroupPanel1.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.ResultsII, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DrivingII, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpII, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents OpenAss As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Save As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ControlContainerItem2 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents MaxBB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ResultsII As DevComponents.Editors.IntegerInput
    Friend WithEvents DrivingII As DevComponents.Editors.IntegerInput
    Friend WithEvents SpII As DevComponents.Editors.IntegerInput
    Friend WithEvents ResignBB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ControlContainerItem3 As DevComponents.DotNetBar.ControlContainerItem
End Class
