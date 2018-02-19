<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btUsuarios = New System.Windows.Forms.Button()
        Me.btCambiar = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btPagos = New System.Windows.Forms.Button()
        Me.btMovimientos = New System.Windows.Forms.Button()
        Me.btSaldo = New System.Windows.Forms.Button()
        Me.btRetiros = New System.Windows.Forms.Button()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Image = Global.BanCP.My.Resources.Resources.Logo
        Me.pictureBox2.Location = New System.Drawing.Point(212, 12)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(271, 93)
        Me.pictureBox2.TabIndex = 22
        Me.pictureBox2.TabStop = False
        '
        'btUsuarios
        '
        Me.btUsuarios.Location = New System.Drawing.Point(7, 377)
        Me.btUsuarios.Name = "btUsuarios"
        Me.btUsuarios.Size = New System.Drawing.Size(75, 23)
        Me.btUsuarios.TabIndex = 21
        Me.btUsuarios.Text = "Agregar"
        Me.btUsuarios.UseVisualStyleBackColor = True
        '
        'btCambiar
        '
        Me.btCambiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCambiar.Location = New System.Drawing.Point(444, 212)
        Me.btCambiar.Name = "btCambiar"
        Me.btCambiar.Size = New System.Drawing.Size(167, 63)
        Me.btCambiar.TabIndex = 20
        Me.btCambiar.Text = "Cambiar PIN"
        Me.btCambiar.UseVisualStyleBackColor = True
        '
        'btSalir
        '
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Location = New System.Drawing.Point(444, 294)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(167, 63)
        Me.btSalir.TabIndex = 19
        Me.btSalir.Text = "Salir"
        Me.btSalir.UseVisualStyleBackColor = True
        '
        'btPagos
        '
        Me.btPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPagos.Location = New System.Drawing.Point(444, 132)
        Me.btPagos.Name = "btPagos"
        Me.btPagos.Size = New System.Drawing.Size(167, 63)
        Me.btPagos.TabIndex = 18
        Me.btPagos.Text = "Pagos"
        Me.btPagos.UseVisualStyleBackColor = True
        '
        'btMovimientos
        '
        Me.btMovimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMovimientos.Location = New System.Drawing.Point(62, 292)
        Me.btMovimientos.Name = "btMovimientos"
        Me.btMovimientos.Size = New System.Drawing.Size(167, 63)
        Me.btMovimientos.TabIndex = 17
        Me.btMovimientos.Text = "Movimientos"
        Me.btMovimientos.UseVisualStyleBackColor = True
        '
        'btSaldo
        '
        Me.btSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSaldo.Location = New System.Drawing.Point(62, 212)
        Me.btSaldo.Name = "btSaldo"
        Me.btSaldo.Size = New System.Drawing.Size(167, 63)
        Me.btSaldo.TabIndex = 16
        Me.btSaldo.Text = "Saldo"
        Me.btSaldo.UseVisualStyleBackColor = True
        '
        'btRetiros
        '
        Me.btRetiros.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRetiros.Location = New System.Drawing.Point(62, 132)
        Me.btRetiros.Name = "btRetiros"
        Me.btRetiros.Size = New System.Drawing.Size(167, 63)
        Me.btRetiros.TabIndex = 15
        Me.btRetiros.Text = "Retiros"
        Me.btRetiros.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BanCP.My.Resources.Resources.image
        Me.ClientSize = New System.Drawing.Size(662, 418)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.btUsuarios)
        Me.Controls.Add(Me.btCambiar)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btPagos)
        Me.Controls.Add(Me.btMovimientos)
        Me.Controls.Add(Me.btSaldo)
        Me.Controls.Add(Me.btRetiros)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents btUsuarios As Button
    Private WithEvents btCambiar As Button
    Private WithEvents btSalir As Button
    Private WithEvents btPagos As Button
    Private WithEvents btMovimientos As Button
    Private WithEvents btSaldo As Button
    Private WithEvents btRetiros As Button
End Class
