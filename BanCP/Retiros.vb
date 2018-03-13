Public Class Retiros
    Dim con As New Conexion
    Dim Cantidad As Integer
    Dim TipoMov As String = "Retiro"
    Private Sub btAtras_Click(sender As Object, e As EventArgs) Handles btAtras.Click
        Dim menu As New Menu
        Me.Hide()
        menu.Show()
    End Sub

    Private Sub bt50_Click(sender As Object, e As EventArgs) Handles bt50.Click
        Cantidad = 50
        MessageBox.Show(con.RealizarMovimiento(Me.TipoMov, Me.Cantidad))
    End Sub

    Private Sub bt200_Click(sender As Object, e As EventArgs) Handles bt200.Click
        Cantidad = 200
        MessageBox.Show(con.RealizarMovimiento(Me.TipoMov, Me.Cantidad))
    End Sub

    Private Sub bt500_Click(sender As Object, e As EventArgs) Handles bt500.Click
        Cantidad = 500
        MessageBox.Show(con.RealizarMovimiento(Me.TipoMov, Me.Cantidad))
    End Sub

    Private Sub bt1000_Click(sender As Object, e As EventArgs) Handles bt1000.Click
        Cantidad = 1000
        MessageBox.Show(con.RealizarMovimiento(Me.TipoMov, Me.Cantidad))
    End Sub

    Private Sub bt2000_Click(sender As Object, e As EventArgs) Handles bt2000.Click
        Cantidad = 2000
        MessageBox.Show(con.RealizarMovimiento(Me.TipoMov, Me.Cantidad))
    End Sub
End Class