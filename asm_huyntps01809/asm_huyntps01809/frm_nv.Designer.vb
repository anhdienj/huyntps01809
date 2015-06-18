<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_nv
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtSodienthoai = New System.Windows.Forms.TextBox()
        Me.lblSodienthoai = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtTennhanvien = New System.Windows.Forms.TextBox()
        Me.lblTennhanvien = New System.Windows.Forms.Label()
        Me.txtMasonhanvien = New System.Windows.Forms.TextBox()
        Me.lblMasonhanvien = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(326, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(356, 172)
        Me.DataGridView1.TabIndex = 105
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(247, 161)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(73, 23)
        Me.btnBack.TabIndex = 104
        Me.btnBack.Text = "Trở về"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(168, 161)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(73, 23)
        Me.btnClear.TabIndex = 103
        Me.btnClear.Text = "Xóa"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(89, 161)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(73, 23)
        Me.btnChange.TabIndex = 102
        Me.btnChange.Text = "Sửa"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(10, 161)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(73, 23)
        Me.btnAdd.TabIndex = 101
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtSodienthoai
        '
        Me.txtSodienthoai.Location = New System.Drawing.Point(107, 64)
        Me.txtSodienthoai.Name = "txtSodienthoai"
        Me.txtSodienthoai.Size = New System.Drawing.Size(213, 20)
        Me.txtSodienthoai.TabIndex = 100
        Me.txtSodienthoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSodienthoai
        '
        Me.lblSodienthoai.Location = New System.Drawing.Point(7, 62)
        Me.lblSodienthoai.Name = "lblSodienthoai"
        Me.lblSodienthoai.Size = New System.Drawing.Size(94, 23)
        Me.lblSodienthoai.TabIndex = 99
        Me.lblSodienthoai.Text = "Số điện thoại:"
        Me.lblSodienthoai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(107, 90)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(213, 20)
        Me.txtPassword.TabIndex = 98
        '
        'lblPassword
        '
        Me.lblPassword.Location = New System.Drawing.Point(7, 88)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(94, 23)
        Me.lblPassword.TabIndex = 97
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(107, 116)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(213, 20)
        Me.txtID.TabIndex = 96
        '
        'lblID
        '
        Me.lblID.Location = New System.Drawing.Point(7, 114)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(94, 23)
        Me.lblID.TabIndex = 95
        Me.lblID.Text = "ID:"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTennhanvien
        '
        Me.txtTennhanvien.Location = New System.Drawing.Point(107, 38)
        Me.txtTennhanvien.Name = "txtTennhanvien"
        Me.txtTennhanvien.Size = New System.Drawing.Size(213, 20)
        Me.txtTennhanvien.TabIndex = 94
        '
        'lblTennhanvien
        '
        Me.lblTennhanvien.Location = New System.Drawing.Point(7, 36)
        Me.lblTennhanvien.Name = "lblTennhanvien"
        Me.lblTennhanvien.Size = New System.Drawing.Size(94, 23)
        Me.lblTennhanvien.TabIndex = 93
        Me.lblTennhanvien.Text = "Tên nhân viên:"
        Me.lblTennhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMasonhanvien
        '
        Me.txtMasonhanvien.Location = New System.Drawing.Point(107, 12)
        Me.txtMasonhanvien.Name = "txtMasonhanvien"
        Me.txtMasonhanvien.Size = New System.Drawing.Size(213, 20)
        Me.txtMasonhanvien.TabIndex = 92
        '
        'lblMasonhanvien
        '
        Me.lblMasonhanvien.Location = New System.Drawing.Point(7, 10)
        Me.lblMasonhanvien.Name = "lblMasonhanvien"
        Me.lblMasonhanvien.Size = New System.Drawing.Size(94, 23)
        Me.lblMasonhanvien.TabIndex = 91
        Me.lblMasonhanvien.Text = "Mã số nhân viên:"
        Me.lblMasonhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_nv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 199)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSodienthoai)
        Me.Controls.Add(Me.lblSodienthoai)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtTennhanvien)
        Me.Controls.Add(Me.lblTennhanvien)
        Me.Controls.Add(Me.txtMasonhanvien)
        Me.Controls.Add(Me.lblMasonhanvien)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_nv"
        Me.Text = "frm_nv"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtSodienthoai As System.Windows.Forms.TextBox
    Friend WithEvents lblSodienthoai As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtTennhanvien As System.Windows.Forms.TextBox
    Friend WithEvents lblTennhanvien As System.Windows.Forms.Label
    Friend WithEvents txtMasonhanvien As System.Windows.Forms.TextBox
    Friend WithEvents lblMasonhanvien As System.Windows.Forms.Label
End Class
