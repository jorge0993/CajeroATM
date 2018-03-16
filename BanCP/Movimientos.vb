Public Class Movimientos
    Dim con = New Conexion
    Private Sub btAtras_Click(sender As Object, e As EventArgs) Handles btAtras.Click
        Dim menu As New Menu
        Me.Hide()
        menu.Show()
    End Sub

    Private Sub Movimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.mostrarMovimientos(dgMovimientos)
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Hide()
        Reporte.Show()
    End Sub
End Class