Public Class FormAkun
    Sub panggildata_akun()
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM akun", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_Akun.DataSource = dt
            DGV_Akun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_Akun.Columns(0).HeaderText = "Username"
            DGV_Akun.Columns(1).HeaderText = "Password"
        Else
            DGV_Akun.DataSource = Nothing
        End If
    End Sub

    Private Sub FormAkun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildata_akun()

        TextBox_User.Select()
        TextBox_User.MaxLength = 6
        TextBox_Pass.MaxLength = 6
    End Sub

    Private Sub Button_Simpan_Click(sender As Object, e As EventArgs) Handles Button_Simpan.Click
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO akun VALUES ('" & TextBox_User.Text & "', '" & TextBox_Pass.Text & "')", connct)

        cmd.ExecuteNonQuery()
        panggildata_akun()

        TextBox_User.Text = ""
        TextBox_Pass.Text = ""
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE akun SET username ='" & TextBox_User.Text & "', password ='" & TextBox_Pass.Text & "'
                                                       WHERE username ='" & TextBox_User.Text & "'", connct)

        cmd.ExecuteNonQuery()
        panggildata_akun()

        TextBox_User.Text = ""
        TextBox_Pass.Text = ""
    End Sub

    Private Sub Button_Hapus_Click(sender As Object, e As EventArgs) Handles Button_Hapus.Click
        koneksi()

        If MessageBox.Show("Yakin Hapus Data?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM akun WHERE username='" & TextBox_User.Text & "'", connct)

            cmd.ExecuteNonQuery()
            panggildata_akun()
        End If

        TextBox_User.Text = ""
        TextBox_Pass.Text = ""
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox_User.Text = ""
        TextBox_Pass.Text = ""

        TextBox_User.Enabled = True
    End Sub

    Private Sub DGV_Akun_Click(sender As Object, e As EventArgs) Handles DGV_Akun.Click
        i = DGV_Akun.CurrentRow.Index
        With DGV_Akun.Rows.Item(i)
            TextBox_User.Text = .Cells(0).Value
            TextBox_Pass.Text = .Cells(1).Value
        End With

        TextBox_User.Enabled = False
    End Sub

    Private Sub TextBox_Pencarian_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Pencarian.TextChanged
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM akun
                                                          WHERE username LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                          password LIKE '%" & TextBox_Pencarian.Text & "%'
                                                          ORDER BY username ASC", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_Akun.DataSource = dt
            DGV_Akun.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_Akun.Columns(0).HeaderText = "Username"
            DGV_Akun.Columns(1).HeaderText = "Password"
        Else
            DGV_Akun.DataSource = Nothing
        End If
    End Sub
End Class