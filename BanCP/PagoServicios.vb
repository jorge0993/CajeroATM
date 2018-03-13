Public Class PagoServicios
    Private Sub btAtras_Click(sender As Object, e As EventArgs) Handles btAtras.Click
        Dim menu As New PagosMenu
        Me.Hide()
        menu.Show()
    End Sub
End Class