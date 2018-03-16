Imports System.Configuration

Public Class LoginPIN
    Dim objConexion = New Conexion()
    Dim objMenu = New Menu()
    Dim intentos = 3, Contador = 0

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub tbPIN_TextChanged(sender As Object, e As EventArgs) Handles tbPIN.TextChanged
        If (tbPIN.Text.Length = 4) Then

            If (objConexion.ValidarPIN(Convert.ToInt32(tbPIN.Text))) Then
                ''mandar tipo usuario a menu 
                ''objMenu.EstablecerTipoUsuario(objConexion.Ingresar(tbPIN.Text))
                ''Program.TipoUsuario = objConexion.Ingresar(tbPIN.Text)
                objMenu.Show
                Me.Hide()
            ElseIf (intentos <> 0) Then
                Contador = (Contador + 1)
                intentos = (intentos - 1)
                lbIntentos.Text = (" Tienes " & (intentos & " intentos"))
                MessageBox.Show("Contraseña incorrecta")
                tbPIN.Clear()

            End If

            If (Contador = 3) Then
                MessageBox.Show("Demasiados intentos")
                MessageBox.Show("Retirar Tarjeta")
                Application.Restart()
            End If

        End If
    End Sub
End Class