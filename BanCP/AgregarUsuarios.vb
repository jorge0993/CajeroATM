Public Class AgregarUsuarios
    Dim con = New Conexion

    Private Sub AgregarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.mostrarUsuarios(dgUsuarios)
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        con.EliminarUsuario(txtNumero.Text)
        con.mostrarUsuarios(dgUsuarios)
    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        MsgBox(con.agregarUsuario(txtNumero.Text.ToString(), Convert.ToInt32(txtPIN.Text), txtNombre.Text.ToString(), txtApellidos.Text.ToString(), txtDireccion.Text.ToString(), Date.Today.ToShortDateString(), CBusu.SelectedIndex + 1), MsgBoxStyle.OkOnly, "Notificación")
        con.mostrarUsuarios(dgUsuarios)
    End Sub
End Class