<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoulCaliburV
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SoulCaliburV))
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.OpenAss = New DevComponents.DotNetBar.ButtonX()
        Me.Save = New DevComponents.DotNetBar.ButtonX()
        Me.ResignBB = New DevComponents.DotNetBar.ButtonX()
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem2 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.OfflineXP = New DevComponents.Editors.IntegerInput()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PLAYERLOSSES = New DevComponents.Editors.IntegerInput()
        Me.PLAYERWINS = New DevComponents.Editors.IntegerInput()
        Me.RINGOUTS = New DevComponents.Editors.IntegerInput()
        Me.MAXCOMBO = New DevComponents.Editors.IntegerInput()
        Me.SUCCESSFULIMPACT = New DevComponents.Editors.IntegerInput()
        Me.PLAYERDISTANCE = New DevComponents.Editors.IntegerInput()
        Me.CRITALEDGEHITS = New DevComponents.Editors.IntegerInput()
        Me.MaxBB = New DevComponents.DotNetBar.ButtonX()
        Me.ControlContainerItem3 = New DevComponents.DotNetBar.ControlContainerItem()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        CType(Me.OfflineXP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PLAYERLOSSES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLAYERWINS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RINGOUTS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MAXCOMBO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SUCCESSFULIMPACT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLAYERDISTANCE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CRITALEDGEHITS, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Bar1.Size = New System.Drawing.Size(262, 31)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 15
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
        Me.OpenAss.Size = New System.Drawing.Size(112, 26)
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
        Me.Save.Location = New System.Drawing.Point(119, 2)
        Me.Save.Name = "Save"
        Me.Save.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.Save.Size = New System.Drawing.Size(110, 26)
        Me.Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Save.TabIndex = 11
        Me.Save.Text = "Save"
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
        Me.ResignBB.TabIndex = 15
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
        'OfflineXP
        '
        '
        '
        '
        Me.OfflineXP.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.OfflineXP.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.OfflineXP.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.OfflineXP.Enabled = False
        Me.OfflineXP.Location = New System.Drawing.Point(3, 3)
        Me.OfflineXP.MinValue = 0
        Me.OfflineXP.Name = "OfflineXP"
        Me.OfflineXP.ShowUpDown = True
        Me.OfflineXP.Size = New System.Drawing.Size(109, 20)
        Me.OfflineXP.TabIndex = 16
        Me.OfflineXP.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.OfflineXP.WatermarkText = "Offline XP"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.MaxBB)
        Me.PanelEx1.Controls.Add(Me.PLAYERLOSSES)
        Me.PanelEx1.Controls.Add(Me.PLAYERWINS)
        Me.PanelEx1.Controls.Add(Me.RINGOUTS)
        Me.PanelEx1.Controls.Add(Me.MAXCOMBO)
        Me.PanelEx1.Controls.Add(Me.SUCCESSFULIMPACT)
        Me.PanelEx1.Controls.Add(Me.PLAYERDISTANCE)
        Me.PanelEx1.Controls.Add(Me.CRITALEDGEHITS)
        Me.PanelEx1.Controls.Add(Me.OfflineXP)
        Me.PanelEx1.Location = New System.Drawing.Point(3, 34)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(256, 140)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 17
        '
        'PLAYERLOSSES
        '
        '
        '
        '
        Me.PLAYERLOSSES.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.PLAYERLOSSES.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PLAYERLOSSES.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.PLAYERLOSSES.Enabled = False
        Me.PLAYERLOSSES.Location = New System.Drawing.Point(138, 55)
        Me.PLAYERLOSSES.MinValue = 0
        Me.PLAYERLOSSES.Name = "PLAYERLOSSES"
        Me.PLAYERLOSSES.ShowUpDown = True
        Me.PLAYERLOSSES.Size = New System.Drawing.Size(110, 20)
        Me.PLAYERLOSSES.TabIndex = 23
        Me.PLAYERLOSSES.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.PLAYERLOSSES.WatermarkText = "Player Losses"
        '
        'PLAYERWINS
        '
        '
        '
        '
        Me.PLAYERWINS.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.PLAYERWINS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PLAYERWINS.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.PLAYERWINS.Enabled = False
        Me.PLAYERWINS.Location = New System.Drawing.Point(138, 29)
        Me.PLAYERWINS.MinValue = 0
        Me.PLAYERWINS.Name = "PLAYERWINS"
        Me.PLAYERWINS.ShowUpDown = True
        Me.PLAYERWINS.Size = New System.Drawing.Size(110, 20)
        Me.PLAYERWINS.TabIndex = 22
        Me.PLAYERWINS.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.PLAYERWINS.WatermarkText = "Player Wins"
        '
        'RINGOUTS
        '
        '
        '
        '
        Me.RINGOUTS.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.RINGOUTS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RINGOUTS.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.RINGOUTS.Enabled = False
        Me.RINGOUTS.Location = New System.Drawing.Point(138, 3)
        Me.RINGOUTS.MinValue = 0
        Me.RINGOUTS.Name = "RINGOUTS"
        Me.RINGOUTS.ShowUpDown = True
        Me.RINGOUTS.Size = New System.Drawing.Size(110, 20)
        Me.RINGOUTS.TabIndex = 21
        Me.RINGOUTS.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.RINGOUTS.WatermarkText = "Ring Outs"
        '
        'MAXCOMBO
        '
        '
        '
        '
        Me.MAXCOMBO.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.MAXCOMBO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MAXCOMBO.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.MAXCOMBO.Enabled = False
        Me.MAXCOMBO.Location = New System.Drawing.Point(138, 81)
        Me.MAXCOMBO.MinValue = 0
        Me.MAXCOMBO.Name = "MAXCOMBO"
        Me.MAXCOMBO.ShowUpDown = True
        Me.MAXCOMBO.Size = New System.Drawing.Size(110, 20)
        Me.MAXCOMBO.TabIndex = 20
        Me.MAXCOMBO.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.MAXCOMBO.WatermarkText = "Max Combos"
        '
        'SUCCESSFULIMPACT
        '
        '
        '
        '
        Me.SUCCESSFULIMPACT.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.SUCCESSFULIMPACT.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SUCCESSFULIMPACT.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.SUCCESSFULIMPACT.Enabled = False
        Me.SUCCESSFULIMPACT.Location = New System.Drawing.Point(3, 81)
        Me.SUCCESSFULIMPACT.MinValue = 0
        Me.SUCCESSFULIMPACT.Name = "SUCCESSFULIMPACT"
        Me.SUCCESSFULIMPACT.ShowUpDown = True
        Me.SUCCESSFULIMPACT.Size = New System.Drawing.Size(109, 20)
        Me.SUCCESSFULIMPACT.TabIndex = 19
        Me.SUCCESSFULIMPACT.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.SUCCESSFULIMPACT.WatermarkText = "Successful Impact "
        '
        'PLAYERDISTANCE
        '
        '
        '
        '
        Me.PLAYERDISTANCE.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.PLAYERDISTANCE.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.PLAYERDISTANCE.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.PLAYERDISTANCE.Enabled = False
        Me.PLAYERDISTANCE.Location = New System.Drawing.Point(3, 55)
        Me.PLAYERDISTANCE.MinValue = 0
        Me.PLAYERDISTANCE.Name = "PLAYERDISTANCE"
        Me.PLAYERDISTANCE.ShowUpDown = True
        Me.PLAYERDISTANCE.Size = New System.Drawing.Size(109, 20)
        Me.PLAYERDISTANCE.TabIndex = 18
        Me.PLAYERDISTANCE.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.PLAYERDISTANCE.WatermarkText = "Player Distance"
        '
        'CRITALEDGEHITS
        '
        '
        '
        '
        Me.CRITALEDGEHITS.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.CRITALEDGEHITS.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.CRITALEDGEHITS.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.CRITALEDGEHITS.Enabled = False
        Me.CRITALEDGEHITS.Location = New System.Drawing.Point(3, 29)
        Me.CRITALEDGEHITS.MinValue = 0
        Me.CRITALEDGEHITS.Name = "CRITALEDGEHITS"
        Me.CRITALEDGEHITS.ShowUpDown = True
        Me.CRITALEDGEHITS.Size = New System.Drawing.Size(109, 20)
        Me.CRITALEDGEHITS.TabIndex = 17
        Me.CRITALEDGEHITS.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.CRITALEDGEHITS.WatermarkText = "Crital Edge Hits"
        '
        'MaxBB
        '
        Me.MaxBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.MaxBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.MaxBB.Enabled = False
        Me.MaxBB.Image = Global.Xbox_Editor.My.Resources.Resources.StockIndexUp
        Me.MaxBB.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.MaxBB.Location = New System.Drawing.Point(3, 107)
        Me.MaxBB.Name = "MaxBB"
        Me.MaxBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.MaxBB.Size = New System.Drawing.Size(245, 30)
        Me.MaxBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MaxBB.TabIndex = 24
        Me.MaxBB.Text = "Max"
        '
        'ControlContainerItem3
        '
        Me.ControlContainerItem3.AllowItemResize = False
        Me.ControlContainerItem3.Control = Me.ResignBB
        Me.ControlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem3.Name = "ControlContainerItem3"
        '
        'SoulCaliburV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 176)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.Bar1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SoulCaliburV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Soul Calibur V"
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        CType(Me.OfflineXP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.PLAYERLOSSES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLAYERWINS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RINGOUTS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MAXCOMBO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SUCCESSFULIMPACT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLAYERDISTANCE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CRITALEDGEHITS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents OpenAss As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Save As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ResignBB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ControlContainerItem2 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents OfflineXP As DevComponents.Editors.IntegerInput
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PLAYERLOSSES As DevComponents.Editors.IntegerInput
    Friend WithEvents PLAYERWINS As DevComponents.Editors.IntegerInput
    Friend WithEvents RINGOUTS As DevComponents.Editors.IntegerInput
    Friend WithEvents MAXCOMBO As DevComponents.Editors.IntegerInput
    Friend WithEvents SUCCESSFULIMPACT As DevComponents.Editors.IntegerInput
    Friend WithEvents PLAYERDISTANCE As DevComponents.Editors.IntegerInput
    Friend WithEvents CRITALEDGEHITS As DevComponents.Editors.IntegerInput
    Friend WithEvents ControlContainerItem3 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents MaxBB As DevComponents.DotNetBar.ButtonX
End Class
