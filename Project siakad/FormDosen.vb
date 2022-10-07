Public Class FormDosen
    Sub panggildata_dosen()
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM dosen", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_Dosen.DataSource = dt
            DGV_Dosen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_Dosen.Columns(0).HeaderText = "NIP"
            DGV_Dosen.Columns(1).HeaderText = "Nama Dosen"
        Else
            DGV_Dosen.DataSource = Nothing
        End If
    End Sub

    Private Sub FormDosen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panggildata_dosen()

        TextBox_NIP.Select()
    End Sub

    Private Sub Button_Simpan_Click(sender As Object, e As EventArgs) Handles Button_Simpan.Click
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO dosen VALUES ('" & TextBox_NIP.Text & "', '" & TextBox_NmDosen.Text & "')", connct)

        cmd.ExecuteNonQuery()
        panggildata_dosen()

        TextBox_NIP.Text = ""
        TextBox_NmDosen.Text = ""
    End Sub

    Private Sub Button_Edit_Click(sender As Object, e As EventArgs) Handles Button_Edit.Click
        koneksi()
        cmd = New MySql.Data.MySqlClient.MySqlCommand("UPDATE dosen SET nip ='" & TextBox_NIP.Text & "', nama_dosen ='" & TextBox_NmDosen.Text & "'
                                                       WHERE nip ='" & TextBox_NIP.Text & "'", connct)

        cmd.ExecuteNonQuery()
        panggildata_dosen()

        TextBox_NIP.Text = ""
        TextBox_NmDosen.Text = ""
    End Sub

    Private Sub Button_Hapus_Click(sender As Object, e As EventArgs) Handles Button_Hapus.Click
        koneksi()

        If MessageBox.Show("Yakin Hapus Data?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            cmd = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM dosen WHERE nip='" & TextBox_NIP.Text & "'", connct)

            cmd.ExecuteNonQuery()
            panggildata_dosen()
        End If

        TextBox_NIP.Text = ""
        TextBox_NmDosen.Text = ""
    End Sub

    Private Sub Button_Clear_Click(sender As Object, e As EventArgs) Handles Button_Clear.Click
        TextBox_NIP.Text = ""
        TextBox_NmDosen.Text = ""

        TextBox_NIP.Enabled = True
    End Sub

    Private Sub DGV_dosen_Click(sender As Object, e As EventArgs) Handles DGV_Dosen.Click
        i = DGV_Dosen.CurrentRow.Index
        With DGV_Dosen.Rows.Item(i)
            TextBox_NIP.Text = .Cells(0).Value
            TextBox_NmDosen.Text = .Cells(1).Value
        End With

        TextBox_NIP.Enabled = False
    End Sub

    Private Sub TextBox_Pencarian_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Pencarian.TextChanged
        koneksi()
        da = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM dosen
                                                          WHERE nip LIKE '%" & TextBox_Pencarian.Text & "%' OR
                                                          nama_dosen LIKE '%" & TextBox_Pencarian.Text & "%'
                                                          ORDER BY nama_dosen ASC", connct)
        dt = New DataTable
        data = da.Fill(dt)

        If data > 0 Then
            DGV_Dosen.DataSource = dt
            DGV_Dosen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill
            DGV_Dosen.Columns(0).HeaderText = "NIP"
            DGV_Dosen.Columns(1).HeaderText = "Nama Dosen"
        Else
            DGV_Dosen.DataSource = Nothing
        End If
    End Sub
End Class