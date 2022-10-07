Public Class FormMahasiswa
    Sub panggildata_mahasiswa()
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT nim, nama, jenis_kelamin, tempat_lahir, tgl_lahir, alamat, nama_kelas FROM mahasiswa
                                                         INNER JOIN kelas ON kelas.id = mahasiswa.kelas_id", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_Mahasiswa.DataSource = dt
            DGV_Mahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_Mahasiswa.Columns(0).HeaderText = "NIM"
            DGV_Mahasiswa.Columns(1).HeaderText = "Nama"
            DGV_Mahasiswa.Columns(2).HeaderText = "Jenis Kelamin"
            DGV_Mahasiswa.Columns(3).HeaderText = "Tempat Lahir"
            DGV_Mahasiswa.Columns(4).HeaderText = "Tanggal Lahir"
            DGV_Mahasiswa.Columns(5).HeaderText = "Alamat"
            DGV_Mahasiswa.Columns(6).HeaderText = "Kelas"
        Else
            DGV_Mahasiswa.DataSource = Nothing
        End If
    End Sub

    Sub panggildata_kelas()
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM kelas", connct)
        dt = New DataTable
        da.Fill(dt)
        ComboBox_Kelas.DataSource = dt
        ComboBox_Kelas.DisplayMember = "nama_kelas"
        ComboBox_Kelas.ValueMember = "id"
        ComboBox_Kelas.Text = ""
    End Sub

    Private Sub FormMahasiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildata_mahasiswa()
        panggildata_kelas()

        TextBox_NIM.Select()
    End Sub

    Private Sub DGV_Mahasiswa_Click(sender As Object, e As EventArgs) Handles DGV_Mahasiswa.Click
        i = DGV_Mahasiswa.CurrentRow.Index
        With DGV_Mahasiswa.Rows.Item(i)
            TextBox_NIM.Text = .Cells(0).Value
            TextBox_Nama.Text = .Cells(1).Value
            ComboBox_JnsKlmn.Text = .Cells(2).Value
            TextBox_TmptLahir.Text = .Cells(3).Value
            DateTimePicker1.Text = .Cells(4).Value
            RichTextBox_Alamat.Text = .Cells(5).Value
            ComboBox_Kelas.Text = .Cells(6).Value
        End With

        TextBox_NIM.Enabled = False
    End Sub

    Private Sub Button_Simpan_Click(sender As Object, e As EventArgs) Handles Button_Simpan.Click
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO mahasiswa VALUES
                                                       ('" & TextBox_NIM.Text & "',
                                                       '" & TextBox_Nama.Text & "',
                                                       '" & ComboBox_JnsKlmn.Text & "',
                                                       '" & TextBox_TmptLahir.Text & "',
                                                       '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "',
                                                       '" & RichTextBox_Alamat.Text & "',
                                                       '" & ComboBox_Kelas.SelectedValue & "')", connct)

        cmd.ExecuteNonQuery()
        panggildata_mahasiswa()

        TextBox_NIM.Text = ""
        TextBox_Nama.Text = ""
        ComboBox_JnsKlmn.Text = ""
        TextBox_TmptLahir.Text = ""
        DateTimePicker1.ResetText()
        RichTextBox_Alamat.Text = ""
        ComboBox_Kelas.Text = ""
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE mahasiswa SET 
                                                        nim ='" & TextBox_NIM.Text & "',
                                                        nama ='" & TextBox_Nama.Text & "',
                                                        jenis_kelamin ='" & ComboBox_JnsKlmn.Text & "',
                                                        tempat_lahir ='" & TextBox_TmptLahir.Text & "',
                                                        tgl_lahir ='" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "',
                                                        alamat ='" & RichTextBox_Alamat.Text & "',
                                                        kelas_id ='" & ComboBox_Kelas.SelectedValue & "'
                                                       WHERE nim ='" & TextBox_NIM.Text & "'", connct)

        cmd.ExecuteNonQuery()
        panggildata_mahasiswa()

        TextBox_NIM.Text = ""
        TextBox_Nama.Text = ""
        ComboBox_JnsKlmn.Text = ""
        TextBox_TmptLahir.Text = ""
        DateTimePicker1.ResetText()
        RichTextBox_Alamat.Text = ""
        ComboBox_Kelas.Text = ""
    End Sub

    Private Sub Button_Hapus_Click(sender As Object, e As EventArgs) Handles Button_Hapus.Click
        koneksi()

        If MessageBox.Show("Yakin Hapus Data?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM mahasiswa WHERE nim = '" & TextBox_NIM.Text & "'", connct)

            cmd.ExecuteNonQuery()
            panggildata_mahasiswa()
        End If

        TextBox_NIM.Text = ""
        TextBox_Nama.Text = ""
        ComboBox_JnsKlmn.Text = ""
        TextBox_TmptLahir.Text = ""
        DateTimePicker1.ResetText()
        RichTextBox_Alamat.Text = ""
        ComboBox_Kelas.Text = ""
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox_NIM.Text = ""
        TextBox_Nama.Text = ""
        ComboBox_JnsKlmn.Text = ""
        TextBox_TmptLahir.Text = ""
        DateTimePicker1.ResetText()
        RichTextBox_Alamat.Text = ""
        ComboBox_Kelas.Text = ""

        TextBox_NIM.Enabled = True
    End Sub

    Private Sub TextBox_Pencarian_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Pencarian.TextChanged
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT nim, nama, jenis_kelamin, tempat_lahir, tgl_lahir, alamat, nama_kelas FROM mahasiswa
                                                         INNER JOIN kelas ON kelas.id = mahasiswa.kelas_id
                                                         WHERE nim LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                         nim LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                         nama LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                         jenis_kelamin LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                         tempat_lahir LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                         alamat LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                         nama_kelas LIKE '%" & TextBox_Pencarian.Text & "%'", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_Mahasiswa.DataSource = dt
            DGV_Mahasiswa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_Mahasiswa.Columns(0).HeaderText = "NIM"
            DGV_Mahasiswa.Columns(1).HeaderText = "Nama"
            DGV_Mahasiswa.Columns(2).HeaderText = "Jenis Kelamin"
            DGV_Mahasiswa.Columns(3).HeaderText = "Tempat Lahir"
            DGV_Mahasiswa.Columns(4).HeaderText = "Tanggal Lahir"
            DGV_Mahasiswa.Columns(5).HeaderText = "Alamat"
            DGV_Mahasiswa.Columns(6).HeaderText = "Kelas"
        Else
            DGV_Mahasiswa.DataSource = Nothing
        End If
    End Sub
End Class