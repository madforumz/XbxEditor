<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TigerWoods11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TigerWoods11))
        Me.Max = New DevComponents.DotNetBar.ButtonX()
        Me.Points = New DevComponents.Editors.IntegerInput()
        Me.Save = New DevComponents.DotNetBar.ButtonX()
        Me.OpenAss = New DevComponents.DotNetBar.ButtonX()
        Me.open = New System.Windows.Forms.OpenFileDialog()
        Me.Bar1 = New DevComponents.DotNetBar.Bar()
        Me.ControlContainerItem1 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ControlContainerItem2 = New DevComponents.DotNetBar.ControlContainerItem()
        Me.ResignBB = New DevComponents.DotNetBar.ButtonX()
        Me.ControlContainerItem3 = New DevComponents.DotNetBar.ControlContainerItem()
        CType(Me.Points, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bar1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Max
        '
        Me.Max.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Max.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Max.Enabled = False
        Me.Max.Image = Global.Xbox_Editor.My.Resources.Resources.StockIndexUp
        Me.Max.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.Max.Location = New System.Drawing.Point(127, 33)
        Me.Max.Name = "Max"
        Me.Max.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.Max.Size = New System.Drawing.Size(142, 20)
        Me.Max.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Max.TabIndex = 21
        Me.Max.Text = "Max Points"
        '
        'Points
        '
        '
        '
        '
        Me.Points.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.Points.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.Points.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2
        Me.Points.Enabled = False
        Me.Points.Location = New System.Drawing.Point(3, 33)
        Me.Points.MinValue = 0
        Me.Points.Name = "Points"
        Me.Points.ShowUpDown = True
        Me.Points.Size = New System.Drawing.Size(120, 20)
        Me.Points.TabIndex = 20
        Me.Points.WatermarkAlignment = DevComponents.Editors.eTextAlignment.Center
        Me.Points.WatermarkText = "Money/XP Points"
        '
        'Save
        '
        Me.Save.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Save.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Save.Enabled = False
        Me.Save.Image = CType(resources.GetObject("Save.Image"), System.Drawing.Image)
        Me.Save.ImageFixedSize = New System.Drawing.Size(18, 18)
        Me.Save.Location = New System.Drawing.Point(127, 3)
        Me.Save.Name = "Save"
        Me.Save.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.Save.Size = New System.Drawing.Size(112, 25)
        Me.Save.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Save.TabIndex = 19
        Me.Save.Text = "Save"
        '
        'OpenAss
        '
        Me.OpenAss.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.OpenAss.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.OpenAss.Image = CType(resources.GetObject("OpenAss.Image"), System.Drawing.Image)
        Me.OpenAss.Location = New System.Drawing.Point(3, 3)
        Me.OpenAss.Name = "OpenAss"
        Me.OpenAss.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.OpenAss.Size = New System.Drawing.Size(120, 25)
        Me.OpenAss.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.OpenAss.TabIndex = 18
        Me.OpenAss.Text = "Open"
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
        Me.Bar1.TabIndex = 22
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
        'ResignBB
        '
        Me.ResignBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ResignBB.BackColor = System.Drawing.Color.Transparent
        Me.ResignBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ResignBB.Enabled = False
        Me.ResignBB.Image = Global.Xbox_Editor.My.Resources.Resources.Tools_Icon
        Me.ResignBB.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.ResignBB.Location = New System.Drawing.Point(243, 2)
        Me.ResignBB.Name = "ResignBB"
        Me.ResignBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.ResignBB.Size = New System.Drawing.Size(26, 26)
        Me.ResignBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ResignBB.TabIndex = 20
        '
        'ControlContainerItem3
        '
        Me.ControlContainerItem3.AllowItemResize = False
        Me.ControlContainerItem3.Control = Me.ResignBB
        Me.ControlContainerItem3.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways
        Me.ControlContainerItem3.Name = "ControlContainerItem3"
        '
        'TigerWoods11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 55)
        Me.Controls.Add(Me.Bar1)
        Me.Controls.Add(Me.Max)
        Me.Controls.Add(Me.Points)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "TigerWoods11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tiger Woods PGATour 11"
        CType(Me.Points, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bar1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Max As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Points As DevComponents.Editors.IntegerInput
    Friend WithEvents Save As DevComponents.DotNetBar.ButtonX
    Friend WithEvents OpenAss As DevComponents.DotNetBar.ButtonX
    Friend WithEvents open As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Bar1 As DevComponents.DotNetBar.Bar
    Friend WithEvents ControlContainerItem1 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ControlContainerItem2 As DevComponents.DotNetBar.ControlContainerItem
    Friend WithEvents ResignBB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ControlContainerItem3 As DevComponents.DotNetBar.ControlContainerItem
End Class
