<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMatKul
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
        Me.DGV_MatKul = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_MatKul = New System.Windows.Forms.TextBox()
        Me.TextBox_SKS = New System.Windows.Forms.TextBox()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Hapus = New System.Windows.Forms.Button()
        Me.Button_Simpan = New System.Windows.Forms.Button()
        Me.TextBox_IdMatKul = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox_Dosen = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox_Pencarian = New System.Windows.Forms.TextBox()
        CType(Me.DGV_MatKul, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV_MatKul
        '
        Me.DGV_MatKul.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_MatKul.Location = New System.Drawing.Point(389, 142)
        Me.DGV_MatKul.Name = "DGV_MatKul"
        Me.DGV_MatKul.Size = New System.Drawing.Size(399, 296)
        Me.DGV_MatKul.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(332, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MATA KULIAH"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(19, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mata Kuliah"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "SKS"
        '
        'TextBox_MatKul
        '
        Me.TextBox_MatKul.Location = New System.Drawing.Point(99, 58)
        Me.TextBox_MatKul.Name = "TextBox_MatKul"
        Me.TextBox_MatKul.Size = New System.Drawing.Size(170, 20)
        Me.TextBox_MatKul.TabIndex = 4
        '
        'TextBox_SKS
        '
        Me.TextBox_SKS.Location = New System.Drawing.Point(99, 84)
        Me.TextBox_SKS.Name = "TextBox_SKS"
        Me.TextBox_SKS.Size = New System.Drawing.Size(52, 20)
        Me.TextBox_SKS.TabIndex = 5
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(280, 307)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 48
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.Location = New System.Drawing.Point(118, 307)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit.TabIndex = 47
        Me.Button_Edit.Text = "Edit"
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Hapus
        '
        Me.Button_Hapus.Location = New System.Drawing.Point(199, 307)
        Me.Button_Hapus.Name = "Button_Hapus"
        Me.Button_Hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_Hapus.TabIndex = 46
        Me.Button_Hapus.Text = "Hapus"
        Me.Button_Hapus.UseVisualStyleBackColor = True
        '
        'Button_Simpan
        '
        Me.Button_Simpan.Location = New System.Drawing.Point(37, 307)
        Me.Button_Simpan.Name = "Button_Simpan"
        Me.Button_Simpan.Size = New System.Drawing.Size(75, 23)
        Me.Button_Simpan.TabIndex = 45
        Me.Button_Simpan.Text = "Simpan"
        Me.Button_Simpan.UseVisualStyleBackColor = True
        '
        'TextBox_IdMatKul
        '
        Me.TextBox_IdMatKul.Location = New System.Drawing.Point(99, 32)
        Me.TextBox_IdMatKul.Name = "TextBox_IdMatKul"
        Me.TextBox_IdMatKul.Size = New System.Drawing.Size(52, 20)
        Me.TextBox_IdMatKul.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Id "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Dosen"
        '
        'ComboBox_Dosen
        '
        Me.ComboBox_Dosen.FormattingEnabled = True
        Me.ComboBox_Dosen.Location = New System.Drawing.Point(99, 111)
        Me.ComboBox_Dosen.Name = "ComboBox_Dosen"
        Me.ComboBox_Dosen.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Dosen.TabIndex = 52
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox_Dosen)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox_MatKul)
        Me.GroupBox1.Controls.Add(Me.TextBox_IdMatKul)
        Me.GroupBox1.Controls.Add(Me.TextBox_SKS)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 159)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(549, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "Pencarian"
        '
        'TextBox_Pencarian
        '
        Me.TextBox_Pencarian.Location = New System.Drawing.Point(610, 105)
        Me.TextBox_Pencarian.Name = "TextBox_Pencarian"
        Me.TextBox_Pencarian.Size = New System.Drawing.Size(178, 20)
        Me.TextBox_Pencarian.TabIndex = 55
        '
        'FormMatKul
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox_Pencarian)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.Button_Hapus)
        Me.Controls.Add(Me.Button_Simpan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGV_MatKul)
        Me.Name = "FormMatKul"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormMatKul"
        CType(Me.DGV_MatKul, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_MatKul As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_MatKul As TextBox
    Friend WithEvents TextBox_SKS As TextBox
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Hapus As Button
    Friend WithEvents Button_Simpan As Button
    Friend WithEvents TextBox_IdMatKul As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox_Dosen As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox_Pencarian As TextBox
End Class
