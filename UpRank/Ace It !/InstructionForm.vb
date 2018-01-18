Public Class InstructionForm

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
    Private Sub BunifuGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuGradientPanel1.Paint

    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class