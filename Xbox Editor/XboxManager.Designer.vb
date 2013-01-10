<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XboxManager
    Inherits DevComponents.DotNetBar.Office2007RibbonForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XboxManager))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ProfileID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DeviceID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.TitleName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DisplayName = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ConsoleID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenBB = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.TitleID = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.PackageImage = New System.Windows.Forms.PictureBox()
        Me.ExtractImages1CM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InjectImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentImage = New System.Windows.Forms.PictureBox()
        Me.ExtractImages2CM = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RibbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
        Me.PanelEx4 = New DevComponents.DotNetBar.PanelEx()
        Me.ProgressBarX1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.BackBB = New DevComponents.DotNetBar.ButtonX()
        Me.Forward = New DevComponents.DotNetBar.ButtonX()
        Me.TextBoxX2 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.ListViewEx1 = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.RibbonPanel3 = New DevComponents.DotNetBar.RibbonPanel()
        Me.RehashBB = New DevComponents.DotNetBar.ButtonItem()
        Me.InfoRT = New DevComponents.DotNetBar.RibbonTabItem()
        Me.FileContentsRT = New DevComponents.DotNetBar.RibbonTabItem()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx5.SuspendLayout()
        Me.PanelEx2.SuspendLayout()
        CType(Me.PackageImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExtractImages1CM.SuspendLayout()
        CType(Me.ContentImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExtractImages2CM.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.RibbonControl1.SuspendLayout()
        Me.RibbonPanel1.SuspendLayout()
        Me.RibbonPanel2.SuspendLayout()
        Me.PanelEx4.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Label4)
        Me.PanelEx1.Controls.Add(Me.ProfileID)
        Me.PanelEx1.Controls.Add(Me.Label3)
        Me.PanelEx1.Controls.Add(Me.Label5)
        Me.PanelEx1.Controls.Add(Me.DeviceID)
        Me.PanelEx1.Controls.Add(Me.TitleName)
        Me.PanelEx1.Controls.Add(Me.Label2)
        Me.PanelEx1.Controls.Add(Me.DisplayName)
        Me.PanelEx1.Controls.Add(Me.ConsoleID)
        Me.PanelEx1.Controls.Add(Me.Label1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelEx1.Location = New System.Drawing.Point(151, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(308, 150)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(6, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Profile ID :"
        '
        'ProfileID
        '
        Me.ProfileID.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.ProfileID.Border.Class = "TextBoxBorder"
        Me.ProfileID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProfileID.Enabled = False
        Me.ProfileID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ProfileID.Location = New System.Drawing.Point(90, 114)
        Me.ProfileID.Name = "ProfileID"
        Me.ProfileID.Size = New System.Drawing.Size(206, 20)
        Me.ProfileID.TabIndex = 14
        Me.ProfileID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(6, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Device ID :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(7, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Title Name :"
        '
        'DeviceID
        '
        Me.DeviceID.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.DeviceID.Border.Class = "TextBoxBorder"
        Me.DeviceID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DeviceID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DeviceID.Location = New System.Drawing.Point(90, 11)
        Me.DeviceID.MaxLength = 25
        Me.DeviceID.Name = "DeviceID"
        Me.DeviceID.Size = New System.Drawing.Size(206, 20)
        Me.DeviceID.TabIndex = 21
        Me.DeviceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TitleName
        '
        Me.TitleName.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TitleName.Border.Class = "TextBoxBorder"
        Me.TitleName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TitleName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TitleName.Location = New System.Drawing.Point(90, 63)
        Me.TitleName.MaxLength = 99
        Me.TitleName.Name = "TitleName"
        Me.TitleName.Size = New System.Drawing.Size(206, 20)
        Me.TitleName.TabIndex = 27
        Me.TitleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Display Name :"
        '
        'DisplayName
        '
        Me.DisplayName.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.DisplayName.Border.Class = "TextBoxBorder"
        Me.DisplayName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.DisplayName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.DisplayName.Location = New System.Drawing.Point(90, 37)
        Me.DisplayName.MaxLength = 99
        Me.DisplayName.Name = "DisplayName"
        Me.DisplayName.Size = New System.Drawing.Size(206, 20)
        Me.DisplayName.TabIndex = 22
        Me.DisplayName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ConsoleID
        '
        Me.ConsoleID.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.ConsoleID.Border.Class = "TextBoxBorder"
        Me.ConsoleID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ConsoleID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ConsoleID.Location = New System.Drawing.Point(90, 88)
        Me.ConsoleID.MaxLength = 10
        Me.ConsoleID.Name = "ConsoleID"
        Me.ConsoleID.Size = New System.Drawing.Size(206, 20)
        Me.ConsoleID.TabIndex = 25
        Me.ConsoleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(6, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Console ID :"
        '
        'OpenBB
        '
        Me.OpenBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.OpenBB.BackColor = System.Drawing.Color.Transparent
        Me.OpenBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.OpenBB.Location = New System.Drawing.Point(3, 33)
        Me.OpenBB.Name = "OpenBB"
        Me.OpenBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.OpenBB.Size = New System.Drawing.Size(133, 24)
        Me.OpenBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.OpenBB.TabIndex = 30
        Me.OpenBB.Text = "Open/Load"
        Me.OpenBB.Tooltip = "Open A File"
        '
        'PanelEx5
        '
        Me.PanelEx5.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx5.Controls.Add(Me.TitleID)
        Me.PanelEx5.Controls.Add(Me.Label6)
        Me.PanelEx5.Controls.Add(Me.OpenBB)
        Me.PanelEx5.Location = New System.Drawing.Point(3, 77)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(139, 61)
        Me.PanelEx5.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 12
        '
        'TitleID
        '
        Me.TitleID.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TitleID.Border.Class = "TextBoxBorder"
        Me.TitleID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TitleID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TitleID.Location = New System.Drawing.Point(53, 5)
        Me.TitleID.Name = "TitleID"
        Me.TitleID.Size = New System.Drawing.Size(83, 20)
        Me.TitleID.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(3, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Title ID :"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.PackageImage)
        Me.PanelEx2.Controls.Add(Me.ContentImage)
        Me.PanelEx2.Location = New System.Drawing.Point(3, 3)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(139, 70)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 13
        '
        'PackageImage
        '
        Me.PackageImage.BackgroundImage = CType(resources.GetObject("PackageImage.BackgroundImage"), System.Drawing.Image)
        Me.PackageImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PackageImage.ContextMenuStrip = Me.ExtractImages1CM
        Me.PackageImage.ErrorImage = CType(resources.GetObject("PackageImage.ErrorImage"), System.Drawing.Image)
        Me.PackageImage.Location = New System.Drawing.Point(3, 3)
        Me.PackageImage.Name = "PackageImage"
        Me.PackageImage.Size = New System.Drawing.Size(64, 64)
        Me.PackageImage.TabIndex = 4
        Me.PackageImage.TabStop = False
        '
        'ExtractImages1CM
        '
        Me.ExtractImages1CM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EToolStripMenuItem, Me.InjectImageToolStripMenuItem})
        Me.ExtractImages1CM.Name = "ExtractImages1CM"
        Me.ExtractImages1CM.Size = New System.Drawing.Size(146, 48)
        '
        'EToolStripMenuItem
        '
        Me.EToolStripMenuItem.Image = Global.Xbox_Editor.My.Resources.Resources.StockIndexUp
        Me.EToolStripMenuItem.Name = "EToolStripMenuItem"
        Me.EToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EToolStripMenuItem.Text = "Extract Image"
        Me.EToolStripMenuItem.ToolTipText = "Save Your Gamesave/Profile Image"
        '
        'InjectImageToolStripMenuItem
        '
        Me.InjectImageToolStripMenuItem.Image = Global.Xbox_Editor.My.Resources.Resources.back_icon1
        Me.InjectImageToolStripMenuItem.Name = "InjectImageToolStripMenuItem"
        Me.InjectImageToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.InjectImageToolStripMenuItem.Text = "Inject Image"
        '
        'ContentImage
        '
        Me.ContentImage.BackgroundImage = Global.Xbox_Editor.My.Resources.Resources.IDontKnow
        Me.ContentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ContentImage.ContextMenuStrip = Me.ExtractImages2CM
        Me.ContentImage.ErrorImage = CType(resources.GetObject("ContentImage.ErrorImage"), System.Drawing.Image)
        Me.ContentImage.Location = New System.Drawing.Point(73, 3)
        Me.ContentImage.Name = "ContentImage"
        Me.ContentImage.Size = New System.Drawing.Size(64, 64)
        Me.ContentImage.TabIndex = 10
        Me.ContentImage.TabStop = False
        '
        'ExtractImages2CM
        '
        Me.ExtractImages2CM.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.ExtractImages2CM.Name = "ExtractImages1CM"
        Me.ExtractImages2CM.Size = New System.Drawing.Size(146, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.Xbox_Editor.My.Resources.Resources.StockIndexUp
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(145, 22)
        Me.ToolStripMenuItem1.Text = "Extract Image"
        Me.ToolStripMenuItem1.ToolTipText = "Save Your Gamesave/Profile Image"
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.PanelEx2)
        Me.PanelEx3.Controls.Add(Me.PanelEx5)
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelEx3.Location = New System.Drawing.Point(3, 0)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(145, 150)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 15
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "XboxImage"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.BackColor = System.Drawing.Color.Silver
        '
        '
        '
        Me.RibbonControl1.BackgroundStyle.Class = ""
        Me.RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonControl1.CaptionVisible = True
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel1)
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel2)
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel3)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonControl1.ForeColor = System.Drawing.Color.Black
        Me.RibbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.RehashBB, Me.InfoRT, Me.FileContentsRT})
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(5, 1)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.RibbonControl1.Size = New System.Drawing.Size(462, 208)
        Me.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonControl1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
        Me.RibbonControl1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
        Me.RibbonControl1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
        Me.RibbonControl1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
        Me.RibbonControl1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
        Me.RibbonControl1.SystemText.QatDialogAddButton = "&Add >>"
        Me.RibbonControl1.SystemText.QatDialogCancelButton = "Cancel"
        Me.RibbonControl1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
        Me.RibbonControl1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
        Me.RibbonControl1.SystemText.QatDialogOkButton = "OK"
        Me.RibbonControl1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl1.SystemText.QatDialogRemoveButton = "&Remove"
        Me.RibbonControl1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
        Me.RibbonControl1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
        Me.RibbonControl1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
        Me.RibbonControl1.TabGroupHeight = 14
        Me.RibbonControl1.TabIndex = 17
        Me.RibbonControl1.Text = "Xbox Manager"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel1.Controls.Add(Me.PanelEx3)
        Me.RibbonPanel1.Controls.Add(Me.PanelEx1)
        Me.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel1.Location = New System.Drawing.Point(0, 53)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel1.Size = New System.Drawing.Size(462, 153)
        '
        '
        '
        Me.RibbonPanel1.Style.Class = ""
        Me.RibbonPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseDown.Class = ""
        Me.RibbonPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel1.StyleMouseOver.Class = ""
        Me.RibbonPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel1.TabIndex = 1
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel2.Controls.Add(Me.PanelEx4)
        Me.RibbonPanel2.Controls.Add(Me.TextBoxX2)
        Me.RibbonPanel2.Controls.Add(Me.ListViewEx1)
        Me.RibbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel2.Location = New System.Drawing.Point(0, 53)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel2.Size = New System.Drawing.Size(462, 147)
        '
        '
        '
        Me.RibbonPanel2.Style.Class = ""
        Me.RibbonPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseDown.Class = ""
        Me.RibbonPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel2.StyleMouseOver.Class = ""
        Me.RibbonPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel2.TabIndex = 2
        Me.RibbonPanel2.Visible = False
        '
        'PanelEx4
        '
        Me.PanelEx4.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx4.Controls.Add(Me.ProgressBarX1)
        Me.PanelEx4.Controls.Add(Me.BackBB)
        Me.PanelEx4.Controls.Add(Me.Forward)
        Me.PanelEx4.Location = New System.Drawing.Point(3, 27)
        Me.PanelEx4.Name = "PanelEx4"
        Me.PanelEx4.Size = New System.Drawing.Size(113, 30)
        Me.PanelEx4.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx4.Style.GradientAngle = 90
        Me.PanelEx4.TabIndex = 6
        '
        'ProgressBarX1
        '
        '
        '
        '
        Me.ProgressBarX1.BackgroundStyle.Class = ""
        Me.ProgressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX1.Location = New System.Drawing.Point(31, 10)
        Me.ProgressBarX1.Name = "ProgressBarX1"
        Me.ProgressBarX1.Size = New System.Drawing.Size(48, 11)
        Me.ProgressBarX1.TabIndex = 6
        Me.ProgressBarX1.Text = "ProgressBarX1"
        '
        'BackBB
        '
        Me.BackBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BackBB.BackColor = System.Drawing.Color.Transparent
        Me.BackBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.BackBB.Image = CType(resources.GetObject("BackBB.Image"), System.Drawing.Image)
        Me.BackBB.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.BackBB.Location = New System.Drawing.Point(3, 3)
        Me.BackBB.Name = "BackBB"
        Me.BackBB.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.BackBB.Size = New System.Drawing.Size(25, 23)
        Me.BackBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.BackBB.TabIndex = 4
        '
        'Forward
        '
        Me.Forward.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Forward.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Forward.Image = CType(resources.GetObject("Forward.Image"), System.Drawing.Image)
        Me.Forward.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.Forward.Location = New System.Drawing.Point(85, 3)
        Me.Forward.Name = "Forward"
        Me.Forward.Shape = New DevComponents.DotNetBar.EllipticalShapeDescriptor()
        Me.Forward.Size = New System.Drawing.Size(25, 23)
        Me.Forward.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Forward.TabIndex = 5
        '
        'TextBoxX2
        '
        Me.TextBoxX2.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.TextBoxX2.Border.Class = "TextBoxBorder"
        Me.TextBoxX2.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TextBoxX2.Location = New System.Drawing.Point(3, 3)
        Me.TextBoxX2.Name = "TextBoxX2"
        Me.TextBoxX2.Size = New System.Drawing.Size(113, 20)
        Me.TextBoxX2.TabIndex = 3
        Me.TextBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBoxX2.WatermarkText = "Search"
        '
        'ListViewEx1
        '
        Me.ListViewEx1.BackColor = System.Drawing.Color.Silver
        '
        '
        '
        Me.ListViewEx1.Border.Class = "ListViewBorder"
        Me.ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ListViewEx1.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListViewEx1.ForeColor = System.Drawing.Color.Black
        Me.ListViewEx1.FullRowSelect = True
        Me.ListViewEx1.GridLines = True
        Me.ListViewEx1.Location = New System.Drawing.Point(117, 0)
        Me.ListViewEx1.Name = "ListViewEx1"
        Me.ListViewEx1.Size = New System.Drawing.Size(342, 144)
        Me.ListViewEx1.TabIndex = 0
        Me.ListViewEx1.UseCompatibleStateImageBehavior = False
        Me.ListViewEx1.View = System.Windows.Forms.View.Details
        Me.ListViewEx1.VirtualMode = True
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel3.Location = New System.Drawing.Point(0, 0)
        Me.RibbonPanel3.Name = "RibbonPanel3"
        Me.RibbonPanel3.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel3.Size = New System.Drawing.Size(462, 206)
        '
        '
        '
        Me.RibbonPanel3.Style.Class = ""
        Me.RibbonPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseDown.Class = ""
        Me.RibbonPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.RibbonPanel3.StyleMouseOver.Class = ""
        Me.RibbonPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonPanel3.TabIndex = 3
        '
        'RehashBB
        '
        Me.RehashBB.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.RehashBB.Image = Global.Xbox_Editor.My.Resources.Resources.floppy_disk
        Me.RehashBB.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.RehashBB.Name = "RehashBB"
        Me.RehashBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.RehashBB.Text = "Save And Rehash And Resign"
        '
        'InfoRT
        '
        Me.InfoRT.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.InfoRT.Checked = True
        Me.InfoRT.Image = CType(resources.GetObject("InfoRT.Image"), System.Drawing.Image)
        Me.InfoRT.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.InfoRT.Name = "InfoRT"
        Me.InfoRT.Panel = Me.RibbonPanel1
        Me.InfoRT.Text = "Your Info"
        '
        'FileContentsRT
        '
        Me.FileContentsRT.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.FileContentsRT.Image = CType(resources.GetObject("FileContentsRT.Image"), System.Drawing.Image)
        Me.FileContentsRT.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.FileContentsRT.Name = "FileContentsRT"
        Me.FileContentsRT.Panel = Me.RibbonPanel2
        Me.FileContentsRT.Text = "Profile / Gamesave Contents"
        '
        'XboxManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 211)
        Me.Controls.Add(Me.RibbonControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(472, 211)
        Me.Name = "XboxManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xbox Manager"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx1.PerformLayout()
        Me.PanelEx5.ResumeLayout(False)
        Me.PanelEx5.PerformLayout()
        Me.PanelEx2.ResumeLayout(False)
        CType(Me.PackageImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExtractImages1CM.ResumeLayout(False)
        CType(Me.ContentImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExtractImages2CM.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.RibbonControl1.ResumeLayout(False)
        Me.RibbonControl1.PerformLayout()
        Me.RibbonPanel1.ResumeLayout(False)
        Me.RibbonPanel2.ResumeLayout(False)
        Me.PanelEx4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DeviceID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents TitleName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DisplayName As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents ConsoleID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ContentImage As System.Windows.Forms.PictureBox
    Friend WithEvents PackageImage As System.Windows.Forms.PictureBox
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProfileID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents OpenBB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel2 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents RibbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents InfoRT As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents FileContentsRT As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents ExtractImages1CM As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtractImages2CM As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TitleID As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ListViewEx1 As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents TextBoxX2 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Forward As DevComponents.DotNetBar.ButtonX
    Friend WithEvents BackBB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents RehashBB As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents InjectImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelEx4 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents ProgressBarX1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents RibbonPanel3 As DevComponents.DotNetBar.RibbonPanel
End Class
