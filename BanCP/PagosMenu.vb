Public Class PagosMenu
    Private Sub btAtras_Click(sender As Object, e As EventArgs) Handles btAtras.Click
        Dim menu As New Menu
        Me.Hide()
        menu.Show()
    End Sub

    Private Sub btServicios_Click(sender As Object, e As EventArgs) Handles btServicios.Click
        Me.Hide()
        PagoServicios.Show()
    End Sub

    Private Sub btRecarga_Click(sender As Object, e As EventArgs) Handles btRecarga.Click
        Me.Hide()
        Recargas.Show()
    End Sub
End Class