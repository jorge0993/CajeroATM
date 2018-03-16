Public Class Recargas
    Dim Cantidad As Integer
    Dim TipoMov As String
    Dim menu As New PagosMenu
    Dim con As New Conexion
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim menu As New PagosMenu
        Me.Hide()
        menu.Show()
    End Sub

    Private Sub rdTelcel_CheckedChanged(sender As Object, e As EventArgs) Handles rdTelcel.CheckedChanged
        TipoMov = "Recarga Telcel al numero: "
    End Sub

    Private Sub rdMovistar_CheckedChanged(sender As Object, e As EventArgs) Handles rdMovistar.CheckedChanged
        TipoMov = "Recarga Movistar al numero: "
    End Sub

    Private Sub rdatt_CheckedChanged(sender As Object, e As EventArgs) Handles rdatt.CheckedChanged
        TipoMov = "Recarga AT&T al numero: "
    End Sub

    Private Sub tbnumero_TextChanged(sender As Object, e As EventArgs) Handles tbnumero.TextChanged
        If (tbnumero.Text.Length = 10) Then

            comboCantidad.Enabled = True
            btPagar.Enabled = True
            TipoMov += tbnumero.Text

        End If
    End Sub

    Private Sub btPagar_Click(sender As Object, e As EventArgs) Handles btPagar.Click
        Cantidad = Convert.ToInt32(comboCantidad.Text)
        MessageBox.Show(con.RealizarMovimiento(TipoMov, Cantidad, "Recarga"))
        limpiarCampos()
    End Sub

    Private Sub limpiarCampos()
        btPagar.Enabled = False
        comboCantidad.Enabled = False
        tbnumero.Text = ""
        TipoMov = ""
        rdatt.Checked = False
        rdMovistar.Checked = False
        rdTelcel.Checked = False
    End Sub
End Class
