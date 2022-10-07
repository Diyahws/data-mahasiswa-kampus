<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DataMahasiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataKelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataDosenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MataKuliahToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NilaiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataAkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataMahasiswaToolStripMenuItem, Me.DataKelasToolStripMenuItem, Me.DataDosenToolStripMenuItem, Me.MataKuliahToolStripMenuItem, Me.NilaiToolStripMenuItem, Me.DataAkunToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1041, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DataMahasiswaToolStripMenuItem
        '
        Me.DataMahasiswaToolStripMenuItem.Name = "DataMahasiswaToolStripMenuItem"
        Me.DataMahasiswaToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.DataMahasiswaToolStripMenuItem.Text = "Data Mahasiswa"
        '
        'DataKelasToolStripMenuItem
        '
        Me.DataKelasToolStripMenuItem.Name = "DataKelasToolStripMenuItem"
        Me.DataKelasToolStripMenuItem.Size = New System.Drawing.Size(101, 24)
        Me.DataKelasToolStripMenuItem.Text = "Data Dosen"
        '
        'DataDosenToolStripMenuItem
        '
        Me.DataDosenToolStripMenuItem.Name = "DataDosenToolStripMenuItem"
        Me.DataDosenToolStripMenuItem.Size = New System.Drawing.Size(94, 24)
        Me.DataDosenToolStripMenuItem.Text = "Data Kelas"
        '
        'MataKuliahToolStripMenuItem
        '
        Me.MataKuliahToolStripMenuItem.Name = "MataKuliahToolStripMenuItem"
        Me.MataKuliahToolStripMenuItem.Size = New System.Drawing.Size(102, 24)
        Me.MataKuliahToolStripMenuItem.Text = "Mata Kuliah"
        '
        'NilaiToolStripMenuItem
        '
        Me.NilaiToolStripMenuItem.Name = "NilaiToolStripMenuItem"
        Me.NilaiToolStripMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.NilaiToolStripMenuItem.Text = "Nilai"
        '
        'DataAkunToolStripMenuItem
        '
        Me.DataAkunToolStripMenuItem.Name = "DataAkunToolStripMenuItem"
        Me.DataAkunToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.DataAkunToolStripMenuItem.Text = "Data User"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 507)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(159, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SIAKAD ver. 1.0.1"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(0, 527)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(157, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Build App. 11 Apri 2022"
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Image = Global.Project_siakad.My.Resources.Resources.kisspng_logo_font_calligraphy_brand_illustration_openclipart_5c4c34a570d9e5_0224913615484980854623
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1041, 554)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 554)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataMahasiswaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataKelasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataDosenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MataKuliahToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NilaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataAkunToolStripMenuItem As ToolStripMenuItem
End Class
