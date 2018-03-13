Public Class CambiarPIN
    Dim con = New Conexion
    Dim fun = New Funciones
    Private Sub tbPIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPIN.KeyPress
        fun.validacionKeyNum(e)
    End Sub

    Private Sub tbNuevo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNuevo.KeyPress
        fun.validacionKeyNum(e)
    End Sub

    Private Sub tbConfirmar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbConfirmar.KeyPress
        fun.validacionKeyNum(e)
    End Sub

    Private Sub tbNuevo_TextChanged(sender As Object, e As EventArgs) Handles tbNuevo.TextChanged
        If (tbNuevo.Text.Length > 4) Then
            MessageBox.Show("El PIN no pueder ser mayor a 4 digitos", "PIN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbNuevo.Text = ""
        End If
        CoincidirPIN()
    End Sub

    Private Sub tbConfirmar_TextChanged(sender As Object, e As EventArgs) Handles tbConfirmar.TextChanged
        If (tbConfirmar.Text.Length > 4) Then
            MessageBox.Show("El PIN no pueder ser mayor a 4 digitos", "PIN", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbConfirmar.Text = ""
        End If
        CoincidirPIN()

    End Sub

    Private Sub CoincidirPIN()
        If (tbNuevo.Text <> tbConfirmar.Text) Then
            lbConfirmar.Text = "El PIN no coincide"
            lbConfirmar.ForeColor = Color.Red

        ElseIf (tbNuevo.Text = tbConfirmar.Text) Then
            lbConfirmar.Text = "El PIN coincide"
            lbConfirmar.ForeColor = Color.Green
        End If
    End Sub

    Private Sub btnAtras_Click(sender As Object, e As EventArgs) Handles btnAtras.Click
        Dim menu As New Menu
        Me.Hide()
        menu.Show()
    End Sub
End Class