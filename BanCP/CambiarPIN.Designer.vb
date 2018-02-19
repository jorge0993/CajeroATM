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
        Me.lbConfirmar = New System.Windows.Forms.Label()
        Me.pictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.button2 = New System.Windows.Forms.Button()
        Me.tbConfirmar = New System.Windows.Forms.TextBox()
        Me.tbNuevo = New System.Windows.Forms.TextBox()
        Me.tbPIN = New System.Windows.Forms.TextBox()
        Me.button1 = New System.Windows.Forms.Button()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbConfirmar
        '
        Me.lbConfirmar.AutoSize = True
        Me.lbConfirmar.BackColor = System.Drawing.Color.Transparent
        Me.lbConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConfirmar.ForeColor = System.Drawing.Color.White
        Me.lbConfirmar.Location = New System.Drawing.Point(530, 276)
        Me.lbConfirmar.Name = "lbConfirmar"
        Me.lbConfirmar.Size = New System.Drawing.Size(109, 20)
        Me.lbConfirmar.TabIndex = 33
        Me.lbConfirmar.Text = "                         "
        '
        'pictureBox5
        '
        Me.pictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox5.Location = New System.Drawing.Point(121, 72)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(329, 67)
        Me.pictureBox5.TabIndex = 32
        Me.pictureBox5.TabStop = False
        '
        'pictureBox4
        '
        Me.pictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox4.Location = New System.Drawing.Point(56, 269)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(266, 39)
        Me.pictureBox4.TabIndex = 31
        Me.pictureBox4.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox3.Location = New System.Drawing.Point(11, 145)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(311, 42)
        Me.pictureBox3.TabIndex = 30
        Me.pictureBox3.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox1.Location = New System.Drawing.Point(12, 206)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(310, 41)
        Me.pictureBox1.TabIndex = 29
        Me.pictureBox1.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Location = New System.Drawing.Point(566, 52)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(138, 57)
        Me.pictureBox2.TabIndex = 28
        Me.pictureBox2.TabStop = False
        '
        'button2
        '
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.ForeColor = System.Drawing.Color.Black
        Me.button2.Location = New System.Drawing.Point(2, 336)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(108, 36)
        Me.button2.TabIndex = 27
        Me.button2.Text = "Atras"
        Me.button2.UseVisualStyleBackColor = True
        '
        'tbConfirmar
        '
        Me.tbConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConfirmar.Location = New System.Drawing.Point(328, 269)
        Me.tbConfirmar.Name = "tbConfirmar"
        Me.tbConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbConfirmar.Size = New System.Drawing.Size(185, 31)
        Me.tbConfirmar.TabIndex = 26
        '
        'tbNuevo
        '
        Me.tbNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNuevo.Location = New System.Drawing.Point(328, 216)
        Me.tbNuevo.Name = "tbNuevo"
        Me.tbNuevo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbNuevo.Size = New System.Drawing.Size(185, 31)
        Me.tbNuevo.TabIndex = 25
        '
        'tbPIN
        '
        Me.tbPIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPIN.Location = New System.Drawing.Point(328, 156)
        Me.tbPIN.Name = "tbPIN"
        Me.tbPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPIN.Size = New System.Drawing.Size(185, 31)
        Me.tbPIN.TabIndex = 24
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.ForeColor = System.Drawing.Color.Black
        Me.button1.Location = New System.Drawing.Point(276, 323)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(117, 40)
        Me.button1.TabIndex = 23
        Me.button1.Text = "Aceptar"
        Me.button1.UseVisualStyleBackColor = True
        '
        'CambiarPIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 425)
        Me.Controls.Add(Me.lbConfirmar)
        Me.Controls.Add(Me.pictureBox5)
        Me.Controls.Add(Me.pictureBox4)
        Me.Controls.Add(Me.pictureBox3)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.tbConfirmar)
        Me.Controls.Add(Me.tbNuevo)
        Me.Controls.Add(Me.tbPIN)
        Me.Controls.Add(Me.button1)
        Me.Name = "CambiarPIN"
        Me.Text = "CambiarPIN"
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lbConfirmar As Label
    Private WithEvents pictureBox5 As PictureBox
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents button2 As Button
    Private WithEvents tbConfirmar As TextBox
    Private WithEvents tbNuevo As TextBox
    Private WithEvents tbPIN As TextBox
    Private WithEvents button1 As Button
End Class
