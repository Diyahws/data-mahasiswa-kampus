<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKelas
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_NmKelas = New System.Windows.Forms.TextBox()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Hapus = New System.Windows.Forms.Button()
        Me.Button_Simpan = New System.Windows.Forms.Button()
        Me.DGV_Kelas = New System.Windows.Forms.DataGridView()
        Me.ComboBox_WaliKls = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox_Id = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox_Pencarian = New System.Windows.Forms.TextBox()
        CType(Me.DGV_Kelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "DATA KELAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Kelas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Wali Kelas"
        '
        'TextBox_NmKelas
        '
        Me.TextBox_NmKelas.Location = New System.Drawing.Point(109, 63)
        Me.TextBox_NmKelas.Name = "TextBox_NmKelas"
        Me.TextBox_NmKelas.Size = New System.Drawing.Size(189, 20)
        Me.TextBox_NmKelas.TabIndex = 5
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(281, 286)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 48
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.Location = New System.Drawing.Point(119, 286)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit.TabIndex = 47
        Me.Button_Edit.Text = "Edit"
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Hapus
        '
        Me.Button_Hapus.Location = New System.Drawing.Point(200, 286)
        Me.Button_Hapus.Name = "Button_Hapus"
        Me.Button_Hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_Hapus.TabIndex = 46
        Me.Button_Hapus.Text = "Hapus"
        Me.Button_Hapus.UseVisualStyleBackColor = True
        '
        'Button_Simpan
        '
        Me.Button_Simpan.Location = New System.Drawing.Point(38, 286)
        Me.Button_Simpan.Name = "Button_Simpan"
        Me.Button_Simpan.Size = New System.Drawing.Size(75, 23)
        Me.Button_Simpan.TabIndex = 45
        Me.Button_Simpan.Text = "Simpan"
        Me.Button_Simpan.UseVisualStyleBackColor = True
        '
        'DGV_Kelas
        '
        Me.DGV_Kelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Kelas.Location = New System.Drawing.Point(414, 140)
        Me.DGV_Kelas.Name = "DGV_Kelas"
        Me.DGV_Kelas.Size = New System.Drawing.Size(374, 294)
        Me.DGV_Kelas.TabIndex = 49
        '
        'ComboBox_WaliKls
        '
        Me.ComboBox_WaliKls.FormattingEnabled = True
        Me.ComboBox_WaliKls.Location = New System.Drawing.Point(109, 90)
        Me.ComboBox_WaliKls.Name = "ComboBox_WaliKls"
        Me.ComboBox_WaliKls.Size = New System.Drawing.Size(150, 21)
        Me.ComboBox_WaliKls.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Id"
        '
        'TextBox_Id
        '
        Me.TextBox_Id.Location = New System.Drawing.Point(109, 37)
        Me.TextBox_Id.Name = "TextBox_Id"
        Me.TextBox_Id.Size = New System.Drawing.Size(110, 20)
        Me.TextBox_Id.TabIndex = 52
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox_WaliKls)
        Me.GroupBox1.Controls.Add(Me.TextBox_Id)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox_NmKelas)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 140)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(413, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Pencarian"
        '
        'TextBox_Pencarian
        '
        Me.TextBox_Pencarian.Location = New System.Drawing.Point(474, 103)
        Me.TextBox_Pencarian.Name = "TextBox_Pencarian"
        Me.TextBox_Pencarian.Size = New System.Drawing.Size(178, 20)
        Me.TextBox_Pencarian.TabIndex = 55
        '
        'FormKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox_Pencarian)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DGV_Kelas)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.Button_Hapus)
        Me.Controls.Add(Me.Button_Simpan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormKelas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormKelas"
        CType(Me.DGV_Kelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_NmKelas As TextBox
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Hapus As Button
    Friend WithEvents Button_Simpan As Button
    Friend WithEvents DGV_Kelas As DataGridView
    Friend WithEvents ComboBox_WaliKls As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_Id As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox_Pencarian As TextBox
End Class
