<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Wet))
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.OpenAss = New DevComponents.DotNetBar.ButtonX()
        Me.Save = New DevComponents.DotNetBar.ButtonX()
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem2 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem3 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ResignBB = New DevComponents.DotNetBar.ButtonX()
        Me.SkillPointsII = New DevComponents.Editors.IntegerInput()
        Me.ShotGunII = New DevComponents.Editors.IntegerInput()
        Me.MachineGunII = New DevComponents.Editors.IntegerInput()
        Me.DartBowII = New DevComponents.Editors.IntegerInput()
        Me.MaxBB = New DevComponents.DotNetBar.ButtonX()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        CType(Me.SkillPointsII, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShotGunII, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MachineGunII, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DartBowII, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bar1
        '
        Me.Bar1.AntiAlias = True
        Me.Bar1.Controls.Add(Me.OpenAss)
        Me.Bar1.Controls.Add(Me.Save)
        Me.Bar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Bar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ControlContainerItem1, Me.ControlContainerItem2, Me.ControlContainerItem3})
        Me.Bar1.Location = New System.Drawing.Point(0, 0)
        Me.Bar1.Name = "Bar1"
        Me.Bar1.Size = New System.Drawing.Size(296, 31)
        Me.Bar1.Stretch = True
        Me.Bar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Bar1.TabIndex = 12
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
        Me.OpenAss.Size = New System.Drawing.Size(141, 26)
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
        Me.Save.Location = New System.Drawing.Point(148, 2)
        Me.Save.Name = "Save"
        Me.Save.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.Save.Size = New System.Drawing.Size(112, 26)
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
        Me.ControlContainerItem2.Enabled = False
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
        'ResignBB
        '
        Me.ResignBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ResignBB.BackColor = System.Drawing.Color.Transparent
        Me.ResignBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ResignBB.Enabled = False
        Me.ResignBB.Image = Global.Xbox_Editor.My.Resources.Resources.Tools_Icon
        Me.ResignBB.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.ResignBB.Location = New System.Drawing.Point(264, 2)
        Me.ResignBB.Name = "ResignBB"
        Me.ResignBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ResignBB.Size = New System.Drawing.Size(26, 26)
        Me.ResignBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ResignBB.TabIndex = 17
        '
        'SkillPointsII
        '
        '
        '
        '
        Me.SkillPointsII.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.SkillPointsII.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.SkillPointsII.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.SkillPointsII.Enabled = False
        Me.SkillPointsII.Location = New System.Drawing.Point(3, 34)
        Me.SkillPointsII.MaxValue = 9999999
        Me.SkillPointsII.MinValue = 0
        Me.SkillPointsII.Name = "SkillPointsII"
        Me.SkillPointsII.ShowUpDown = True
        Me.SkillPointsII.Size = New System.Drawing.Size(95, 20)
        Me.SkillPointsII.TabIndex = 13
        Me.SkillPointsII.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.SkillPointsII.WatermarkText = "Skill Points"
        '
        'ShotGunII
        '
        '
        '
        '
        Me.ShotGunII.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.ShotGunII.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ShotGunII.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.ShotGunII.Enabled = False
        Me.ShotGunII.Location = New System.Drawing.Point(3, 60)
        Me.ShotGunII.MaxValue = 9999999
        Me.ShotGunII.MinValue = 0
        Me.ShotGunII.Name = "ShotGunII"
        Me.ShotGunII.ShowUpDown = True
        Me.ShotGunII.Size = New System.Drawing.Size(95, 20)
        Me.ShotGunII.TabIndex = 14
        Me.ShotGunII.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.ShotGunII.WatermarkText = "Shot Gun"
        '
        'MachineGunII
        '
        '
        '
        '
        Me.MachineGunII.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.MachineGunII.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MachineGunII.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.MachineGunII.Enabled = False
        Me.MachineGunII.Location = New System.Drawing.Point(104, 60)
        Me.MachineGunII.MaxValue = 9999999
        Me.MachineGunII.MinValue = 0
        Me.MachineGunII.Name = "MachineGunII"
        Me.MachineGunII.ShowUpDown = True
        Me.MachineGunII.Size = New System.Drawing.Size(114, 20)
        Me.MachineGunII.TabIndex = 15
        Me.MachineGunII.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.MachineGunII.WatermarkText = "Machine Gun"
        '
        'DartBowII
        '
        '
        '
        '
        Me.DartBowII.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.DartBowII.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DartBowII.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.DartBowII.Enabled = False
        Me.DartBowII.Location = New System.Drawing.Point(104, 34)
        Me.DartBowII.MaxValue = 9999999
        Me.DartBowII.MinValue = 0
        Me.DartBowII.Name = "DartBowII"
        Me.DartBowII.ShowUpDown = True
        Me.DartBowII.Size = New System.Drawing.Size(114, 20)
        Me.DartBowII.TabIndex = 16
        Me.DartBowII.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.DartBowII.WatermarkText = "Dart Bow"
        '
        'MaxBB
        '
        Me.MaxBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.MaxBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.MaxBB.Enabled = False
        Me.MaxBB.Image = Global.Xbox_Editor.My.Resources.Resources.StockIndexUp
        Me.MaxBB.ImageFixedSize = New System.Drawing.Size(20, 20)
        Me.MaxBB.Location = New System.Drawing.Point(221, 34)
        Me.MaxBB.Name = "MaxBB"
        Me.MaxBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.MaxBB.Size = New System.Drawing.Size(75, 46)
        Me.MaxBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.MaxBB.TabIndex = 18
        Me.MaxBB.Text = "Max All"
        '
        'Wet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 81)
        Me.Controls.Add(Me.MaxBB)
        Me.Controls.Add(Me.ResignBB)
        Me.Controls.Add(Me.DartBowII)
        Me.Controls.Add(Me.MachineGunII)
        Me.Controls.Add(Me.ShotGunII)
        Me.Controls.Add(Me.SkillPointsII)
        Me.Controls.Add(Me.Bar1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Wet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Wet"
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        CType(Me.SkillPointsII, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShotGunII, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MachineGunII, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DartBowII, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents OpenAss As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Save As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ControlContainerItem2 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents SkillPointsII As DevComponents.Editors.IntegerInput
    Friend WithEvents ShotGunII As DevComponents.Editors.IntegerInput
    Friend WithEvents MachineGunII As DevComponents.Editors.IntegerInput
    Friend WithEvents DartBowII As DevComponents.Editors.IntegerInput
    Friend WithEvents ControlContainerItem3 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ResignBB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MaxBB As DevComponents.DotNetBar.ButtonX
End Class
