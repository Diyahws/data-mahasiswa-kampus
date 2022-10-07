Public Class FormNilai
    Sub panggildata_nilai()
        koneksi()

        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT nilai.id, mahasiswa.nim, mahasiswa.nama, mata_kuliah.nama_matkul, nilai.jenis_nilai, dosen.nip, dosen.nama_dosen, nilai.nilai
                                                          FROM nilai
                                                          INNER JOIN mahasiswa
                                                          ON mahasiswa.nim = nilai.nim
                                                          INNER JOIN mata_kuliah
                                                          ON mata_kuliah.id_matkul = nilai.id_matkul
                                                          INNER JOIN dosen
                                                          ON dosen.nip = nilai.nip ", connct)

        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_Nilai.DataSource = dt
            DGV_Nilai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_Nilai.Columns(0).HeaderText = "Id"
            DGV_Nilai.Columns(1).HeaderText = "NIM"
            DGV_Nilai.Columns(2).HeaderText = "Nama"
            DGV_Nilai.Columns(3).HeaderText = "Mata Kuliah"
            DGV_Nilai.Columns(4).HeaderText = "Jenis Nilai"
            DGV_Nilai.Columns(5).HeaderText = "NIP"
            DGV_Nilai.Columns(6).HeaderText = "Nama Dosen"
            DGV_Nilai.Columns(7).HeaderText = "Nilai"
        Else
            DGV_Nilai.DataSource = Nothing
        End If
    End Sub
    Sub panggildata_nilai_CBnim()
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM mahasiswa", connct)
        dt = New DataTable
        da.Fill(dt)
        CB_NIM.DataSource = dt
        CB_NIM.DisplayMember = "nama"
        CB_NIM.ValueMember = "nim"
        CB_NIM.Text = ""
    End Sub
    Sub panggildata_nilai_CBmatkul()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM mata_kuliah", connct)
        dt = New DataTable
        da.Fill(dt)
        CB_MatKul.DataSource = dt
        CB_MatKul.DisplayMember = "nama_matkul"
        CB_MatKul.ValueMember = "id_matkul"
        CB_MatKul.Text = ""
    End Sub

    Sub panggildata_nilai_CBnip()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM dosen", connct)
        dt = New DataTable
        da.Fill(dt)
        CB_NIP.DataSource = dt
        CB_NIP.DisplayMember = "nama_dosen"
        CB_NIP.ValueMember = "nip"
        CB_NIP.Text = ""
    End Sub
    Private Sub FormNilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildata_nilai()
        panggildata_nilai_CBnim()
        panggildata_nilai_CBmatkul()
        panggildata_nilai_CBnip()

        TextBox_Id.Select()

        DGV_Nilai.Columns(0).Visible = False
    End Sub

    Private Sub Button_Simpan_Click(sender As Object, e As EventArgs) Handles Button_Simpan.Click
        koneksi()

        If TextBox_Nilai.Text < 0 Or TextBox_Nilai.Text > 100 Then
            MessageBox.Show("Nilai Antara 0 - 100", "Peringatan!", MessageBoxButtons.OK)
        Else
            cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO nilai VALUES
                                                     ('" & TextBox_Id.Text & "',
                                                      '" & CB_NIM.SelectedValue & "',
                                                      '" & CB_MatKul.SelectedValue & "',
                                                      '" & CB_JnsNilai.Text & "',
                                                      '" & CB_NIP.SelectedValue & "',
                                                      '" & TextBox_Nilai.Text & "')", connct)

            cmd.ExecuteNonQuery()
            panggildata_nilai()
        End If

        TextBox_Id.Text = ""
        CB_NIM.Text = ""
        CB_MatKul.Text = ""
        CB_JnsNilai.Text = ""
        CB_NIP.Text = ""
        TextBox_Nilai.Text = ""
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        koneksi()

        If TextBox_Nilai.Text < 0 Or TextBox_Nilai.Text > 100 Then
            MessageBox.Show("Nilai Antara 0 - 100", "Peringatan!", MessageBoxButtons.OK)
        Else
            cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE nilai SET
                                                      id ='" & TextBox_Id.Text & "',
                                                      nim ='" & CB_NIM.SelectedValue & "',
                                                      id_matkul ='" & CB_MatKul.SelectedValue & "',
                                                      jenis_nilai ='" & CB_JnsNilai.Text & "',
                                                      nip ='" & CB_NIP.SelectedValue & "',
                                                      nilai ='" & TextBox_Nilai.Text & "'
                                                      WHERE id = '" & TextBox_Id.Text & "'", connct)

            cmd.ExecuteNonQuery()
            panggildata_nilai()
        End If

        TextBox_Id.Text = ""
        CB_NIM.Text = ""
        CB_MatKul.Text = ""
        CB_JnsNilai.Text = ""
        CB_NIP.Text = ""
        TextBox_Nilai.Text = ""
    End Sub

    Private Sub Button_Hapus_Click(sender As Object, e As EventArgs) Handles Button_Hapus.Click
        koneksi()

        If MessageBox.Show("Yakin Hapus Data?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM nilai WHERE id ='" & TextBox_Id.Text & "'", connct)

            cmd.ExecuteNonQuery()
            panggildata_nilai()
        End If

        TextBox_Id.Text = ""
        CB_NIM.Text = ""
        CB_MatKul.Text = ""
        CB_JnsNilai.Text = ""
        CB_NIP.Text = ""
        TextBox_Nilai.Text = ""
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox_Id.Text = ""
        CB_NIM.Text = ""
        CB_MatKul.Text = ""
        CB_JnsNilai.Text = ""
        CB_NIP.Text = ""
        TextBox_Nilai.Text = ""

        TextBox_Id.Enabled = True
    End Sub

    Private Sub DGV_Nilai_Click(sender As Object, e As EventArgs) Handles DGV_Nilai.Click
        i = DGV_Nilai.CurrentRow.Index
        With DGV_Nilai.Rows.Item(i)
            TextBox_Id.Text = .Cells(0).Value
            CB_NIM.Text = .Cells(2).Value
            CB_MatKul.Text = .Cells(3).Value
            CB_JnsNilai.Text = .Cells(4).Value
            CB_NIP.Text = .Cells(6).Value
            TextBox_Nilai.Text = .Cells(7).Value
        End With

        TextBox_Id.Enabled = False
    End Sub

    Private Sub TextBox_Pencarian_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Pencarian.TextChanged
        koneksi()

        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT nilai.id, mahasiswa.nim, mahasiswa.nama, mata_kuliah.nama_matkul, nilai.jenis_nilai, dosen.nip, dosen.nama_dosen, nilai.nilai
                                                          FROM nilai
                                                          INNER join mahasiswa
                                                          ON mahasiswa.nim = nilai.nim
                                                          INNER JOIN mata_kuliah
                                                          ON mata_kuliah.id_matkul = nilai.id_matkul
                                                          INNER JOIN dosen
                                                          ON dosen.nip = nilai.nip 
                                                          WHERE mahasiswa.nim LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                          mahasiswa.nama LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                          mata_kuliah.nama_matkul LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                          nilai.jenis_nilai LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                          dosen.nip LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                          dosen.nama_dosen LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                          nilai.nilai LIKE '%" & TextBox_Pencarian.Text & "%'", connct)

        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_Nilai.DataSource = dt
            DGV_Nilai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_Nilai.Columns(0).HeaderText = "Id"
            DGV_Nilai.Columns(1).HeaderText = "NIM"
            DGV_Nilai.Columns(2).HeaderText = "Nama"
            DGV_Nilai.Columns(3).HeaderText = "Mata Kuliah"
            DGV_Nilai.Columns(4).HeaderText = "Jenis Nilai"
            DGV_Nilai.Columns(5).HeaderText = "NIP"
            DGV_Nilai.Columns(6).HeaderText = "Nama Dosen"
            DGV_Nilai.Columns(7).HeaderText = "Nilai"
        Else
            DGV_Nilai.DataSource = Nothing
        End If
    End Sub
End Class