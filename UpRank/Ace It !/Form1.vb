Public Class Form1
    Public count As Integer = 0
    Public neg As Integer = 0
    Public withOutNeg As Integer = 0
    Public total As Integer = 0
    Public pos As Integer = 0
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs)
        Panel1.Width = 43
        PictureBox1.Visible = False

    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)
        Panel1.Width = 255
        PictureBox1.Visible = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim i = 0



    End Sub

   

   
    
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

  

  
    
    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub

    Private Sub PictureBox13_MouseHover(sender As Object, e As EventArgs) Handles PictureBox13.MouseHover

    End Sub

    Private Sub submit1_Click(sender As Object, e As EventArgs) Handles submit1.Click
        If r11.Checked = False And r12.Checked = False And r13.Checked = False And r14.Checked = False Then
            MsgBox("Please Select An Option To Submit Your Answer ", vbOKCancel)
        End If
        If r11.Checked = True Then
            count += 1
            que1.BackColor = Color.PaleGreen
        Else
            neg += 1
            que1.BackColor = Color.PaleGreen
        End If



    End Sub

    Private Sub submit2_Click(sender As Object, e As EventArgs) Handles submit2.Click
        If r21.Checked = False And r22.Checked = False And r23.Checked = False And r24.Checked = False Then
            MsgBox("Please Select An Option To Submit Your Answer ", vbOKCancel)
        End If
        If r21.Checked = True Then
            count += 1
            que2.BackColor = Color.PaleGreen
        Else
            neg += 1
            que2.BackColor = Color.PaleGreen
        End If
    End Sub

    Private Sub submit3_Click(sender As Object, e As EventArgs) Handles submit3.Click
        If r31.Checked = False And r32.Checked = False And r33.Checked = False And r34.Checked = False Then
            MsgBox("Please Select An Option To Submit Your Answer ", vbOKCancel)
        End If
        If r31.Checked = True Then
            count += 1
            que3.BackColor = Color.PaleGreen
        Else
            neg += 1
            que3.BackColor = Color.PaleGreen
        End If
    End Sub

    Private Sub submit4_Click(sender As Object, e As EventArgs) Handles submit4.Click
        If r41.Checked = False And r42.Checked = False And r43.Checked = False And r44.Checked = False Then
            MsgBox("Please Select An Option To Submit Your Answer ", vbOKCancel)
        End If
        If r41.Checked = True Then
            count += 1
            que4.BackColor = Color.PaleGreen
        Else
            neg += 1
            que4.BackColor = Color.PaleGreen
        End If
    End Sub

    Private Sub submit5_Click(sender As Object, e As EventArgs) Handles submit5.Click
        If r51.Checked = False And r52.Checked = False And r53.Checked = False And r54.Checked = False Then
            MsgBox("Please Select An Option To Submit Your Answer ", vbOKCancel)
        End If
        If r51.Checked = True Then
            count += 1
            que5.BackColor = Color.PaleGreen
        Else
            neg += 1
            que5.BackColor = Color.PaleGreen
        End If
    End Sub

    
    Private Sub submit6_Click(sender As Object, e As EventArgs) Handles submit6.Click
        If r61.Checked = False And r62.Checked = False And r63.Checked = False And r64.Checked = False Then
            MsgBox("Please Select An Option To Submit Your Answer ", vbOKCancel)
        End If
        If r61.Checked = True Then
            count += 1
            que6.BackColor = Color.PaleGreen
        Else
            neg += 1
            que6.BackColor = Color.PaleGreen
        End If
    End Sub

    Private Sub submit7_Click(sender As Object, e As EventArgs) Handles submit7.Click, submit7.Click
        If r71.Checked = False And r72.Checked = False And r73.Checked = False And r74.Checked = False Then
            MsgBox("Please Select An Option To Submit Your Answer ", vbOKCancel)
        End If
        If r71.Checked = True Then
            count += 1
            que7.BackColor = Color.PaleGreen
        Else
            neg += 1
            que7.BackColor = Color.PaleGreen
        End If
    End Sub

    Private Sub submit8_Click(sender As Object, e As EventArgs) Handles submit8.Click
        If r81.Checked = False And r82.Checked = False And r83.Checked = False And r84.Checked = False Then
            MsgBox("Please Select An Option To Submit Your Answer ", vbOKCancel)
        End If
        If r81.Checked = True Then
            count += 1
            que8.BackColor = Color.PaleGreen
        Else
            neg += 1
            que8.BackColor = Color.PaleGreen
        End If
    End Sub

    Private Sub submit9_Click(sender As Object, e As EventArgs) Handles submit9.Click
        If r91.Checked = False And r92.Checked = False And r93.Checked = False And r94.Checked = False Then
            MsgBox("Please Select An Option To Submit Your Answer ", vbOKCancel)
        End If
        If r91.Checked = True Then
            count += 1
            que9.BackColor = Color.PaleGreen
        Else
            neg += 1
            que9.BackColor = Color.PaleGreen
        End If
    End Sub

    Public Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click, BunifuFlatButton1.Click


        Me.Hide()
        pos = 9 - neg
        InstructionForm.Hide()
        withOutNeg = count * 4
        total = withOutNeg - neg

        Result.Show()


    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        InstructionForm.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub left1_Click(sender As Object, e As EventArgs) Handles left1.Click

        If r11.Checked = True Or r12.Checked = True Or r13.Checked = True Or r14.Checked = True Then
            que1.BackColor = Color.Red
            r11.Checked = False
            r12.Checked = False
            r13.Checked = False
            r14.Checked = False
        End If
    End Sub

    Private Sub left2_Click(sender As Object, e As EventArgs) Handles left2.Click
        If r21.Checked = True Or r22.Checked = True Or r23.Checked = True Or r24.Checked = True Then
            que2.BackColor = Color.Red
            r21.Checked = False
            r22.Checked = False
            r23.Checked = False
            r24.Checked = False
        End If
    End Sub

    Private Sub left3_Click(sender As Object, e As EventArgs) Handles left3.Click
        If r31.Checked = True Or r32.Checked = True Or r33.Checked = True Or r34.Checked = True Then
            que3.BackColor = Color.Red
            r31.Checked = False
            r32.Checked = False
            r33.Checked = False
            r34.Checked = False
        End If
    End Sub

    Private Sub left4_Click(sender As Object, e As EventArgs) Handles left4.Click
        If r41.Checked = True Or r42.Checked = True Or r43.Checked = True Or r44.Checked = True Then
            que4.BackColor = Color.Red
            r41.Checked = False
            r42.Checked = False
            r43.Checked = False
            r44.Checked = False
        End If
    End Sub

    Private Sub left5_Click(sender As Object, e As EventArgs) Handles left5.Click
        If r51.Checked = True Or r52.Checked = True Or r53.Checked = True Or r54.Checked = True Then
            que5.BackColor = Color.Red
            r51.Checked = False
            r52.Checked = False
            r53.Checked = False
            r54.Checked = False
        End If
    End Sub

    Private Sub left6_Click(sender As Object, e As EventArgs) Handles left6.Click
        If r61.Checked = True Or r62.Checked = True Or r63.Checked = True Or r64.Checked = True Then
            que6.BackColor = Color.Red
            r61.Checked = False
            r62.Checked = False
            r63.Checked = False
            r64.Checked = False
        End If
    End Sub

    Private Sub left7_Click(sender As Object, e As EventArgs) Handles left7.Click
        If r71.Checked = True Or r72.Checked = True Or r73.Checked = True Or r74.Checked = True Then
            que7.BackColor = Color.Red
            r71.Checked = False
            r72.Checked = False
            r73.Checked = False
            r74.Checked = False
        End If
    End Sub

    Private Sub left8_Click(sender As Object, e As EventArgs) Handles left8.Click
        If r81.Checked = True Or r82.Checked = True Or r83.Checked = True Or r84.Checked = True Then
            que8.BackColor = Color.Red
            r81.Checked = False
            r82.Checked = False
            r83.Checked = False
            r84.Checked = False
        End If
    End Sub

    Private Sub left9_Click(sender As Object, e As EventArgs) Handles left9.Click
        If r91.Checked = True Or r92.Checked = True Or r93.Checked = True Or r94.Checked = True Then
            que9.BackColor = Color.Red
            r91.Checked = False
            r92.Checked = False
            r93.Checked = False
            r94.Checked = False
        End If
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()

    End Sub
End Class
