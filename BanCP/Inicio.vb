Imports System.Configuration

Public Class Inicio
    Dim obj = New Conexion

    Dim config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    Private Sub tbTarjeta_TextChanged(sender As Object, e As EventArgs) Handles tbTarjeta.TextChanged
        If (tbTarjeta.Text.Length = 11) Then
            Tipo = obj.VerificarUsuario(tbTarjeta.Text.Trim)
            If (Tipo = -1) Then
                MessageBox.Show("Esta tarjeta no se encuentra dentro del sistema", "Verificar tarjeta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                tbTarjeta.Text = ""
            Else
                Dim loginPin = New LoginPIN()
                loginPin.Show()

                Tarjeta = tbTarjeta.Text.ToString().Trim()
                Me.Hide()

            End If
        End If

    End Sub
End Class