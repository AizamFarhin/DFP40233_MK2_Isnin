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
        lblMaklumatpelanggan = New Label()
        lblNama = New Label()
        txtNama = New TextBox()
        lblNotel = New Label()
        txtNotel = New TextBox()
        lblAlamat = New Label()
        txtAlamat = New TextBox()
        cbxNegeri = New ComboBox()
        lbNegeri = New Label()
        gbxJantina = New GroupBox()
        rbuPerempuan = New RadioButton()
        rbuLelaki = New RadioButton()
        lblJantina = New Label()
        gbxKaedahbayaran = New GroupBox()
        rbuCashless = New RadioButton()
        rbuCash = New RadioButton()
        gbxPerisa = New GroupBox()
        cbxPisang = New CheckBox()
        cbxStrawberi = New CheckBox()
        cbxCoklat = New CheckBox()
        cbxKopi = New CheckBox()
        cbxMilo = New CheckBox()
        lblTarikh = New Label()
        dtpTarikh = New DateTimePicker()
        dgvData = New DataGridView()
        BIL = New DataGridViewTextBoxColumn()
        Nama = New DataGridViewTextBoxColumn()
        NoTel = New DataGridViewTextBoxColumn()
        BtnCreate = New Button()
        BtnRead = New Button()
        BtnUpdate = New Button()
        BtnDelete = New Button()
        gbxJantina.SuspendLayout()
        gbxKaedahbayaran.SuspendLayout()
        gbxPerisa.SuspendLayout()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblMaklumatpelanggan
        ' 
        lblMaklumatpelanggan.AutoSize = True
        lblMaklumatpelanggan.Font = New Font("Elephant", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMaklumatpelanggan.Location = New Point(253, 25)
        lblMaklumatpelanggan.Name = "lblMaklumatpelanggan"
        lblMaklumatpelanggan.Size = New Size(417, 35)
        lblMaklumatpelanggan.TabIndex = 0
        lblMaklumatpelanggan.Text = "MAKLUMAT PELANGGAN"
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
        ' txtNama
        ' 
        txtNama.Location = New Point(74, 90)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(423, 27)
        txtNama.TabIndex = 2
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
        ' txtNotel
        ' 
        txtNotel.Location = New Point(74, 133)
        txtNotel.Name = "txtNotel"
        txtNotel.Size = New Size(253, 27)
        txtNotel.TabIndex = 4
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
        ' txtAlamat
        ' 
        txtAlamat.Location = New Point(74, 176)
        txtAlamat.Multiline = True
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(423, 99)
        txtAlamat.TabIndex = 6
        ' 
        ' cbxNegeri
        ' 
        cbxNegeri.FormattingEnabled = True
        cbxNegeri.Items.AddRange(New Object() {"Johor", "Kedah", "Kelantan", "Melaka", "Negeri Sembilan", "Pahang", "Perak", "Perlis", "Pulau Pinang", "Sabah", "Sarawak", "Selangor", "Terengganu", "Wilayah Persekutuan Kuala Lumpur"})
        cbxNegeri.Location = New Point(74, 304)
        cbxNegeri.Name = "cbxNegeri"
        cbxNegeri.Size = New Size(151, 28)
        cbxNegeri.TabIndex = 7
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
        ' gbxJantina
        ' 
        gbxJantina.Controls.Add(rbuPerempuan)
        gbxJantina.Controls.Add(rbuLelaki)
        gbxJantina.Location = New Point(74, 362)
        gbxJantina.Name = "gbxJantina"
        gbxJantina.Size = New Size(253, 75)
        gbxJantina.TabIndex = 9
        gbxJantina.TabStop = False
        ' 
        ' rbuPerempuan
        ' 
        rbuPerempuan.AutoSize = True
        rbuPerempuan.Location = New Point(6, 45)
        rbuPerempuan.Name = "rbuPerempuan"
        rbuPerempuan.Size = New Size(104, 24)
        rbuPerempuan.TabIndex = 1
        rbuPerempuan.TabStop = True
        rbuPerempuan.Text = "Perempuan"
        rbuPerempuan.UseVisualStyleBackColor = True
        ' 
        ' rbuLelaki
        ' 
        rbuLelaki.AutoSize = True
        rbuLelaki.Location = New Point(6, 14)
        rbuLelaki.Name = "rbuLelaki"
        rbuLelaki.Size = New Size(68, 24)
        rbuLelaki.TabIndex = 0
        rbuLelaki.TabStop = True
        rbuLelaki.Text = "Lelaki"
        rbuLelaki.UseVisualStyleBackColor = True
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
        ' gbxKaedahbayaran
        ' 
        gbxKaedahbayaran.Controls.Add(rbuCashless)
        gbxKaedahbayaran.Controls.Add(rbuCash)
        gbxKaedahbayaran.Location = New Point(74, 466)
        gbxKaedahbayaran.Name = "gbxKaedahbayaran"
        gbxKaedahbayaran.Size = New Size(250, 91)
        gbxKaedahbayaran.TabIndex = 11
        gbxKaedahbayaran.TabStop = False
        gbxKaedahbayaran.Text = "Kaedah Bayaran :"
        ' 
        ' rbuCashless
        ' 
        rbuCashless.AutoSize = True
        rbuCashless.Location = New Point(9, 54)
        rbuCashless.Name = "rbuCashless"
        rbuCashless.Size = New Size(85, 24)
        rbuCashless.TabIndex = 1
        rbuCashless.TabStop = True
        rbuCashless.Text = "Cashless"
        rbuCashless.UseVisualStyleBackColor = True
        ' 
        ' rbuCash
        ' 
        rbuCash.AutoSize = True
        rbuCash.Location = New Point(9, 25)
        rbuCash.Name = "rbuCash"
        rbuCash.Size = New Size(61, 24)
        rbuCash.TabIndex = 0
        rbuCash.TabStop = True
        rbuCash.Text = "Cash"
        rbuCash.UseVisualStyleBackColor = True
        ' 
        ' gbxPerisa
        ' 
        gbxPerisa.Controls.Add(cbxPisang)
        gbxPerisa.Controls.Add(cbxStrawberi)
        gbxPerisa.Controls.Add(cbxCoklat)
        gbxPerisa.Controls.Add(cbxKopi)
        gbxPerisa.Controls.Add(cbxMilo)
        gbxPerisa.Location = New Point(572, 90)
        gbxPerisa.Name = "gbxPerisa"
        gbxPerisa.Size = New Size(250, 184)
        gbxPerisa.TabIndex = 12
        gbxPerisa.TabStop = False
        gbxPerisa.Text = "Perisa :"
        ' 
        ' cbxPisang
        ' 
        cbxPisang.AutoSize = True
        cbxPisang.Location = New Point(10, 147)
        cbxPisang.Name = "cbxPisang"
        cbxPisang.Size = New Size(74, 24)
        cbxPisang.TabIndex = 4
        cbxPisang.Text = "Pisang"
        cbxPisang.UseVisualStyleBackColor = True
        ' 
        ' cbxStrawberi
        ' 
        cbxStrawberi.AutoSize = True
        cbxStrawberi.Location = New Point(10, 117)
        cbxStrawberi.Name = "cbxStrawberi"
        cbxStrawberi.Size = New Size(94, 24)
        cbxStrawberi.TabIndex = 3
        cbxStrawberi.Text = "Strawberi"
        cbxStrawberi.UseVisualStyleBackColor = True
        ' 
        ' cbxCoklat
        ' 
        cbxCoklat.AutoSize = True
        cbxCoklat.Location = New Point(10, 87)
        cbxCoklat.Name = "cbxCoklat"
        cbxCoklat.Size = New Size(73, 24)
        cbxCoklat.TabIndex = 2
        cbxCoklat.Text = "Coklat"
        cbxCoklat.UseVisualStyleBackColor = True
        ' 
        ' cbxKopi
        ' 
        cbxKopi.AutoSize = True
        cbxKopi.Location = New Point(10, 57)
        cbxKopi.Name = "cbxKopi"
        cbxKopi.Size = New Size(62, 24)
        cbxKopi.TabIndex = 1
        cbxKopi.Text = "Kopi"
        cbxKopi.UseVisualStyleBackColor = True
        ' 
        ' cbxMilo
        ' 
        cbxMilo.AutoSize = True
        cbxMilo.Location = New Point(10, 26)
        cbxMilo.Name = "cbxMilo"
        cbxMilo.Size = New Size(61, 24)
        cbxMilo.TabIndex = 0
        cbxMilo.Text = "Milo"
        cbxMilo.UseVisualStyleBackColor = True
        ' 
        ' lblTarikh
        ' 
        lblTarikh.AutoSize = True
        lblTarikh.Location = New Point(582, 304)
        lblTarikh.Name = "lblTarikh"
        lblTarikh.Size = New Size(54, 20)
        lblTarikh.TabIndex = 13
        lblTarikh.Text = "Tarikh :"
        ' 
        ' dtpTarikh
        ' 
        dtpTarikh.Location = New Point(572, 339)
        dtpTarikh.Name = "dtpTarikh"
        dtpTarikh.Size = New Size(250, 27)
        dtpTarikh.TabIndex = 14
        ' 
        ' dgvData
        ' 
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Columns.AddRange(New DataGridViewColumn() {BIL, Nama, NoTel})
        dgvData.Location = New Point(431, 407)
        dgvData.Name = "dgvData"
        dgvData.RowHeadersWidth = 51
        dgvData.Size = New Size(391, 82)
        dgvData.TabIndex = 15
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
        ' BtnCreate
        ' 
        BtnCreate.Location = New Point(380, 528)
        BtnCreate.Name = "BtnCreate"
        BtnCreate.Size = New Size(94, 29)
        BtnCreate.TabIndex = 16
        BtnCreate.Text = "CREATE"
        BtnCreate.UseVisualStyleBackColor = True
        ' 
        ' BtnRead
        ' 
        BtnRead.Location = New Point(494, 528)
        BtnRead.Name = "BtnRead"
        BtnRead.Size = New Size(94, 29)
        BtnRead.TabIndex = 17
        BtnRead.Text = "READ"
        BtnRead.UseVisualStyleBackColor = True
        ' 
        ' BtnUpdate
        ' 
        BtnUpdate.Location = New Point(609, 528)
        BtnUpdate.Name = "BtnUpdate"
        BtnUpdate.Size = New Size(94, 29)
        BtnUpdate.TabIndex = 18
        BtnUpdate.Text = "UPDATE"
        BtnUpdate.UseVisualStyleBackColor = True
        ' 
        ' BtnDelete
        ' 
        BtnDelete.Location = New Point(728, 528)
        BtnDelete.Name = "BtnDelete"
        BtnDelete.Size = New Size(94, 29)
        BtnDelete.TabIndex = 19
        BtnDelete.Text = "DELETE"
        BtnDelete.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(890, 585)
        Controls.Add(BtnDelete)
        Controls.Add(BtnUpdate)
        Controls.Add(BtnRead)
        Controls.Add(BtnCreate)
        Controls.Add(dgvData)
        Controls.Add(dtpTarikh)
        Controls.Add(lblTarikh)
        Controls.Add(gbxPerisa)
        Controls.Add(gbxKaedahbayaran)
        Controls.Add(lblJantina)
        Controls.Add(gbxJantina)
        Controls.Add(lbNegeri)
        Controls.Add(cbxNegeri)
        Controls.Add(txtAlamat)
        Controls.Add(lblAlamat)
        Controls.Add(txtNotel)
        Controls.Add(lblNotel)
        Controls.Add(txtNama)
        Controls.Add(lblNama)
        Controls.Add(lblMaklumatpelanggan)
        Name = "Form1"
        Text = "Form1"
        gbxJantina.ResumeLayout(False)
        gbxJantina.PerformLayout()
        gbxKaedahbayaran.ResumeLayout(False)
        gbxKaedahbayaran.PerformLayout()
        gbxPerisa.ResumeLayout(False)
        gbxPerisa.PerformLayout()
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblMaklumatpelanggan As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents lblNotel As Label
    Friend WithEvents txtNotel As TextBox
    Friend WithEvents lblAlamat As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents cbxNegeri As ComboBox
    Friend WithEvents lbNegeri As Label
    Friend WithEvents gbxJantina As GroupBox
    Friend WithEvents rbuPerempuan As RadioButton
    Friend WithEvents rbuLelaki As RadioButton
    Friend WithEvents lblJantina As Label
    Friend WithEvents gbxKaedahbayaran As GroupBox
    Friend WithEvents rbuCashless As RadioButton
    Friend WithEvents rbuCash As RadioButton
    Friend WithEvents gbxPerisa As GroupBox
    Friend WithEvents cbxPisang As CheckBox
    Friend WithEvents cbxStrawberi As CheckBox
    Friend WithEvents cbxCoklat As CheckBox
    Friend WithEvents cbxKopi As CheckBox
    Friend WithEvents cbxMilo As CheckBox
    Friend WithEvents lblTarikh As Label
    Friend WithEvents dtpTarikh As DateTimePicker
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents BIL As DataGridViewTextBoxColumn
    Friend WithEvents Nama As DataGridViewTextBoxColumn
    Friend WithEvents NoTel As DataGridViewTextBoxColumn
    Friend WithEvents BtnCreate As Button
    Friend WithEvents BtnRead As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button

End Class
