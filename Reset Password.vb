Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Please Input your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf TextBox1.Text = TextBox2.Text Then
            MessageBox.Show("Password Reseted", "Notification", MessageBoxButtons.OK)
            password = TextBox1.Text
            Dim frm As New Form1
            frm.Show()
            Me.Close()
        Else
            MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.UseSystemPasswordChar = False
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox1.UseSystemPasswordChar = True
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
End Class