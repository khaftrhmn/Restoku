Public Class MainApplication
    Dim Kopi As Integer
    Dim Teh As Integer
    Dim Mie As Integer
    Dim SupAyam As Integer
    Dim Kentang As Integer




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = TextBox2.Text + ComboBox1.SelectedItem + vbCrLf
        TextBox1.Text = TextBox1.Text + CStr(NumericUpDown1.Value) + "x" + vbCrLf
        If ComboBox1.SelectedIndex = 0 Then
            Kopi = Kopi + NumericUpDown1.Value
            TextBox5.Text = TextBox5.Text + "Rp" + CStr(NumericUpDown1.Value * 15000) + vbCrLf
        End If
        If ComboBox1.SelectedIndex = 1 Then
            Teh = Teh + NumericUpDown1.Value
            TextBox5.Text = TextBox5.Text + "Rp" + CStr(NumericUpDown1.Value * 5000) + vbCrLf
        End If
        If ComboBox1.SelectedIndex = 2 Then
            Mie = Mie + NumericUpDown1.Value
            TextBox5.Text = TextBox5.Text + "Rp" + CStr(NumericUpDown1.Value * 12000) + vbCrLf
        End If
        If ComboBox1.SelectedIndex = 3 Then
            SupAyam = SupAyam + NumericUpDown1.Value
            TextBox5.Text = TextBox5.Text + "Rp" + CStr(NumericUpDown1.Value * 30000) + vbCrLf
        End If
        If ComboBox1.SelectedIndex = 4 Then
            Kentang = Kentang + NumericUpDown1.Value
            TextBox5.Text = TextBox5.Text + "Rp" + CStr(NumericUpDown1.Value * 20000) + vbCrLf
        End If
        TextBox3.Text = Val((15000 * Kopi) + (5000 * Teh) + (12000 * Mie) + (30000 * SupAyam) + (20000 * Kentang))
        TextBox4.Text = Val(TextBox3.Text) * 0.1
        If RadioButton6.Checked Then
            TextBox7.Text = Val(TextBox3.Text) * 0.2
        Else
            TextBox7.Text = Val(TextBox3.Text) * 0
        End If
        TextBox6.Text = Val(TextBox3.Text) + Val(TextBox4.Text) - Val(TextBox7.Text)



    End Sub




    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.Gray
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.FromArgb(225, 225, 225)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Checkout complete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ReceiptBox.Text = "___________________Lorem Restaurant___________________" + vbCrLf + vbCrLf

        If RadioButton6.Checked Then
            ReceiptBox.Text = ReceiptBox.Text + "Member ID : " + MaskedTextBox1.Text + vbCrLf + "Member Name : " + MaskedTextBox2.Text + vbCrLf + vbCrLf
        End If

        ReceiptBox.Text = ReceiptBox.Text + "Item Name : " + vbCrLf + TextBox2.Text + vbCrLf + "Quantity : " + vbCrLf + TextBox1.Text + vbCrLf + vbCrLf
        ReceiptBox.Text = ReceiptBox.Text + "Transaction ID : " + TextBox9.Text + vbCrLf + "Employee ID : " + TextBox10.Text + vbCrLf + "Employee Name : " + TextBox11.Text + vbCrLf + vbCrLf + "Subtotal : Rp." + TextBox3.Text + vbCrLf
        ReceiptBox.Text = ReceiptBox.Text + "Tax : Rp." + TextBox4.Text + vbCrLf + "Discount : Rp." + TextBox7.Text + vbCrLf + "Total : Rp." + TextBox6.Text + vbCrLf + vbCrLf + "Payment Method : "
        If RadioButton1.Checked Then
            ReceiptBox.Text = ReceiptBox.Text + RadioButton1.Text + vbCrLf
        ElseIf RadioButton2.Checked Then
            ReceiptBox.Text = ReceiptBox.Text + RadioButton2.Text + vbCrLf
        ElseIf RadioButton3.Checked Then
            ReceiptBox.Text = ReceiptBox.Text + RadioButton3.Text + vbCrLf
        ElseIf RadioButton4.Checked Then
            ReceiptBox.Text = ReceiptBox.Text + RadioButton4.Text + vbCrLf
        End If
        ReceiptBox.Text = ReceiptBox.Text + "Payment Date : " + DateTimePicker1.Text


        Receipt = ReceiptBox.Text
        ReceiptForm.ShowDialog()



        KopiModule = KopiModule + Kopi
        TehModule = TehModule + Teh
        MieModule = MieModule + Mie
        SupAyamModule = SupAyamModule + SupAyam
        KentangModule = KentangModule + Kentang

        beverages = KopiModule + TehModule
        food = SupAyamModule + KentangModule + MieModule

        Chart2.Series("Category Sold").Points.Clear()
        Chart2.Series("Category Sold").Points.AddXY("Beverages", beverages)
        Chart2.Series("Category Sold").Points.AddXY("Food", food)

        Chart1.Series("Product Sold").Points.Clear()
        Chart1.Series("Product Sold").Points.AddXY("Kopi", KopiModule)
        Chart1.Series("Product Sold").Points.AddXY("Teh", TehModule)
        Chart1.Series("Product Sold").Points.AddXY("Mie", MieModule)
        Chart1.Series("Product Sold").Points.AddXY("Sup Ayam", SupAyamModule)
        Chart1.Series("Product Sold").Points.AddXY("Kentang", KentangModule)

        income = income + Val(TextBox6.Text)


        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = ""
        TextBox7.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        Kopi = 0
        Teh = 0
        Mie = 0
        SupAyam = 0
        Kentang = 0


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox7.Text = ""
        TextBox5.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        Kopi = 0
        Teh = 0
        Mie = 0
        SupAyam = 0
        Kentang = 0
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        Randomize()
        MaskedTextBox1.Text = Val(Math.Ceiling(Rnd() * 1000))
        TextBox9.Text = Val(Math.Ceiling(Rnd() * 1000))
        TextBox10.Text = Val(Math.Ceiling(Rnd() * 1000))
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        Randomize()
        MaskedTextBox1.Text = ""
        TextBox9.Text = Val(Math.Ceiling(Rnd() * 100000))
        TextBox10.Text = Val(Math.Ceiling(Rnd() * 100))
    End Sub

    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim frm1 As New Form1
        frm1.Show()
        Me.Hide()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Show()
        Panel2.Hide()
        Button4.ForeColor = Color.Coral
        Button5.ForeColor = Color.White
    End Sub

    Private Sub MainApplication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel11.Hide()
        Panel2.Hide()
        Button4.ForeColor = Color.Coral
        Button5.ForeColor = Color.White
        Button6.ForeColor = Color.FromArgb(0, 120, 215)
        Button6.BackColor = Color.FromArgb(25, 29, 40)
        PictureBox16.BackColor = Color.FromArgb(25, 29, 40)
        ReceiptBox.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel2.Show()
        Panel1.Hide()
        Button5.ForeColor = Color.Coral
        Button4.ForeColor = Color.White
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button6.BackColor = Color.FromArgb(48, 54, 76)
        Button6.ForeColor = Color.White
        Button7.BackColor = Color.FromArgb(25, 29, 40)
        Button7.ForeColor = Color.FromArgb(0, 120, 215)
        PictureBox17.BackColor = Color.FromArgb(25, 29, 40)
        PictureBox16.BackColor = Color.FromArgb(48, 54, 76)
        Panel11.Show()
        Panel10.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Panel10.Show()
        Panel11.Hide()
        Button7.BackColor = Color.FromArgb(48, 54, 76)
        Button6.ForeColor = Color.FromArgb(0, 120, 215)
        Button6.BackColor = Color.FromArgb(25, 29, 40)
        Button7.ForeColor = Color.White
        PictureBox16.BackColor = Color.FromArgb(25, 29, 40)
        PictureBox17.BackColor = Color.FromArgb(48, 54, 76)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure want to logout", "Notification", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim frm1 As New Form1
            Me.Hide()
            frm1.Show()
        ElseIf result = DialogResult.No Then

        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If TextBox18.Text = "admin" Or TextBox18.Text = password Then
            If TextBox17.Text = TextBox19.Text Then
                MessageBox.Show("Password Changed", "Notification", MessageBoxButtons.OK)
                password = TextBox17.Text
                TextBox17.Text = ""
                TextBox18.Text = ""
                TextBox19.Text = ""
            Else
                MessageBox.Show("Password Does Not Match", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please enter the correct Password", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        MessageBox.Show("Changes Saved", "Notification")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox17.UseSystemPasswordChar = False
            TextBox18.UseSystemPasswordChar = False
            TextBox19.UseSystemPasswordChar = False
        Else
            TextBox17.UseSystemPasswordChar = True
            TextBox18.UseSystemPasswordChar = True
            TextBox19.UseSystemPasswordChar = True
        End If
    End Sub
End Class