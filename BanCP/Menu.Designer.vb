﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.btUsuarios = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btCambiar = New System.Windows.Forms.Button()
        Me.btSalir = New System.Windows.Forms.Button()
        Me.btPagos = New System.Windows.Forms.Button()
        Me.btMovimientos = New System.Windows.Forms.Button()
        Me.btSaldo = New System.Windows.Forms.Button()
        Me.btRetiros = New System.Windows.Forms.Button()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btUsuarios
        '
        Me.btUsuarios.Location = New System.Drawing.Point(23, 612)
        Me.btUsuarios.Name = "btUsuarios"
        Me.btUsuarios.Size = New System.Drawing.Size(75, 23)
        Me.btUsuarios.TabIndex = 21
        Me.btUsuarios.Text = "Agregar"
        Me.btUsuarios.UseVisualStyleBackColor = True
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Image = Global.BanCP.My.Resources.Resources.bancp1
        Me.pictureBox2.Location = New System.Drawing.Point(254, 85)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(331, 331)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox2.TabIndex = 22
        Me.pictureBox2.TabStop = False
        '
        'btCambiar
        '
        Me.btCambiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCambiar.Image = Global.BanCP.My.Resources.Resources.btnCambiarPIN
        Me.btCambiar.Location = New System.Drawing.Point(662, 413)
        Me.btCambiar.Name = "btCambiar"
        Me.btCambiar.Size = New System.Drawing.Size(167, 63)
        Me.btCambiar.TabIndex = 20
        Me.btCambiar.UseVisualStyleBackColor = False
        '
        'btSalir
        '
        Me.btSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSalir.Image = Global.BanCP.My.Resources.Resources.btnSalir
        Me.btSalir.Location = New System.Drawing.Point(662, 521)
        Me.btSalir.Name = "btSalir"
        Me.btSalir.Size = New System.Drawing.Size(167, 63)
        Me.btSalir.TabIndex = 19
        Me.btSalir.UseVisualStyleBackColor = False
        '
        'btPagos
        '
        Me.btPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPagos.Image = Global.BanCP.My.Resources.Resources.btnPagos
        Me.btPagos.Location = New System.Drawing.Point(662, 304)
        Me.btPagos.Name = "btPagos"
        Me.btPagos.Size = New System.Drawing.Size(167, 63)
        Me.btPagos.TabIndex = 18
        Me.btPagos.UseVisualStyleBackColor = False
        '
        'btMovimientos
        '
        Me.btMovimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMovimientos.Image = Global.BanCP.My.Resources.Resources.btnMovimientos
        Me.btMovimientos.Location = New System.Drawing.Point(23, 519)
        Me.btMovimientos.Name = "btMovimientos"
        Me.btMovimientos.Size = New System.Drawing.Size(167, 63)
        Me.btMovimientos.TabIndex = 17
        Me.btMovimientos.UseVisualStyleBackColor = False
        '
        'btSaldo
        '
        Me.btSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSaldo.Image = Global.BanCP.My.Resources.Resources.btnSaldo
        Me.btSaldo.Location = New System.Drawing.Point(23, 413)
        Me.btSaldo.Name = "btSaldo"
        Me.btSaldo.Size = New System.Drawing.Size(167, 63)
        Me.btSaldo.TabIndex = 16
        Me.btSaldo.UseVisualStyleBackColor = False
        '
        'btRetiros
        '
        Me.btRetiros.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRetiros.Image = Global.BanCP.My.Resources.Resources.btnRetiros
        Me.btRetiros.Location = New System.Drawing.Point(23, 304)
        Me.btRetiros.Name = "btRetiros"
        Me.btRetiros.Size = New System.Drawing.Size(167, 63)
        Me.btRetiros.TabIndex = 15
        Me.btRetiros.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(841, 659)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.btUsuarios)
        Me.Controls.Add(Me.btCambiar)
        Me.Controls.Add(Me.btSalir)
        Me.Controls.Add(Me.btPagos)
        Me.Controls.Add(Me.btMovimientos)
        Me.Controls.Add(Me.btSaldo)
        Me.Controls.Add(Me.btRetiros)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
