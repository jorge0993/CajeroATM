<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btAtras = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BanCPDataSet = New BanCP.BanCPDataSet()
        Me.ReporteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReporteTableAdapter = New BanCP.BanCPDataSetTableAdapters.ReporteTableAdapter()
        CType(Me.BanCPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReporteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "ds"
        ReportDataSource1.Value = Me.ReporteBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "BanCP.reporte_movimientos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 293)
        Me.ReportViewer1.TabIndex = 0
        '
        'btAtras
        '
        Me.btAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtras.Location = New System.Drawing.Point(461, 302)
        Me.btAtras.Name = "btAtras"
        Me.btAtras.Size = New System.Drawing.Size(116, 38)
        Me.btAtras.TabIndex = 18
        Me.btAtras.Text = "Cancelar"
        Me.btAtras.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(206, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 38)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BanCPDataSet
        '
        Me.BanCPDataSet.DataSetName = "BanCPDataSet"
        Me.BanCPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReporteBindingSource
        '
        Me.ReporteBindingSource.DataMember = "Reporte"
        Me.ReporteBindingSource.DataSource = Me.BanCPDataSet
        '
        'ReporteTableAdapter
        '
        Me.ReporteTableAdapter.ClearBeforeFill = True
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 349)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btAtras)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Reporte"
        Me.Text = "Reporte"
        CType(Me.BanCPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReporteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ReporteBindingSource As BindingSource
    Friend WithEvents BanCPDataSet As BanCPDataSet
    Private WithEvents btAtras As Button
    Private WithEvents Button1 As Button
    Friend WithEvents ReporteTableAdapter As BanCPDataSetTableAdapters.ReporteTableAdapter
End Class
