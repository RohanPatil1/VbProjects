<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Result
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Result))
        Me.negeativeLabel = New System.Windows.Forms.Label()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.positiveLabel = New System.Windows.Forms.Label()
        Me.BunifuCircleProgressbar1 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'negeativeLabel
        '
        Me.negeativeLabel.AutoSize = True
        Me.negeativeLabel.BackColor = System.Drawing.Color.Transparent
        Me.negeativeLabel.Font = New System.Drawing.Font("Oswald ExtraLight", 36.0!)
        Me.negeativeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.negeativeLabel.Location = New System.Drawing.Point(357, 303)
        Me.negeativeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.negeativeLabel.Name = "negeativeLabel"
        Me.negeativeLabel.Size = New System.Drawing.Size(59, 82)
        Me.negeativeLabel.TabIndex = 1
        Me.negeativeLabel.Text = "0"
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.ForeColor = System.Drawing.Color.Coral
        Me.Panel2.Location = New System.Drawing.Point(-8, -1)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1535, 69)
        Me.Panel2.TabIndex = 2
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(1136, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(67, 61)
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(16, 4)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(73, 62)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Oswald ExtraLight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Label2.Location = New System.Drawing.Point(79, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 49)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "UpRank"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1221, 607)
        Me.ShapeContainer1.TabIndex = 3
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 31
        Me.LineShape3.X2 = 698
        Me.LineShape3.Y1 = 271
        Me.LineShape3.Y2 = 272
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 513
        Me.LineShape2.X2 = 513
        Me.LineShape2.Y1 = 219
        Me.LineShape2.Y2 = 422
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 254
        Me.LineShape1.X2 = 253
        Me.LineShape1.Y1 = 220
        Me.LineShape1.Y2 = 422
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BackColor = System.Drawing.Color.Transparent
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ButtonFace
        Me.RectangleShape1.Location = New System.Drawing.Point(35, 220)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(666, 203)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(55, 232)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Correct Response"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(279, 232)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Negative Response"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(575, 232)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 24)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Total"
        '
        'ResultLabel
        '
        Me.ResultLabel.AutoSize = True
        Me.ResultLabel.BackColor = System.Drawing.Color.Transparent
        Me.ResultLabel.Font = New System.Drawing.Font("Oswald ExtraLight", 36.0!)
        Me.ResultLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ResultLabel.Location = New System.Drawing.Point(588, 303)
        Me.ResultLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(59, 82)
        Me.ResultLabel.TabIndex = 1
        Me.ResultLabel.Text = "0"
        '
        'positiveLabel
        '
        Me.positiveLabel.AutoSize = True
        Me.positiveLabel.BackColor = System.Drawing.Color.Transparent
        Me.positiveLabel.Font = New System.Drawing.Font("Oswald ExtraLight", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.positiveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.positiveLabel.Location = New System.Drawing.Point(107, 303)
        Me.positiveLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.positiveLabel.Name = "positiveLabel"
        Me.positiveLabel.Size = New System.Drawing.Size(59, 82)
        Me.positiveLabel.TabIndex = 1
        Me.positiveLabel.Text = "0"
        '
        'BunifuCircleProgressbar1
        '
        Me.BunifuCircleProgressbar1.animated = True
        Me.BunifuCircleProgressbar1.animationIterval = 10
        Me.BunifuCircleProgressbar1.animationSpeed = 10
        Me.BunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgressbar1.BackgroundImage = CType(resources.GetObject("BunifuCircleProgressbar1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuCircleProgressbar1.Font = New System.Drawing.Font("Oswald ExtraLight", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCircleProgressbar1.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgressbar1.LabelVisible = True
        Me.BunifuCircleProgressbar1.LineProgressThickness = 21
        Me.BunifuCircleProgressbar1.LineThickness = 15
        Me.BunifuCircleProgressbar1.Location = New System.Drawing.Point(867, 175)
        Me.BunifuCircleProgressbar1.Margin = New System.Windows.Forms.Padding(11, 18, 11, 18)
        Me.BunifuCircleProgressbar1.MaxValue = 100
        Me.BunifuCircleProgressbar1.Name = "BunifuCircleProgressbar1"
        Me.BunifuCircleProgressbar1.ProgressBackColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.BunifuCircleProgressbar1.Size = New System.Drawing.Size(295, 295)
        Me.BunifuCircleProgressbar1.TabIndex = 5
        Me.BunifuCircleProgressbar1.Value = 78
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Nothing
        Me.BunifuDragControl1.Vertical = True
        '
        'Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1221, 607)
        Me.Controls.Add(Me.BunifuCircleProgressbar1)
        Me.Controls.Add(Me.positiveLabel)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.negeativeLabel)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Result"
        Me.Text = "Result"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents negeativeLabel As System.Windows.Forms.Label
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents positiveLabel As System.Windows.Forms.Label
    Friend WithEvents ResultLabel As System.Windows.Forms.Label
    Friend WithEvents BunifuCircleProgressbar1 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
