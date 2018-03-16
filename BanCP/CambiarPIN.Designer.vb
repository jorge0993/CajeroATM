<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CambiarPIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CambiarPIN))
        Me.lbConfirmar = New System.Windows.Forms.Label()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.tbConfirmar = New System.Windows.Forms.TextBox()
        Me.tbNuevo = New System.Windows.Forms.TextBox()
        Me.tbPIN = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbConfirmar
        '
        Me.lbConfirmar.AutoSize = True
        Me.lbConfirmar.BackColor = System.Drawing.Color.Transparent
        Me.lbConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConfirmar.ForeColor = System.Drawing.Color.White
        Me.lbConfirmar.Location = New System.Drawing.Point(675, 362)
        Me.lbConfirmar.Name = "lbConfirmar"
        Me.lbConfirmar.Size = New System.Drawing.Size(109, 20)
        Me.lbConfirmar.TabIndex = 33
        Me.lbConfirmar.Text = "                         "
        '
        'btnAtras
        '
        Me.btnAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtras.ForeColor = System.Drawing.Color.Black
        Me.btnAtras.Location = New System.Drawing.Point(12, 611)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(108, 36)
        Me.btnAtras.TabIndex = 27
        Me.btnAtras.Text = "Atras"
        Me.btnAtras.UseVisualStyleBackColor = False
        '
        'tbConfirmar
        '
        Me.tbConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConfirmar.Location = New System.Drawing.Point(429, 404)
        Me.tbConfirmar.Name = "tbConfirmar"
        Me.tbConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbConfirmar.Size = New System.Drawing.Size(185, 31)
        Me.tbConfirmar.TabIndex = 26
        '
        'tbNuevo
        '
        Me.tbNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNuevo.Location = New System.Drawing.Point(429, 351)
        Me.tbNuevo.Name = "tbNuevo"
        Me.tbNuevo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbNuevo.Size = New System.Drawing.Size(185, 31)
        Me.tbNuevo.TabIndex = 25
        '
        'tbPIN
        '
        Me.tbPIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPIN.Location = New System.Drawing.Point(429, 291)
        Me.tbPIN.Name = "tbPIN"
        Me.tbPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPIN.Size = New System.Drawing.Size(185, 31)
        Me.tbPIN.TabIndex = 24
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Black
        Me.btnAceptar.Location = New System.Drawing.Point(374, 484)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 40)
        Me.btnAceptar.TabIndex = 23
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Image = Global.BanCP.My.Resources.Resources.minibancp
        Me.pictureBox2.Location = New System.Drawing.Point(346, 37)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(154, 154)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox2.TabIndex = 28
        Me.pictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bentham", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 21)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Escribir contraseña actual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bentham", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(202, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(221, 21)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Escribir nueva contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bentham", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(234, 411)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 21)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Confirmar contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bentham", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(317, 220)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(207, 39)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Cambiar PIN"
        '
        'CambiarPIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(841, 659)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbConfirmar)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.btnAtras)
        Me.Controls.Add(Me.tbConfirmar)
        Me.Controls.Add(Me.tbNuevo)
        Me.Controls.Add(Me.tbPIN)
        Me.Controls.Add(Me.btnAceptar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CambiarPIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CambiarPIN"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lbConfirmar As Label
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents btnAtras As Button
    Private WithEvents tbConfirmar As TextBox
    Private WithEvents tbNuevo As TextBox
    Private WithEvents tbPIN As TextBox
    Private WithEvents btnAceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
