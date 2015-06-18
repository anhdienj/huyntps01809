Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frm_nv
    'Tạo biến cho truy xuất dữ liệu từ csdl
    Dim tb As New DataTable
    Dim connectstr As String = "workstation id=ASM-ps01809.mssql.somee.com;packet size=4096;user id=ps01809;pwd=Abc@12345;data source=ASM-ps01809.mssql.somee.com;persist security info=False;initial catalog=ASM-ps01809"
    Private Sub nhanvien_Load()
        Dim KetNoi As New SqlConnection(connectstr)
        Dim sqlAdapter As New SqlDataAdapter("select * from NhanVien", KetNoi)
        Try
            KetNoi.Open()

            sqlAdapter.Fill(tb)
        Catch ex As Exception
        End Try
        DataGridView1.DataSource = tb
        KetNoi.Close()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Tạo biến để hiển thị ở Datagridview
        Dim index As Integer = DataGridView1.CurrentCell.RowIndex
        txtMasonhanvien.Text = DataGridView1.Item(0, index).Value
        txtTennhanvien.Text = DataGridView1.Item(1, index).Value
        txtSodienthoai.Text = DataGridView1.Item(2, index).Value
        txtPassword.Text = DataGridView1.Item(3, index).Value
        txtID.Text = DataGridView1.Item(4, index).Value
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        nhanvien_Load()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Tạo biến để insert vào Nhanvien
        Dim query As String = String.Empty
        query &= "INSERT INTO NhanVien( MaNhanVien,HoTen,ID,password,SDT)"
        query &= "Values(@MaNV,@TenNV,@ID,@password,@DT)"
        Using conn As New SqlConnection("workstation id=ASM-ps01809.mssql.somee.com;packet size=4096;user id=ps01809;pwd=Abc@12345;data source=ASM-ps01809.mssql.somee.com;persist security info=False;initial catalog=ASM-ps01809")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaNV", txtMasonhanvien.Text)
                    .Parameters.AddWithValue("@TenNV", txtTennhanvien.Text)
                    .Parameters.AddWithValue("@ID", txtID.Text)
                    .Parameters.AddWithValue("@password", txtPassword.Text)
                    .Parameters.AddWithValue("@DT", txtSodienthoai.Text)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show(ex.Message.ToString(), "Error Message")
                End Try
            End Using
        End Using
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        nhanvien_Load()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Tạo biến để Delete
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "Delete from  nhanvien where MaNhanVien = @MaNV"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            com.Parameters.AddWithValue("@MaNV", txtMasonhanvien.Text)
            com.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Xoa khong thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        nhanvien_Load()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        'Tạo biến để update dữ liệu
        Dim ketnoi As New SqlConnection(connectstr)
        ketnoi.Open()
        Dim stradd As String = "update NhanVien set MaNhanVien = @MaNV, HoTen = @TenNV, ID = @ID, password = @password, SDT = @SDT where MaNhanVien = @MaNV"
        Dim com As New SqlCommand(stradd, ketnoi)
        Try
            'thêm dữ liệu vào câu truy vấn
            com.Parameters.AddWithValue("@MaNV", txtMasonhanvien.Text)
            com.Parameters.AddWithValue("@TenNV", txtTennhanvien.Text)
            com.Parameters.AddWithValue("@ID", txtID.Text)
            com.Parameters.AddWithValue("@password", txtPassword.Text)
            com.Parameters.AddWithValue("@DT", txtSodienthoai.Text)
            com.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("ket noi khong thanh cong")
        End Try
        tb.Clear()
        DataGridView1.DataSource = tb
        DataGridView1.DataSource = Nothing
        nhanvien_Load()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frm_main.Show()
        Me.Hide()
    End Sub
End Class