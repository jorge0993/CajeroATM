Public Class PagoServicios
    Dim Cantidad As Integer
    Dim TipoMov As String
    Dim menupagos As New PagosMenu
    Dim con As New Conexion
    Dim fun As New Funciones
    Private Sub btAtras_Click(sender As Object, e As EventArgs) Handles btAtras.Click
        Me.Hide()
        menupagos.Show()
        limpiarcampos()
    End Sub

    Private Sub btPagar_Click(sender As Object, e As EventArgs) Handles btPagar.Click
        Cantidad = Convert.ToInt32(tbCantidad.Text)
        MessageBox.Show(con.RealizarMovimiento(TipoMov, Cantidad, "Pago"))
        limpiarcampos()
    End Sub

    Private Sub rdMegacable_CheckedChanged(sender As Object, e As EventArgs) Handles rdMegacable.CheckedChanged
        TipoMov = "Pago servicio - Megacable"
        If (tbCantidad.Text <> "" And rdMegacable.Checked = True) Then
            btPagar.Enabled = True
        End If
    End Sub

    Private Sub rdLuz_CheckedChanged(sender As Object, e As EventArgs) Handles rdLuz.CheckedChanged
        TipoMov = "Pago servicio - Luz"
        If (tbCantidad.Text <> "" And rdLuz.Checked = True) Then
            btPagar.Enabled = True
        End If
    End Sub

    Private Sub rdAgua_CheckedChanged(sender As Object, e As EventArgs) Handles rdAgua.CheckedChanged
        TipoMov = "Pago servicio - Agua"
        If (tbCantidad.Text <> "" And rdAgua.Checked = True) Then
            btPagar.Enabled = True
        End If

    End Sub

    Private Sub tbCantidad_TextChanged(sender As Object, e As EventArgs) Handles tbCantidad.TextChanged
        If (tbCantidad.Text <> "" And (rdAgua.Checked = True Or rdLuz.Checked = True Or rdMegacable.Checked = True)) Then
            btPagar.Enabled = True
        End If
    End Sub

    Private Sub tbCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbCantidad.KeyPress
        fun.validacionKeyNum(e)
    End Sub

    Private Sub limpiarcampos()
        btPagar.Enabled = False
        TipoMov = ""
        tbCantidad.Text = ""
        rdAgua.Checked = False
        rdLuz.Checked = False
        rdMegacable.Checked = False
    End Sub
End Class