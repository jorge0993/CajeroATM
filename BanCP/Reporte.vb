Public Class Reporte
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BanCPDataSet.Reporte' table. You can move, or remove it, as needed.
        Me.ReporteTableAdapter.Fill(Me.BanCPDataSet.Reporte, Tarjeta)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Movimientos.Show()
    End Sub

    Private Sub btAtras_Click(sender As Object, e As EventArgs) Handles btAtras.Click
        Me.Close()
        Movimientos.Show()
    End Sub
End Class