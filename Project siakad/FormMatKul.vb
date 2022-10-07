Public Class FormMatKul
    Sub panggildata_matkul()
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT id_matkul, nama_matkul, sks, nama_dosen FROM mata_kuliah
                                                          INNER JOIN dosen ON dosen.nip = mata_kuliah.dosen_nip", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_MatKul.DataSource = dt
            DGV_MatKul.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_MatKul.Columns(0).HeaderText = "Id"
            DGV_MatKul.Columns(1).HeaderText = "Mata Kuliah"
            DGV_MatKul.Columns(2).HeaderText = "SKS"
            DGV_MatKul.Columns(3).HeaderText = "Dosen"
        Else
            DGV_MatKul.DataSource = Nothing
        End If
    End Sub
    Sub panggildata_matkul_CBdosen()
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM dosen", connct)
        dt = New DataTable
        da.Fill(dt)
        ComboBox_Dosen.DataSource = dt
        ComboBox_Dosen.DisplayMember = "nama_dosen"
        ComboBox_Dosen.ValueMember = "nip"
        ComboBox_Dosen.Text = ""
    End Sub
    Private Sub FormMatKul_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildata_matkul()
        panggildata_matkul_CBdosen()

        TextBox_IdMatKul.Select()
        TextBox_SKS.MaxLength = 1

        DGV_MatKul.Columns(0).Visible = False
    End Sub

    Private Sub Button_Simpan_Click(sender As Object, e As EventArgs) Handles Button_Simpan.Click
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO mata_kuliah VALUES 
                                                     ('" & TextBox_IdMatKul.Text & "', 
                                                      '" & TextBox_MatKul.Text & "', 
                                                      '" & TextBox_SKS.Text & "',
                                                      '" & ComboBox_Dosen.SelectedValue & "')", connct)

        cmd.ExecuteNonQuery()
        panggildata_matkul()

        TextBox_IdMatKul.Text = ""
        TextBox_MatKul.Text = ""
        TextBox_SKS.Text = ""
        ComboBox_Dosen.Text = ""
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE mata_kuliah SET 
                                                      id_matkul = '" & TextBox_IdMatKul.Text & "',
                                                      nama_matkul ='" & TextBox_MatKul.Text & "', 
                                                      sks ='" & TextBox_SKS.Text & "',
                                                      dosen_nip ='" & ComboBox_Dosen.SelectedValue & "'
                                                      WHERE id_matkul ='" & TextBox_IdMatKul.Text & "'", connct)

        cmd.ExecuteNonQuery()
        panggildata_matkul()

        TextBox_IdMatKul.Text = ""
        TextBox_MatKul.Text = ""
        TextBox_SKS.Text = ""
        ComboBox_Dosen.Text = ""
    End Sub

    Private Sub Button_Hapus_Click(sender As Object, e As EventArgs) Handles Button_Hapus.Click
        koneksi()

        If MessageBox.Show("Yakin Hapus Data?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM mata_kuliah WHERE id_matkul ='" & TextBox_IdMatKul.Text & "'", connct)

            cmd.ExecuteNonQuery()
            panggildata_matkul()
        End If

        TextBox_IdMatKul.Text = ""
        TextBox_MatKul.Text = ""
        TextBox_SKS.Text = ""
        ComboBox_Dosen.Text = ""
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox_IdMatKul.Text = ""
        TextBox_MatKul.Text = ""
        TextBox_SKS.Text = ""
        ComboBox_Dosen.Text = ""

        TextBox_IdMatKul.Enabled = True
    End Sub

    Private Sub DGV_MatKul_Click(sender As Object, e As EventArgs) Handles DGV_MatKul.Click
        i = DGV_MatKul.CurrentRow.Index
        With DGV_MatKul.Rows.Item(i)
            TextBox_IdMatKul.Text = .Cells(0).Value
            TextBox_MatKul.Text = .Cells(1).Value
            TextBox_SKS.Text = .Cells(2).Value
            ComboBox_Dosen.Text = .Cells(3).Value
        End With

        TextBox_IdMatKul.Enabled = False
    End Sub

    Private Sub TextBox_Pencarian_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Pencarian.TextChanged
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT id_matkul, nama_matkul, sks, nama_dosen FROM mata_kuliah
                                                          INNER JOIN dosen ON dosen.nip = mata_kuliah.dosen_nip
                                                          WHERE nama_matkul LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                          sks LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                          nama_dosen LIKE '%" & TextBox_Pencarian.Text & "%'", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_MatKul.DataSource = dt
            DGV_MatKul.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_MatKul.Columns(0).HeaderText = "Id"
            DGV_MatKul.Columns(1).HeaderText = "Mata Kuliah"
            DGV_MatKul.Columns(2).HeaderText = "SKS"
            DGV_MatKul.Columns(3).HeaderText = "Dosen"
        Else
            DGV_MatKul.DataSource = Nothing
        End If
    End Sub
End Class