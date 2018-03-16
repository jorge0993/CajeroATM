Public Class Saldo
    Dim con As New Conexion


    Private Sub btAtras_Click(sender As Object, e As EventArgs) Handles btAtras.Click
        Dim menu As New Menu
        Me.Hide()
        menu.Show()
    End Sub

    Private Sub Saldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbSaldo.Text = con.ConsultarSaldo()
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click

    End Sub
End Class