Public Class frm_main

    Private Sub bntexit_Click(sender As Object, e As EventArgs) Handles bntexit.Click
        End
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        frm_login.Show()
        Me.Hide()
    End Sub

    Private Sub btnquanlynv_Click(sender As Object, e As EventArgs) Handles btnquanlynv.Click
        frm_nv.Show()
        Me.Hide()
    End Sub

    Private Sub btnquanlykh_Click(sender As Object, e As EventArgs) Handles btnquanlykh.Click
        frm_kh.Show()
        Me.Hide()
    End Sub
End Class