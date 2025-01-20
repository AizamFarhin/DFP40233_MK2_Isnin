<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        lblNama = New Label()
        TextBox1 = New TextBox()
        lblNotel = New Label()
        TextBox2 = New TextBox()
        lblAlamat = New Label()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        lbNegeri = New Label()
        GroupBox1 = New GroupBox()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        lblJantina = New Label()
        GroupBox2 = New GroupBox()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        GroupBox3 = New GroupBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        DataGridView1 = New DataGridView()
        BIL = New DataGridViewTextBoxColumn()
        Nama = New DataGridViewTextBoxColumn()
        NoTel = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Elephant", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(253, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(417, 35)
        Label1.TabIndex = 0
        Label1.Text = "MAKLUMAT PELANGGAN"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(12, 90)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(56, 20)
        lblNama.TabIndex = 1
        lblNama.Text = "Nama :"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(74, 90)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(423, 27)
        TextBox1.TabIndex = 2
        ' 
        ' lblNotel
        ' 
        lblNotel.AutoSize = True
        lblNotel.Location = New Point(10, 133)
        lblNotel.Name = "lblNotel"
        lblNotel.Size = New Size(58, 20)
        lblNotel.TabIndex = 3
        lblNotel.Text = "No.Tel :"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(74, 133)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(253, 27)
        TextBox2.TabIndex = 4
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(4, 176)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(64, 20)
        lblAlamat.TabIndex = 5
        lblAlamat.Text = "Alamat :"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(74, 176)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(423, 99)
        TextBox3.TabIndex = 6
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Johor", "Kedah", "Kelantan", "Melaka", "Negeri Sembilan", "Pahang", "Perak", "Perlis", "Pulau Pinang", "Sabah", "Sarawak", "Selangor", "Terengganu", "Wilayah Persekutuan Kuala Lumpur"})
        ComboBox1.Location = New Point(74, 304)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 7
        ' 
        ' lbNegeri
        ' 
        lbNegeri.AutoSize = True
        lbNegeri.Location = New Point(4, 307)
        lbNegeri.Name = "lbNegeri"
        lbNegeri.Size = New Size(61, 20)
        lbNegeri.TabIndex = 8
        lbNegeri.Text = "Negeri :"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(74, 362)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(253, 75)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(6, 45)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(104, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.TabStop = True
        RadioButton2.Text = "Perempuan"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(6, 14)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(68, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "Lelaki"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' lblJantina
        ' 
        lblJantina.AutoSize = True
        lblJantina.Location = New Point(3, 372)
        lblJantina.Name = "lblJantina"
        lblJantina.Size = New Size(62, 20)
        lblJantina.TabIndex = 10
        lblJantina.Text = "Jantina :"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RadioButton4)
        GroupBox2.Controls.Add(RadioButton3)
        GroupBox2.Location = New Point(74, 466)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(250, 91)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Kaedah Bayaran :"
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(9, 54)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(85, 24)
        RadioButton4.TabIndex = 1
        RadioButton4.TabStop = True
        RadioButton4.Text = "Cashless"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(9, 25)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(61, 24)
        RadioButton3.TabIndex = 0
        RadioButton3.TabStop = True
        RadioButton3.Text = "Cash"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(CheckBox5)
        GroupBox3.Controls.Add(CheckBox4)
        GroupBox3.Controls.Add(CheckBox3)
        GroupBox3.Controls.Add(CheckBox2)
        GroupBox3.Controls.Add(CheckBox1)
        GroupBox3.Location = New Point(572, 90)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(250, 184)
        GroupBox3.TabIndex = 12
        GroupBox3.TabStop = False
        GroupBox3.Text = "Perisa :"
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(10, 147)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(74, 24)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Pisang"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(10, 117)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(94, 24)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Strawberi"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(10, 87)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(73, 24)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Coklat"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(10, 57)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(62, 24)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Kopi"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(10, 26)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(61, 24)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Milo"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(582, 304)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 13
        Label2.Text = "Tarikh :"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(572, 339)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 14
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {BIL, Nama, NoTel})
        DataGridView1.Location = New Point(431, 407)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(391, 82)
        DataGridView1.TabIndex = 15
        ' 
        ' BIL
        ' 
        BIL.HeaderText = "Bil"
        BIL.MinimumWidth = 6
        BIL.Name = "BIL"
        BIL.Width = 125
        ' 
        ' Nama
        ' 
        Nama.HeaderText = "Nama"
        Nama.MinimumWidth = 6
        Nama.Name = "Nama"
        Nama.Width = 125
        ' 
        ' NoTel
        ' 
        NoTel.HeaderText = "NoTel"
        NoTel.MinimumWidth = 6
        NoTel.Name = "NoTel"
        NoTel.Width = 125
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(380, 528)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 16
        Button1.Text = "CREATE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(494, 528)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 17
        Button2.Text = "READ"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(609, 528)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 18
        Button3.Text = "UPDATE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(728, 528)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 19
        Button4.Text = "DELETE"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(890, 585)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label2)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(lblJantina)
        Controls.Add(GroupBox1)
        Controls.Add(lbNegeri)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox3)
        Controls.Add(lblAlamat)
        Controls.Add(TextBox2)
        Controls.Add(lblNotel)
        Controls.Add(TextBox1)
        Controls.Add(lblNama)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblNotel As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lbNegeri As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents lblJantina As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BIL As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents NoTel As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button

End Class
