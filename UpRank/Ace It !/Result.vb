Public Class Result
  
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        If Form1.r11.Checked = False And Form1.r12.Checked = False And Form1.r13.Checked = False And Form1.r14.Checked = False Then
            BackColor = Color.Red
        Else
            BackColor = Color.Green
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        If Form1.r21.Checked = False And Form1.r22.Checked = False And Form1.r23.Checked = False And Form1.r24.Checked = False Then
            BackColor = Color.Red
        Else
            BackColor = Color.Green
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs)
        If Form1.r31.Checked = False And Form1.r32.Checked = False And Form1.r33.Checked = False And Form1.r34.Checked = False Then
            BackColor = Color.Red
        Else
            BackColor = Color.Green
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        If Form1.r41.Checked = False And Form1.r42.Checked = False And Form1.r43.Checked = False And Form1.r44.Checked = False Then
            BackColor = Color.Red
        Else
            BackColor = Color.Green
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        If Form1.r51.Checked = False And Form1.r52.Checked = False And Form1.r53.Checked = False And Form1.r54.Checked = False Then
            BackColor = Color.Red
        Else
            BackColor = Color.Green
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs)
        If Form1.r61.Checked = False And Form1.r62.Checked = False And Form1.r63.Checked = False And Form1.r64.Checked = False Then
            BackColor = Color.Red
        Else
            BackColor = Color.Green
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        If Form1.r71.Checked = False And Form1.r72.Checked = False And Form1.r73.Checked = False And Form1.r74.Checked = False Then
            BackColor = Color.Red
        Else
            BackColor = Color.Green
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)
        If Form1.r81.Checked = False And Form1.r82.Checked = False And Form1.r83.Checked = False And Form1.r84.Checked = False Then
            BackColor = Color.Red
        Else
            BackColor = Color.Green
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs)
        If Form1.r91.Checked = False And Form1.r92.Checked = False And Form1.r93.Checked = False And Form1.r94.Checked = False Then
            BackColor = Color.Red
        Else
            BackColor = Color.Green
        End If
    End Sub

    Public Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim totalMarks As String
        totalMarks = Convert.ToString(Form1.total)
        ResultLabel.Text = (totalMarks)

        Dim nege As String
        nege = Convert.ToString(Form1.neg)
        negeativeLabel.Text = nege

        Dim posi As String
        posi = Convert.ToString(Form1.pos)
        positiveLabel.Text = posi

        Dim per As Integer = 64
        per = per + totalMarks
        BunifuCircleProgressbar1.Value = per







    End Sub

    Private Sub totalMrk_Click(sender As Object, e As EventArgs) Handles negeativeLabel.Click, positiveLabel.Click, ResultLabel.Click

    End Sub

    Private Sub LineShape1_Click(sender As Object, e As EventArgs) Handles LineShape1.Click

    End Sub

    Private Sub PictureBox4_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub
End Class