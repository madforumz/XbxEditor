<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameFinder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameFinder))
        Me.ListViewEx1 = New DevComponents.DotNetBar.Controls.ListViewEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.SearchBB = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GameName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TitleID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListViewEx1
        '
        '
        '
        '
        Me.ListViewEx1.Border.Class = "ListViewBorder"
        Me.ListViewEx1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ListViewEx1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.GameName, Me.TitleID})
        Me.ListViewEx1.Location = New System.Drawing.Point(126, 38)
        Me.ListViewEx1.Name = "ListViewEx1"
        Me.ListViewEx1.Size = New System.Drawing.Size(338, 168)
        Me.ListViewEx1.TabIndex = 1
        Me.ListViewEx1.UseCompatibleStateImageBehavior = False
        Me.ListViewEx1.View = System.Windows.Forms.View.Details
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(3, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 168)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Location = New System.Drawing.Point(126, 13)
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(212, 20)
        Me.TextBoxX1.TabIndex = 2
        '
        'SearchBB
        '
        Me.SearchBB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.SearchBB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.SearchBB.Location = New System.Drawing.Point(344, 12)
        Me.SearchBB.Name = "SearchBB"
        Me.SearchBB.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.SearchBB.Size = New System.Drawing.Size(120, 20)
        Me.SearchBB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.SearchBB.TabIndex = 3
        Me.SearchBB.Text = "Search"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(3, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(117, 20)
        Me.LabelX1.TabIndex = 4
        Me.LabelX1.Text = "Search For Title ID :"
        '
        'GameName
        '
        Me.GameName.Text = "Game Name"
        Me.GameName.Width = 229
        '
        'TitleID
        '
        Me.TitleID.Text = "Title ID"
        Me.TitleID.Width = 98
        '
        'GameFinder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(468, 211)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.SearchBB)
        Me.Controls.Add(Me.TextBoxX1)
        Me.Controls.Add(Me.ListViewEx1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "GameFinder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameFinder"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListViewEx1 As DevComponents.DotNetBar.Controls.ListViewEx
    Friend WithEvents GameName As System.Windows.Forms.ColumnHeader
    Friend WithEvents TitleID As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents SearchBB As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
End Class
