Public Class AgregarUsuarios

    Dim con = New Conexion

    Private Sub AgregarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.mostrarUsuarios(dgUsuarios)
    End Sub
End Class