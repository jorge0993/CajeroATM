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
End Class
