<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XDBFExplorer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XDBFExplorer))
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.RibbonPanel2 = New DevComponents.DotNetBar.RibbonPanel()
        Me.gpHeader = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.RibbonPanel1 = New DevComponents.DotNetBar.RibbonPanel()
        Me.listTableEntries = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.clmNamespace = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmEntryID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmOffsetSpec = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.clmLength = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnOpen = New DevComponents.DotNetBar.Office2007StartButton()
        Me.btnSave = New DevComponents.DotNetBar.Office2007StartButton()
        Me.tiHeader = New DevComponents.DotNetBar.RibbonTabItem()
        Me.tiEntries = New DevComponents.DotNetBar.RibbonTabItem()
        Me.btnFix = New DevComponents.DotNetBar.ButtonItem()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.RibbonControl1.SuspendLayout()
        Me.RibbonPanel2.SuspendLayout()
        Me.RibbonPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        '
        '
        '
        Me.RibbonControl1.BackgroundStyle.Class = ""
        Me.RibbonControl1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.RibbonControl1.CaptionVisible = True
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel1)
        Me.RibbonControl1.Controls.Add(Me.RibbonPanel2)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonControl1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnOpen, Me.btnSave, Me.tiHeader, Me.tiEntries, Me.btnFix})
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Location = New System.Drawing.Point(5, 1)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.RibbonControl1.Size = New System.Drawing.Size(510, 447)
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
        Me.RibbonControl1.TabIndex = 0
        Me.RibbonControl1.Text = "RibbonControl1"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel2.Controls.Add(Me.gpHeader)
        Me.RibbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel2.Location = New System.Drawing.Point(0, 53)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel2.Size = New System.Drawing.Size(510, 392)
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
        'gpHeader
        '
        Me.gpHeader.CanvasColor = System.Drawing.SystemColors.Control
        Me.gpHeader.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.gpHeader.Location = New System.Drawing.Point(12, 3)
        Me.gpHeader.Name = "gpHeader"
        Me.gpHeader.Size = New System.Drawing.Size(486, 173)
        '
        '
        '
        Me.gpHeader.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.gpHeader.Style.BackColorGradientAngle = 90
        Me.gpHeader.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.gpHeader.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpHeader.Style.BorderBottomWidth = 1
        Me.gpHeader.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.gpHeader.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpHeader.Style.BorderLeftWidth = 1
        Me.gpHeader.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpHeader.Style.BorderRightWidth = 1
        Me.gpHeader.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.gpHeader.Style.BorderTopWidth = 1
        Me.gpHeader.Style.Class = ""
        Me.gpHeader.Style.CornerDiameter = 4
        Me.gpHeader.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.gpHeader.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.gpHeader.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.gpHeader.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.gpHeader.StyleMouseDown.Class = ""
        Me.gpHeader.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.gpHeader.StyleMouseOver.Class = ""
        Me.gpHeader.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.gpHeader.TabIndex = 0
        Me.gpHeader.Text = "Header Data"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonPanel1.Controls.Add(Me.listTableEntries)
        Me.RibbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonPanel1.Location = New System.Drawing.Point(0, 53)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Padding = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.RibbonPanel1.Size = New System.Drawing.Size(510, 392)
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
        'listTableEntries
        '
        '
        '
        '
        Me.listTableEntries.Border.Class = "ListViewBorder"
        Me.listTableEntries.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.listTableEntries.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clmNamespace, Me.clmEntryID, Me.clmOffsetSpec, Me.clmLength})
        Me.listTableEntries.Location = New System.Drawing.Point(6, 3)
        Me.listTableEntries.Name = "listTableEntries"
        Me.listTableEntries.Size = New System.Drawing.Size(498, 355)
        Me.listTableEntries.TabIndex = 0
        Me.listTableEntries.UseCompatibleStateImageBehavior = False
        Me.listTableEntries.View = System.Windows.Forms.View.Details
        '
        'clmNamespace
        '
        Me.clmNamespace.Text = "Namespace"
        Me.clmNamespace.Width = 139
        '
        'clmEntryID
        '
        Me.clmEntryID.Text = "ID"
        Me.clmEntryID.Width = 87
        '
        'clmOffsetSpec
        '
        Me.clmOffsetSpec.Text = "Offset Specifier"
        Me.clmOffsetSpec.Width = 162
        '
        'clmLength
        '
        Me.clmLength.Text = "Length"
        Me.clmLength.Width = 140
        '
        'btnOpen
        '
        Me.btnOpen.AutoExpandOnClick = True
        Me.btnOpen.CanCustomize = False
        Me.btnOpen.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnOpen.ImagePaddingHorizontal = 0
        Me.btnOpen.ImagePaddingVertical = 0
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.ShowSubItems = False
        Me.btnOpen.Text = "Open"
        '
        'btnSave
        '
        Me.btnSave.AutoExpandOnClick = True
        Me.btnSave.CanCustomize = False
        Me.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground
        Me.btnSave.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.btnSave.ImagePaddingHorizontal = 0
        Me.btnSave.ImagePaddingVertical = 0
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShowSubItems = False
        Me.btnSave.Text = "Save"
        '
        'tiHeader
        '
        Me.tiHeader.Name = "tiHeader"
        Me.tiHeader.Panel = Me.RibbonPanel2
        Me.tiHeader.Text = "Header Data/Free Space Data"
        '
        'tiEntries
        '
        Me.tiEntries.Checked = True
        Me.tiEntries.Name = "tiEntries"
        Me.tiEntries.Panel = Me.RibbonPanel1
        Me.tiEntries.Text = "Entry Table"
        '
        'btnFix
        '
        Me.btnFix.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnFix.Image = Global.Xbox_Editor.My.Resources.Resources._1359894338_tool
        Me.btnFix.Name = "btnFix"
        Me.btnFix.Text = "Allocate/Fix"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerColorTint = System.Drawing.Color.LightGray
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Silver
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
        '
        'XDBFExplorer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 450)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "XDBFExplorer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XDBF Explorer"
        Me.RibbonControl1.ResumeLayout(False)
        Me.RibbonControl1.PerformLayout()
        Me.RibbonPanel2.ResumeLayout(False)
        Me.RibbonPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents RibbonPanel1 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents btnOpen As DevComponents.DotNetBar.Office2007StartButton
    Friend WithEvents tiEntries As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents btnSave As DevComponents.DotNetBar.Office2007StartButton
    Friend WithEvents btnFix As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents listTableEntries As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents RibbonPanel2 As DevComponents.DotNetBar.RibbonPanel
    Friend WithEvents gpHeader As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents tiHeader As DevComponents.DotNetBar.RibbonTabItem
    Friend WithEvents clmNamespace As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmEntryID As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmOffsetSpec As System.Windows.Forms.ColumnHeader
    Friend WithEvents clmLength As System.Windows.Forms.ColumnHeader
End Class
