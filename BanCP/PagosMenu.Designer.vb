<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagosMenu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btAtras = New System.Windows.Forms.Button()
        Me.btRecarga = New System.Windows.Forms.Button()
        Me.btServicios = New System.Windows.Forms.Button()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Image = Global.BanCP.My.Resources.Resources.Logo
        Me.pictureBox2.Location = New System.Drawing.Point(200, 21)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(271, 93)
        Me.pictureBox2.TabIndex = 18
        Me.pictureBox2.TabStop = False
        '
        'btAtras
        '
        Me.btAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtras.Location = New System.Drawing.Point(273, 273)
        Me.btAtras.Name = "btAtras"
        Me.btAtras.Size = New System.Drawing.Size(116, 38)
        Me.btAtras.TabIndex = 17
        Me.btAtras.Text = "Atras"
        Me.btAtras.UseVisualStyleBackColor = True
        '
        'btRecarga
        '
        Me.btRecarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRecarga.Location = New System.Drawing.Point(364, 150)
        Me.btRecarga.Name = "btRecarga"
        Me.btRecarga.Size = New System.Drawing.Size(182, 59)
        Me.btRecarga.TabIndex = 16
        Me.btRecarga.Text = "Recargas"
        Me.btRecarga.UseVisualStyleBackColor = True
        '
        'btServicios
        '
        Me.btServicios.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btServicios.Location = New System.Drawing.Point(109, 150)
        Me.btServicios.Name = "btServicios"
        Me.btServicios.Size = New System.Drawing.Size(182, 59)
        Me.btServicios.TabIndex = 15
        Me.btServicios.Text = "Servicios"
        Me.btServicios.UseVisualStyleBackColor = True
        '
        'PagosMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BanCP.My.Resources.Resources.image
        Me.ClientSize = New System.Drawing.Size(656, 333)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.btAtras)
        Me.Controls.Add(Me.btRecarga)
        Me.Controls.Add(Me.btServicios)
        Me.Name = "PagosMenu"
        Me.Text = "PagosMenu"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents btAtras As Button
    Private WithEvents btRecarga As Button
    Private WithEvents btServicios As Button
End Class
