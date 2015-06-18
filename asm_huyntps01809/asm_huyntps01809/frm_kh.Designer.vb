<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_kh
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnTrove = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnThem = New System.Windows.Forms.Button()
        Me.txtSodienthoai = New System.Windows.Forms.TextBox()
        Me.lblSodienthoai = New System.Windows.Forms.Label()
        Me.txtDiachi = New System.Windows.Forms.TextBox()
        Me.lblDiachi = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtTenkhachhang = New System.Windows.Forms.TextBox()
        Me.lblTenkhachhang = New System.Windows.Forms.Label()
        Me.txtMasokhachhang = New System.Windows.Forms.TextBox()
        Me.lblMasokhachhang = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(330, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(357, 172)
        Me.DataGridView1.TabIndex = 90
        '
        'btnTrove
        '
        Me.btnTrove.Location = New System.Drawing.Point(251, 161)
        Me.btnTrove.Name = "btnTrove"
        Me.btnTrove.Size = New System.Drawing.Size(73, 23)
        Me.btnTrove.TabIndex = 89
        Me.btnTrove.Text = "Trở về"
        Me.btnTrove.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(172, 161)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(73, 23)
        Me.btnXoa.TabIndex = 88
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(93, 161)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(73, 23)
        Me.btnSua.TabIndex = 87
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnThem
        '
        Me.btnThem.Location = New System.Drawing.Point(14, 161)
        Me.btnThem.Name = "btnThem"
        Me.btnThem.Size = New System.Drawing.Size(73, 23)
        Me.btnThem.TabIndex = 86
        Me.btnThem.Text = "Thêm"
        Me.btnThem.UseVisualStyleBackColor = True
        '
        'txtSodienthoai
        '
        Me.txtSodienthoai.Location = New System.Drawing.Point(121, 116)
        Me.txtSodienthoai.Name = "txtSodienthoai"
        Me.txtSodienthoai.Size = New System.Drawing.Size(201, 20)
        Me.txtSodienthoai.TabIndex = 85
        Me.txtSodienthoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSodienthoai
        '
        Me.lblSodienthoai.Location = New System.Drawing.Point(11, 114)
        Me.lblSodienthoai.Name = "lblSodienthoai"
        Me.lblSodienthoai.Size = New System.Drawing.Size(104, 23)
        Me.lblSodienthoai.TabIndex = 84
        Me.lblSodienthoai.Text = "Số điện thoại:"
        Me.lblSodienthoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDiachi
        '
        Me.txtDiachi.Location = New System.Drawing.Point(121, 90)
        Me.txtDiachi.Name = "txtDiachi"
        Me.txtDiachi.Size = New System.Drawing.Size(201, 20)
        Me.txtDiachi.TabIndex = 83
        '
        'lblDiachi
        '
        Me.lblDiachi.Location = New System.Drawing.Point(11, 88)
        Me.lblDiachi.Name = "lblDiachi"
        Me.lblDiachi.Size = New System.Drawing.Size(104, 23)
        Me.lblDiachi.TabIndex = 82
        Me.lblDiachi.Text = "Địa chỉ:"
        Me.lblDiachi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(121, 64)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(201, 20)
        Me.txtEmail.TabIndex = 81
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(11, 64)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(104, 23)
        Me.lblEmail.TabIndex = 80
        Me.lblEmail.Text = "Email:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTenkhachhang
        '
        Me.txtTenkhachhang.Location = New System.Drawing.Point(121, 38)
        Me.txtTenkhachhang.Name = "txtTenkhachhang"
        Me.txtTenkhachhang.Size = New System.Drawing.Size(201, 20)
        Me.txtTenkhachhang.TabIndex = 79
        '
        'lblTenkhachhang
        '
        Me.lblTenkhachhang.Location = New System.Drawing.Point(11, 36)
        Me.lblTenkhachhang.Name = "lblTenkhachhang"
        Me.lblTenkhachhang.Size = New System.Drawing.Size(104, 23)
        Me.lblTenkhachhang.TabIndex = 78
        Me.lblTenkhachhang.Text = "Tên Khách hàng:"
        Me.lblTenkhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMasokhachhang
        '
        Me.txtMasokhachhang.Location = New System.Drawing.Point(121, 12)
        Me.txtMasokhachhang.Name = "txtMasokhachhang"
        Me.txtMasokhachhang.Size = New System.Drawing.Size(201, 20)
        Me.txtMasokhachhang.TabIndex = 77
        '
        'lblMasokhachhang
        '
        Me.lblMasokhachhang.Location = New System.Drawing.Point(11, 10)
        Me.lblMasokhachhang.Name = "lblMasokhachhang"
        Me.lblMasokhachhang.Size = New System.Drawing.Size(104, 23)
        Me.lblMasokhachhang.TabIndex = 76
        Me.lblMasokhachhang.Text = "Mã số khách hàng:"
        Me.lblMasokhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_kh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 195)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTrove)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnThem)
        Me.Controls.Add(Me.txtSodienthoai)
        Me.Controls.Add(Me.lblSodienthoai)
        Me.Controls.Add(Me.txtDiachi)
        Me.Controls.Add(Me.lblDiachi)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtTenkhachhang)
        Me.Controls.Add(Me.lblTenkhachhang)
        Me.Controls.Add(Me.txtMasokhachhang)
        Me.Controls.Add(Me.lblMasokhachhang)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_kh"
        Me.Text = "frm_kh"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnTrove As System.Windows.Forms.Button
    Friend WithEvents btnXoa As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnThem As System.Windows.Forms.Button
    Friend WithEvents txtSodienthoai As System.Windows.Forms.TextBox
    Friend WithEvents lblSodienthoai As System.Windows.Forms.Label
    Friend WithEvents txtDiachi As System.Windows.Forms.TextBox
    Friend WithEvents lblDiachi As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtTenkhachhang As System.Windows.Forms.TextBox
    Friend WithEvents lblTenkhachhang As System.Windows.Forms.Label
    Friend WithEvents txtMasokhachhang As System.Windows.Forms.TextBox
    Friend WithEvents lblMasokhachhang As System.Windows.Forms.Label
End Class
