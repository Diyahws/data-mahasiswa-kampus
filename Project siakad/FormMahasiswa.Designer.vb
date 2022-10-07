<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMahasiswa
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
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Hapus = New System.Windows.Forms.Button()
        Me.DGV_Mahasiswa = New System.Windows.Forms.DataGridView()
        Me.Button_Simpan = New System.Windows.Forms.Button()
        Me.ComboBox_Kelas = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RichTextBox_Alamat = New System.Windows.Forms.RichTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox_JnsKlmn = New System.Windows.Forms.ComboBox()
        Me.TextBox_TmptLahir = New System.Windows.Forms.TextBox()
        Me.TextBox_Nama = New System.Windows.Forms.TextBox()
        Me.TextBox_NIM = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_Pencarian = New System.Windows.Forms.TextBox()
        CType(Me.DGV_Mahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(301, 315)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 40
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.Location = New System.Drawing.Point(139, 315)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit.TabIndex = 39
        Me.Button_Edit.Text = "Edit"
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Hapus
        '
        Me.Button_Hapus.Location = New System.Drawing.Point(220, 315)
        Me.Button_Hapus.Name = "Button_Hapus"
        Me.Button_Hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_Hapus.TabIndex = 38
        Me.Button_Hapus.Text = "Hapus"
        Me.Button_Hapus.UseVisualStyleBackColor = True
        '
        'DGV_Mahasiswa
        '
        Me.DGV_Mahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Mahasiswa.Location = New System.Drawing.Point(12, 357)
        Me.DGV_Mahasiswa.Name = "DGV_Mahasiswa"
        Me.DGV_Mahasiswa.Size = New System.Drawing.Size(748, 283)
        Me.DGV_Mahasiswa.TabIndex = 37
        '
        'Button_Simpan
        '
        Me.Button_Simpan.Location = New System.Drawing.Point(58, 315)
        Me.Button_Simpan.Name = "Button_Simpan"
        Me.Button_Simpan.Size = New System.Drawing.Size(75, 23)
        Me.Button_Simpan.TabIndex = 36
        Me.Button_Simpan.Text = "Simpan"
        Me.Button_Simpan.UseVisualStyleBackColor = True
        '
        'ComboBox_Kelas
        '
        Me.ComboBox_Kelas.FormattingEnabled = True
        Me.ComboBox_Kelas.Location = New System.Drawing.Point(99, 208)
        Me.ComboBox_Kelas.Name = "ComboBox_Kelas"
        Me.ComboBox_Kelas.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Kelas.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 211)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Kelas"
        '
        'RichTextBox_Alamat
        '
        Me.RichTextBox_Alamat.Location = New System.Drawing.Point(99, 153)
        Me.RichTextBox_Alamat.Name = "RichTextBox_Alamat"
        Me.RichTextBox_Alamat.Size = New System.Drawing.Size(243, 49)
        Me.RichTextBox_Alamat.TabIndex = 33
        Me.RichTextBox_Alamat.Text = ""
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(99, 127)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(132, 20)
        Me.DateTimePicker1.TabIndex = 32
        '
        'ComboBox_JnsKlmn
        '
        Me.ComboBox_JnsKlmn.FormattingEnabled = True
        Me.ComboBox_JnsKlmn.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.ComboBox_JnsKlmn.Location = New System.Drawing.Point(99, 74)
        Me.ComboBox_JnsKlmn.Name = "ComboBox_JnsKlmn"
        Me.ComboBox_JnsKlmn.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_JnsKlmn.TabIndex = 31
        '
        'TextBox_TmptLahir
        '
        Me.TextBox_TmptLahir.Location = New System.Drawing.Point(99, 101)
        Me.TextBox_TmptLahir.Name = "TextBox_TmptLahir"
        Me.TextBox_TmptLahir.Size = New System.Drawing.Size(132, 20)
        Me.TextBox_TmptLahir.TabIndex = 30
        '
        'TextBox_Nama
        '
        Me.TextBox_Nama.Location = New System.Drawing.Point(99, 48)
        Me.TextBox_Nama.Name = "TextBox_Nama"
        Me.TextBox_Nama.Size = New System.Drawing.Size(243, 20)
        Me.TextBox_Nama.TabIndex = 29
        '
        'TextBox_NIM
        '
        Me.TextBox_NIM.Location = New System.Drawing.Point(99, 22)
        Me.TextBox_NIM.Name = "TextBox_NIM"
        Me.TextBox_NIM.Size = New System.Drawing.Size(142, 20)
        Me.TextBox_NIM.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Tempat Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "NIM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "DATA MAHASISWA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RichTextBox_Alamat)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Kelas)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox_NIM)
        Me.GroupBox1.Controls.Add(Me.TextBox_Nama)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TextBox_TmptLahir)
        Me.GroupBox1.Controls.Add(Me.ComboBox_JnsKlmn)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(375, 244)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(521, 325)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Pencarian"
        '
        'TextBox_Pencarian
        '
        Me.TextBox_Pencarian.Location = New System.Drawing.Point(582, 322)
        Me.TextBox_Pencarian.Name = "TextBox_Pencarian"
        Me.TextBox_Pencarian.Size = New System.Drawing.Size(178, 20)
        Me.TextBox_Pencarian.TabIndex = 43
        '
        'FormMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 652)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox_Pencarian)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.Button_Hapus)
        Me.Controls.Add(Me.DGV_Mahasiswa)
        Me.Controls.Add(Me.Button_Simpan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormMahasiswa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMahasiswa"
        CType(Me.DGV_Mahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Clear As Button
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Hapus As Button
    Friend WithEvents DGV_Mahasiswa As DataGridView
    Friend WithEvents Button_Simpan As Button
    Friend WithEvents ComboBox_Kelas As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RichTextBox_Alamat As RichTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox_JnsKlmn As ComboBox
    Friend WithEvents TextBox_TmptLahir As TextBox
    Friend WithEvents TextBox_Nama As TextBox
    Friend WithEvents TextBox_NIM As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox_Pencarian As TextBox
End Class
