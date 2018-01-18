Public Class MainIntro

   

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click


        ContextMenuStrip1.Show(BunifuFlatButton2, 20, BunifuFlatButton2.Height)
        
    End Sub

    Private Sub Test1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Test1ToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
        BackColor = Color.Aqua

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint


    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub
End Class