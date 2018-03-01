Public Class Funciones
    Public Sub validacionKeyNum(e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
