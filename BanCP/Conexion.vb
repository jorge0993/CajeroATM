﻿Imports System.Data.SqlClient

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
    Public Sub EliminarUsuario(ByVal NumTarjeta As String)
        Dim Sql As String = "Delete from Usuarios where Numero_tarjeta=" + NumTarjeta
        Dim cmd As New SqlCommand(Sql, cn)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet

            da.Fill(ds, "Usuarios")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function agregarUsuario(ByVal Tarjeta As String, ByVal PIN As Long, ByVal Nombres As String, ByVal Apellidos As String, ByVal Direccion As String, ByVal FechaAlta As String, ByVal TipoUsuario As Integer) As String
        Dim Resultado As String = "Registro Exitoso"
        Dim SaldoUsuario As Integer = 0
        Try
            Dim Sql As String = "Select Numero_tarjeta from Usuarios where Numero_tarjeta='" & Tarjeta & "'"
            Me.cmd = New SqlCommand(Sql, Me.cn)
            If Me.cmd.ExecuteNonQuery() = 1 Then
                MsgBox("Ya hay un usuario registrado con ese número de tarjeta." & vbNewLine & "No. de Tarjeta " + Tarjeta)
            Else
                Sql = "Insert Into Usuarios(Numero_tarjeta,PIN,Saldo,Nombres,Apellidos,Direccion,FechaAlta,TipoUsuario) values('" & Tarjeta & "'," & PIN & "," & SaldoUsuario & ",'" & Nombres & "','" & Apellidos & "','" & Direccion & "','" & FechaAlta & "'," & TipoUsuario & ")"
                Me.cmd = New SqlCommand(Sql, Me.cn)
                Me.cmd.ExecuteNonQuery()
            End If
        Catch ex As Exception
            Resultado = ("No se ha Realizado la insercion " + ex.ToString)
        End Try
        Return Resultado
    End Function

End Class


