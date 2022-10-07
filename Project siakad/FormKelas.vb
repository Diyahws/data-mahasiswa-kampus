Public Class FormKelas
    Sub panggildata_kelas()
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT id, nama_kelas, nip, nama_dosen FROM kelas
                                                          INNER JOIN dosen ON dosen.nip = kelas.dosen_nip", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_Kelas.DataSource = dt
            DGV_Kelas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_Kelas.Columns(0).HeaderText = "Id"
            DGV_Kelas.Columns(1).HeaderText = "Nama Kelas"
            DGV_Kelas.Columns(2).HeaderText = "NIP"
            DGV_Kelas.Columns(3).HeaderText = "Wali Kelas"
        Else
            DGV_Kelas.DataSource = Nothing
        End If
    End Sub
    Sub panggildata_kelas_combobox()
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM dosen", connct)
        dt = New DataTable
        da.Fill(dt)
        ComboBox_WaliKls.DataSource = dt
        ComboBox_WaliKls.DisplayMember = "nama_dosen"
        ComboBox_WaliKls.ValueMember = "nip"
        ComboBox_WaliKls.Text = ""
    End Sub
    Private Sub FormKelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildata_kelas()
        panggildata_kelas_combobox()

        TextBox_Id.Select()

        DGV_Kelas.Columns(0).Visible = False
    End Sub

    Private Sub Button_Simpan_Click(sender As Object, e As EventArgs) Handles Button_Simpan.Click
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO kelas VALUES 
                                                     ('" & TextBox_Id.Text & "','" & TextBox_NmKelas.Text & "', '" & ComboBox_WaliKls.SelectedValue & "')", connct)

        cmd.ExecuteNonQuery()
        panggildata_kelas()

        TextBox_Id.Text = ""
        TextBox_NmKelas.Text = ""
        ComboBox_WaliKls.Text = ""
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        koneksi()

        cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE kelas SET id ='" & TextBox_Id.Text & "', 
                                                       nama_kelas ='" & TextBox_NmKelas.Text & "', 
                                                       dosen_nip ='" & ComboBox_WaliKls.SelectedValue & "'
                                                       WHERE id ='" & TextBox_Id.Text & "'", connct)

        cmd.ExecuteNonQuery()
        panggildata_kelas()

        TextBox_Id.Text = ""
        TextBox_NmKelas.Text = ""
        ComboBox_WaliKls.Text = ""
    End Sub

    Private Sub Button_Hapus_Click(sender As Object, e As EventArgs) Handles Button_Hapus.Click
        koneksi()

        If MessageBox.Show("Yakin Hapus Data?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM kelas WHERE id ='" & TextBox_Id.Text & "'", connct)

            cmd.ExecuteNonQuery()
            panggildata_kelas()
        End If

        TextBox_Id.Text = ""
        TextBox_NmKelas.Text = ""
        ComboBox_WaliKls.Text = ""
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox_Id.Text = ""
        TextBox_NmKelas.Text = ""
        ComboBox_WaliKls.Text = ""

        TextBox_Id.Enabled = True
    End Sub

    Private Sub DGV_Kelas_Click(sender As Object, e As EventArgs) Handles DGV_Kelas.Click
        i = DGV_Kelas.CurrentRow.Index
        With DGV_Kelas.Rows.Item(i)
            TextBox_Id.Text = .Cells(0).Value
            TextBox_NmKelas.Text = .Cells(1).Value
            ComboBox_WaliKls.Text = .Cells(3).Value
        End With

        TextBox_Id.Enabled = False
    End Sub

    Private Sub TextBox_Pencarian_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Pencarian.TextChanged
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT id, nama_kelas, nip, nama_dosen FROM kelas
                                                          INNER JOIN dosen ON dosen.nip = kelas.dosen_nip
                                                          WHERE nama_kelas LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                          nip LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                          nama_dosen LIKE '%" & TextBox_Pencarian.Text & "%'", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_Kelas.DataSource = dt
            DGV_Kelas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_Kelas.Columns(0).HeaderText = "Id"
            DGV_Kelas.Columns(1).HeaderText = "Nama Kelas"
            DGV_Kelas.Columns(2).HeaderText = "NIP"
            DGV_Kelas.Columns(3).HeaderText = "Wali Kelas"
        Else
            DGV_Kelas.DataSource = Nothing
        End If
    End Sub
End Class
