Public Class Recargas
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim menu As New PagosMenu
        Me.Hide()
        menu.Show()
    End Sub
End Class