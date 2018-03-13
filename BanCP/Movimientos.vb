Public Class Movimientos
    Private Sub btAtras_Click(sender As Object, e As EventArgs) Handles btAtras.Click
        Dim menu As New Menu
        Me.Hide()
        menu.Show()
    End Sub
End Class