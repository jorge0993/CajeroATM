Imports System.Configuration

Public Class LoginPIN
    Dim objConexion = New Conexion()
    Dim objMenu = New Menu()
    Dim intentos, Contador

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub tbPIN_TextChanged(sender As Object, e As EventArgs) Handles tbPIN.TextChanged
        If (tbPIN.Text.Length = 4) Then
            If ((objConexion.Ingresar(tbPIN.Text) = 1) OrElse (objConexion.Ingresar(tbPIN.Text) = 2)) Then
                ''mandar tipo usuario a menu 
                ''objMenu.EstablecerTipoUsuario(objConexion.Ingresar(tbPIN.Text))
                ''Program.TipoUsuario = objConexion.Ingresar(tbPIN.Text)
                objMenu.Show
                Me.Hide()
            ElseIf (intentos <> 0) Then
                intentos = (2 - Contador)
                lbIntentos.Text = (" Tienes " + (intentos + " intentos"))
                MessageBox.Show("Contraseña incorrecta")
                tbPIN.Clear()
                Contador = (Contador + 1)
            End If

            If (Contador = 3) Then
                MessageBox.Show("Demasiados intentos")
                MessageBox.Show("Retirar Tarjeta")
                Application.Restart()
            End If

        End If
    End Sub
End Class