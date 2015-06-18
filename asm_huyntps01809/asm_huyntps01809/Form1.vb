Imports System.Data.SqlClient
Imports System.Data.DataTable
'sua code up len github
Public Class frm_login
    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        'Tạo Biến để kết nối đến cơ sở dữ liệu
        Dim chuoiketnoi As String = "workstation id=ASM-ps01809.mssql.somee.com;packet size=4096;user id=ps01809;pwd=Abc@12345;data source=ASM-ps01809.mssql.somee.com;persist security info=False;initial catalog=ASM-ps01809"
        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        'Tạo biến để kết nối đến From Login để đăng nhập
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien where MaNhanVien ='" & txtuser.Text & "' and password='" & txtpassword.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                'Hiển thị dòng thông báo khi đăng nhập thành công
                MessageBox.Show("WELCOME", "Thông báo")
                frm_main.Show()
                Me.Hide()
            ElseIf txtuser.Text = "" Or txtpassword.Text = "" Then
                MessageBox.Show("Chưa nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'Hiển thị dòng thông báo khi đăng nhập thất bại
                MessageBox.Show("Xin vui lòng nhập đúng thông tin")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub
End Class
