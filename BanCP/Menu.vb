Public Class Menu

    Private Sub btCambiar_Click(sender As Object, e As EventArgs) Handles btCambiar.Click
        Me.Hide()
        CambiarPIN.Show()
    End Sub

    Private Sub btUsuarios_Click(sender As Object, e As EventArgs) Handles btUsuarios.Click
        Me.Hide()
        AgregarUsuarios.Show()
    End Sub

    Private Sub btRetiros_Click(sender As Object, e As EventArgs) Handles btRetiros.Click
        Me.Hide()
        Retiros.Show()
    End Sub

    Private Sub btSaldo_Click(sender As Object, e As EventArgs) Handles btSaldo.Click
        Me.Hide()
        Saldo.Show()
    End Sub

    Private Sub btMovimientos_Click(sender As Object, e As EventArgs) Handles btMovimientos.Click
        Me.Hide()
        Movimientos.Show()
    End Sub

    Private Sub btPagos_Click(sender As Object, e As EventArgs) Handles btPagos.Click
        Me.Hide()
        PagosMenu.Show()
    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        Me.Hide()
        Inicio.Show()
    End Sub
End Class
