<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDosen
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
        Me.TextBox_NIP = New System.Windows.Forms.TextBox()
        Me.TextBox_NmDosen = New System.Windows.Forms.TextBox()
        Me.DGV_Dosen = New System.Windows.Forms.DataGridView()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.Button_Edit = New System.Windows.Forms.Button()
        Me.Button_Hapus = New System.Windows.Forms.Button()
        Me.Button_Simpan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox_Pencarian = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DGV_Dosen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA DOSEN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NIP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Dosen"
        '
        'TextBox_NIP
        '
        Me.TextBox_NIP.Location = New System.Drawing.Point(107, 43)
        Me.TextBox_NIP.Name = "TextBox_NIP"
        Me.TextBox_NIP.Size = New System.Drawing.Size(107, 20)
        Me.TextBox_NIP.TabIndex = 3
        '
        'TextBox_NmDosen
        '
        Me.TextBox_NmDosen.Location = New System.Drawing.Point(107, 69)
        Me.TextBox_NmDosen.Name = "TextBox_NmDosen"
        Me.TextBox_NmDosen.Size = New System.Drawing.Size(178, 20)
        Me.TextBox_NmDosen.TabIndex = 4
        '
        'DGV_Dosen
        '
        Me.DGV_Dosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Dosen.Location = New System.Drawing.Point(391, 131)
        Me.DGV_Dosen.Name = "DGV_Dosen"
        Me.DGV_Dosen.Size = New System.Drawing.Size(325, 288)
        Me.DGV_Dosen.TabIndex = 5
        '
        'Button_Clear
        '
        Me.Button_Clear.Location = New System.Drawing.Point(272, 262)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Button_Clear.TabIndex = 44
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'Button_Edit
        '
        Me.Button_Edit.Location = New System.Drawing.Point(110, 262)
        Me.Button_Edit.Name = "Button_Edit"
        Me.Button_Edit.Size = New System.Drawing.Size(75, 23)
        Me.Button_Edit.TabIndex = 43
        Me.Button_Edit.Text = "Edit"
        Me.Button_Edit.UseVisualStyleBackColor = True
        '
        'Button_Hapus
        '
        Me.Button_Hapus.Location = New System.Drawing.Point(191, 262)
        Me.Button_Hapus.Name = "Button_Hapus"
        Me.Button_Hapus.Size = New System.Drawing.Size(75, 23)
        Me.Button_Hapus.TabIndex = 42
        Me.Button_Hapus.Text = "Hapus"
        Me.Button_Hapus.UseVisualStyleBackColor = True
        '
        'Button_Simpan
        '
        Me.Button_Simpan.Location = New System.Drawing.Point(29, 262)
        Me.Button_Simpan.Name = "Button_Simpan"
        Me.Button_Simpan.Size = New System.Drawing.Size(75, 23)
        Me.Button_Simpan.TabIndex = 41
        Me.Button_Simpan.Text = "Simpan"
        Me.Button_Simpan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox_NmDosen)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox_NIP)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 131)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 125)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Data"
        '
        'TextBox_Pencarian
        '
        Me.TextBox_Pencarian.Location = New System.Drawing.Point(451, 91)
        Me.TextBox_Pencarian.Name = "TextBox_Pencarian"
        Me.TextBox_Pencarian.Size = New System.Drawing.Size(178, 20)
        Me.TextBox_Pencarian.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(390, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Pencarian"
        '
        'FormDosen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox_Pencarian)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Clear)
        Me.Controls.Add(Me.Button_Edit)
        Me.Controls.Add(Me.Button_Hapus)
        Me.Controls.Add(Me.Button_Simpan)
        Me.Controls.Add(Me.DGV_Dosen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDosen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormDosen"
        CType(Me.DGV_Dosen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_NIP As TextBox
    Friend WithEvents TextBox_NmDosen As TextBox
    Friend WithEvents DGV_Dosen As DataGridView
    Friend WithEvents Button_Clear As Button
    Friend WithEvents Button_Edit As Button
    Friend WithEvents Button_Hapus As Button
    Friend WithEvents Button_Simpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox_Pencarian As TextBox
    Friend WithEvents Label4 As Label
End Class
