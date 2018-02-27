Imports System.Data.SqlClient

Public Class Conexion
    Private cn As SqlConnection
    Private cmd As SqlCommand
    Private dr As SqlDataReader

    Public Sub New()
        Try
            Me.cn = New SqlConnection(My.Settings.Conexion)
            Me.cn.Open()
        Catch e As Exception
            MessageBox.Show("Ha habido un error al intentar conectar a la base de datos" + e.Message, "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    'metodos a agregar   :)

    Public Sub mostrarUsuarios(dg As DataGridView)
        Dim sql As String = "Select * from Usuarios"
        Dim cmd As New SqlCommand(sql, cn)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds, "Usuarios")

            dg.DataSource = ds.Tables("Usuarios")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
