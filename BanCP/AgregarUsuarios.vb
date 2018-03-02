Public Class AgregarUsuarios
    Dim con = New Conexion
    Dim fun = New Funciones
    Dim banEvent As Boolean = False

    Private Sub AgregarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.mostrarUsuarios(dgUsuarios)
        clear()
        Reset()
        dgUsuarios.ClearSelection()
        'btModificar.Visible = False
    End Sub

    Private Sub btEliminar_Click(sender As Object, e As EventArgs) Handles btEliminar.Click
        If MessageBox.Show("Desea borrar este registro?", "Borrar", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            con.EliminarUsuario(Me.dgUsuarios.CurrentRow.Cells("Numero_tarjeta").Value.ToString())
            con.mostrarUsuarios(dgUsuarios)
        End If

    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        MsgBox(con.agregarUsuario(txtNumero.Text.ToString(), Convert.ToInt32(txtPIN.Text), txtNombre.Text.ToString(), txtApellidos.Text.ToString(), txtDireccion.Text.ToString(), Convert.ToString(DateTime.Now.ToString("MM/dd/yyyy")), CBusu.SelectedIndex + 1), MsgBoxStyle.OkOnly, "Notificación")
        con.mostrarUsuarios(dgUsuarios)
        clear()
    End Sub

    Private Sub clear()
        txtApellidos.Clear()
        txtDireccion.Clear()
        txtNombre.Clear()
        txtNumero.Clear()
        txtPIN.Clear()
        CBusu.SelectedIndex = -1
        dgUsuarios.ClearSelection()
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        fun.validacionKeyNum(e)
    End Sub

    Private Sub txtPIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPIN.KeyPress
        fun.validacionKeyNum(e)
    End Sub



    Private Sub btModificar_Click(sender As Object, e As EventArgs) Handles btModificar.Click
        If Not String.IsNullOrEmpty(txtNombre.Text) And Not String.IsNullOrEmpty(txtApellidos.Text) And Not String.IsNullOrEmpty(txtDireccion.Text) And Not String.IsNullOrEmpty(txtNumero.Text) Then
            con.ModificarUsuario(txtNombre.Text, txtApellidos.Text, txtDireccion.Text, txtNumero.Text, CBusu.SelectedIndex)
            Reset()
            dgUsuarios.ClearSelection()
            btModificar.Visible = False
            con.mostrarUsuarios(dgUsuarios)
        Else
            MessageBox.Show("Verificar datos a modificar.")
        End If
    End Sub

    Private Sub Reset()
        txtNumero.Enabled = True
        clear()
    End Sub

    Private Sub dgUsuarios_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsuarios.CellEnter
        Try
            If banEvent = True Then
                btModificar.Visible = True
                txtNumero.Text = Me.dgUsuarios.CurrentRow.Cells("Numero_tarjeta").Value.ToString()
                txtNombre.Text = Me.dgUsuarios.CurrentRow.Cells("Nombres").Value.ToString()
                txtApellidos.Text = Me.dgUsuarios.CurrentRow.Cells("Apellidos").Value.ToString()
                txtDireccion.Text = Me.dgUsuarios.CurrentRow.Cells("Direccion").Value.ToString()
                CBusu.Text = Me.dgUsuarios.CurrentRow.Cells("TipoUsuario").Value.ToString()


                txtNumero.Enabled = False
            Else
                banEvent = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btLimpiar_Click(sender As Object, e As EventArgs) Handles btLimpiar.Click
        Reset()
        clear()
    End Sub
End Class