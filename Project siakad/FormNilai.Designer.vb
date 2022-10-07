<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNilai
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGV_Nilai = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_Nilai = New System.Windows.Forms.TextBox()
        Me.CB_NIP = New System.Windows.Forms.ComboBox()
        Me.CB_JnsNilai = New System.Windows.Forms.ComboBox()
        Me.CB_MatKul = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox_Id = New System.Windows.Forms.TextBox()
        Me.CB_NIM = New System.Windows.Forms.ComboBox()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Hapus = New System.Windows.Forms.Button()
        Me.Button_Simpan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_Pencarian = New System.Windows.Forms.TextBox()
        CType(Me.DGV_Nilai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_Nilai
        '
        Me.DGV_Nilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Nilai.Location = New System.Drawing.Point(12, 331)
        Me.DGV_Nilai.Name = "DGV_Nilai"
        Me.DGV_Nilai.Size = New System.Drawing.Size(752, 314)
        Me.DGV_Nilai.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DATA NILAI"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Mata Kuliah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Jenis Nilai"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Dosen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Nilai"
        '
        'TextBox_Nilai
        '
        Me.TextBox_Nilai.Location = New System.Drawing.Point(111, 163)
        Me.TextBox_Nilai.Name = "TextBox_Nilai"
        Me.TextBox_Nilai.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Nilai.TabIndex = 7
        '
        'CB_NIP
        '
        Me.CB_NIP.FormattingEnabled = True
        Me.CB_NIP.Location = New System.Drawing.Point(111, 136)
        Me.CB_NIP.Name = "CB_NIP"
        Me.CB_NIP.Size = New System.Drawing.Size(186, 21)
        Me.CB_NIP.TabIndex = 8
        '
        'CB_JnsNilai
        '
        Me.CB_JnsNilai.FormattingEnabled = True
        Me.CB_JnsNilai.Items.AddRange(New Object() {"Quiz", "UTS", "UAS"})
        Me.CB_JnsNilai.Location = New System.Drawing.Point(111, 109)
        Me.CB_JnsNilai.Name = "CB_JnsNilai"
        Me.CB_JnsNilai.Size = New System.Drawing.Size(121, 21)
        Me.CB_JnsNilai.TabIndex = 9
        '
        'CB_MatKul
        '
        Me.CB_MatKul.FormattingEnabled = True
        Me.CB_MatKul.Location = New System.Drawing.Point(111, 82)
        Me.CB_MatKul.Name = "CB_MatKul"
        Me.CB_MatKul.Size = New System.Drawing.Size(132, 21)
        Me.CB_MatKul.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Id"
        '
        'TextBox_Id
        '
        Me.TextBox_Id.Location = New System.Drawing.Point(111, 29)
        Me.TextBox_Id.Name = "TextBox_Id"
        Me.TextBox_Id.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_Id.TabIndex = 12
        '
        'CB_NIM
        '
        Me.CB_NIM.FormattingEnabled = True
        Me.CB_NIM.Location = New System.Drawing.Point(111, 55)
        Me.CB_NIM.Name = "CB_NIM"
        Me.CB_NIM.Size = New System.Drawing.Size(186, 21)
        Me.CB_NIM.TabIndex = 13
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(283, 288)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 52
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.Location = New System.Drawing.Point(121, 288)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit.TabIndex = 51
        Me.Button_Edit.Text = "Edit"
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Hapus
        '
        Me.Button_Hapus.Location = New System.Drawing.Point(202, 288)
        Me.Button_Hapus.Name = "Button_Hapus"
        Me.Button_Hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_Hapus.TabIndex = 50
        Me.Button_Hapus.Text = "Hapus"
        Me.Button_Hapus.UseVisualStyleBackColor = True
        '
        'Button_Simpan
        '
        Me.Button_Simpan.Location = New System.Drawing.Point(40, 288)
        Me.Button_Simpan.Name = "Button_Simpan"
        Me.Button_Simpan.Size = New System.Drawing.Size(75, 23)
        Me.Button_Simpan.TabIndex = 49
        Me.Button_Simpan.Text = "Simpan"
        Me.Button_Simpan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_Nilai)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CB_NIM)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox_Id)
        Me.GroupBox1.Controls.Add(Me.CB_NIP)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CB_JnsNilai)
        Me.GroupBox1.Controls.Add(Me.CB_MatKul)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 204)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(525, 298)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Pencarian"
        '
        'TextBox_Pencarian
        '
        Me.TextBox_Pencarian.Location = New System.Drawing.Point(586, 295)
        Me.TextBox_Pencarian.Name = "TextBox_Pencarian"
        Me.TextBox_Pencarian.Size = New System.Drawing.Size(178, 20)
        Me.TextBox_Pencarian.TabIndex = 55
        '
        'FormNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 657)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox_Pencarian)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.Button_Hapus)
        Me.Controls.Add(Me.Button_Simpan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DGV_Nilai)
        Me.Name = "FormNilai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormNilai"
        CType(Me.DGV_Nilai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_Nilai As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_Nilai As TextBox
    Friend WithEvents CB_NIP As ComboBox
    Friend WithEvents CB_JnsNilai As ComboBox
    Friend WithEvents CB_MatKul As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox_Id As TextBox
    Friend WithEvents CB_NIM As ComboBox
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Hapus As Button
    Friend WithEvents Button_Simpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox_Pencarian As TextBox
End Class
