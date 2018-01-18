<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainIntro
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainIntro))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Test1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Test3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Test1ToolStripMenuItem, Me.Test2ToolStripMenuItem, Me.Test3ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(106, 70)
        Me.ContextMenuStrip1.Text = "TESTS"
        '
        'Test1ToolStripMenuItem
        '
        Me.Test1ToolStripMenuItem.Name = "Test1ToolStripMenuItem"
        Me.Test1ToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.Test1ToolStripMenuItem.Text = "Test 1"
        '
        'Test2ToolStripMenuItem
        '
        Me.Test2ToolStripMenuItem.Name = "Test2ToolStripMenuItem"
        Me.Test2ToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.Test2ToolStripMenuItem.Text = "Test 2"
        '
        'Test3ToolStripMenuItem
        '
        Me.Test3ToolStripMenuItem.Name = "Test3ToolStripMenuItem"
        Me.Test3ToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.Test3ToolStripMenuItem.Text = "Test 3"
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Select Test"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Font = New System.Drawing.Font("Geometr212 BkCn BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = CType(resources.GetObject("BunifuFlatButton2.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0.0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(437, 200)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(220, 76)
        Me.BunifuFlatButton2.TabIndex = 0
        Me.BunifuFlatButton2.Text = "Select Test"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.BunifuFlatButton2)
        Me.Panel1.Location = New System.Drawing.Point(0, 55)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1136, 493)
        Me.Panel1.TabIndex = 2
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.ForeColor = System.Drawing.Color.Coral
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1133, 56)
        Me.Panel2.TabIndex = 3
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(55, 50)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Oswald ExtraLight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label1.Location = New System.Drawing.Point(59, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 49)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "UpRank"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(1056, -2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(67, 61)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'MainIntro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 548)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainIntro"
        Me.Text = "MainIntro"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Test1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Test2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Test3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
