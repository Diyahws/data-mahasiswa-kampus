Public Class FormLogin
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()

        TextBox_User.Select()
        TextBox_User.MaxLength = 6
        TextBox_Pass.MaxLength = 6
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button_Masuk.Click
        cmd = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM akun WHERE
                                                  username = '" & TextBox_User.Text & "' AND
                                                  password = '" & TextBox_Pass.Text & "'", connct)

        dr = cmd.ExecuteReader
        dr.Read()

        If dr.HasRows Then
            Timer1.Start()
            'Me.Visible = False
            'Form1.Show()
        ElseIf Not dr.HasRows Then
            MessageBox.Show("Periksa Kembali Userame dan Password Anda", "Peringatan!", MessageBoxButtons.OK)
            TextBox_User.Text = ""
            TextBox_Pass.Text = ""
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (ProgressBar1.Value < 100) Then
            ProgressBar1.Value += 20
        Else
            Timer1.Stop()
            Me.Hide()
            Form1.ShowDialog()
            Me.Close()
        End If
    End Sub
End Class