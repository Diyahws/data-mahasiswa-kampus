Public Class Form1
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        If MessageBox.Show("Yakin untuk Keluar?", "Peringatan!", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub DataKelasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKelasToolStripMenuItem.Click
        FormDosen.ShowDialog()
    End Sub
    Private Sub DataMahasiswaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataMahasiswaToolStripMenuItem.Click
        FormMahasiswa.ShowDialog()
    End Sub

    Private Sub DataDosenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataDosenToolStripMenuItem.Click
        FormKelas.ShowDialog()
    End Sub

    Private Sub MataKuliahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MataKuliahToolStripMenuItem.Click
        FormMatKul.ShowDialog()
    End Sub

    Private Sub NilaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NilaiToolStripMenuItem.Click
        FormNilai.ShowDialog()
    End Sub

    Private Sub DataAkunToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataAkunToolStripMenuItem.Click
        FormAkun.ShowDialog()
    End Sub
End Class
