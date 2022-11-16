Public Class CreateAccountForm
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Dim frm1 As New Form1
        frm1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox5.Text = TextBox6.Text Then
            MessageBox.Show("Account Created", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
            username = TextBox4.Text
            password = TextBox6.Text
            Dim frm1 As New Form1
            frm1.Show()
            Me.Close()
        Else
            MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox5.UseSystemPasswordChar = False
            TextBox6.UseSystemPasswordChar = False
        Else
            TextBox5.UseSystemPasswordChar = True
            TextBox6.UseSystemPasswordChar = True
        End If
    End Sub


End Class