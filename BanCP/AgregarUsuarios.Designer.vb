<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarUsuarios
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
        Me.btRegresar = New System.Windows.Forms.Button()
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero_tarjeta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbConfirmar = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPIN = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBusu = New System.Windows.Forms.ComboBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btRegresar
        '
        Me.btRegresar.Location = New System.Drawing.Point(893, 404)
        Me.btRegresar.Name = "btRegresar"
        Me.btRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btRegresar.TabIndex = 45
        Me.btRegresar.Text = "Regresar"
        Me.btRegresar.UseVisualStyleBackColor = True
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AllowUserToAddRows = False
        Me.dgUsuarios.AllowUserToDeleteRows = False
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombres, Me.Apellidos, Me.Direccion, Me.Saldo, Me.Numero_tarjeta, Me.PIN, Me.FechaAlta, Me.TipoUsuario})
        Me.dgUsuarios.Location = New System.Drawing.Point(431, 113)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.ReadOnly = True
        Me.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUsuarios.Size = New System.Drawing.Size(552, 267)
        Me.dgUsuarios.TabIndex = 44
        '
        'Nombres
        '
        Me.Nombres.DataPropertyName = "Nombres"
        Me.Nombres.HeaderText = "Nombre"
        Me.Nombres.Name = "Nombres"
        Me.Nombres.ReadOnly = True
        '
        'Apellidos
        '
        Me.Apellidos.DataPropertyName = "Apellidos"
        Me.Apellidos.HeaderText = "Apellido"
        Me.Apellidos.Name = "Apellidos"
        Me.Apellidos.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'Saldo
        '
        Me.Saldo.DataPropertyName = "Saldo"
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        '
        'Numero_tarjeta
        '
        Me.Numero_tarjeta.DataPropertyName = "Numero_tarjeta"
        Me.Numero_tarjeta.HeaderText = "No. Tarjeta"
        Me.Numero_tarjeta.Name = "Numero_tarjeta"
        Me.Numero_tarjeta.ReadOnly = True
        Me.Numero_tarjeta.Visible = False
        '
        'PIN
        '
        Me.PIN.DataPropertyName = "PIN"
        Me.PIN.HeaderText = "PIN"
        Me.PIN.Name = "PIN"
        Me.PIN.ReadOnly = True
        Me.PIN.Visible = False
        '
        'FechaAlta
        '
        Me.FechaAlta.DataPropertyName = "FechaAlta"
        Me.FechaAlta.HeaderText = "Fecha_Alta"
        Me.FechaAlta.Name = "FechaAlta"
        Me.FechaAlta.ReadOnly = True
        Me.FechaAlta.Visible = False
        '
        'TipoUsuario
        '
        Me.TipoUsuario.DataPropertyName = "TipoUsuario"
        Me.TipoUsuario.HeaderText = "Tipo"
        Me.TipoUsuario.Name = "TipoUsuario"
        Me.TipoUsuario.ReadOnly = True
        Me.TipoUsuario.Visible = False
        '
        'lbConfirmar
        '
        Me.lbConfirmar.AutoSize = True
        Me.lbConfirmar.BackColor = System.Drawing.Color.Transparent
        Me.lbConfirmar.ForeColor = System.Drawing.Color.White
        Me.lbConfirmar.Location = New System.Drawing.Point(144, 372)
        Me.lbConfirmar.Name = "lbConfirmar"
        Me.lbConfirmar.Size = New System.Drawing.Size(163, 13)
        Me.lbConfirmar.TabIndex = 43
        Me.lbConfirmar.Text = "                                                    "
        '
        'txtSaldo
        '
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldo.Location = New System.Drawing.Point(234, 188)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSaldo.Size = New System.Drawing.Size(146, 26)
        Me.txtSaldo.TabIndex = 37
        '
        'btAgregar
        '
        Me.btAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(22, 409)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(109, 35)
        Me.btAgregar.TabIndex = 41
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(234, 316)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(146, 26)
        Me.txtDireccion.TabIndex = 40
        '
        'txtApellidos
        '
        Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(234, 275)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(146, 26)
        Me.txtApellidos.TabIndex = 39
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(234, 232)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(146, 26)
        Me.txtNombre.TabIndex = 38
        '
        'txtPIN
        '
        Me.txtPIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPIN.Location = New System.Drawing.Point(234, 143)
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPIN.Size = New System.Drawing.Size(146, 26)
        Me.txtPIN.TabIndex = 36
        '
        'txtNumero
        '
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(234, 99)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(146, 26)
        Me.txtNumero.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Numero de Tarjeta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(190, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "PIN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Saldo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(171, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Nombres:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 288)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Apellidos:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Dirección:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(138, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Tipo de Usuario:"
        '
        'CBusu
        '
        Me.CBusu.FormattingEnabled = True
        Me.CBusu.Items.AddRange(New Object() {"ADMINISTRATOR", "USUARIO"})
        Me.CBusu.Location = New System.Drawing.Point(234, 368)
        Me.CBusu.Name = "CBusu"
        Me.CBusu.Size = New System.Drawing.Size(146, 21)
        Me.CBusu.TabIndex = 53
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Image = Global.BanCP.My.Resources.Resources.Logo
        Me.pictureBox2.Location = New System.Drawing.Point(671, 12)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(271, 93)
        Me.pictureBox2.TabIndex = 54
        Me.pictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.BanCP.My.Resources.Resources.cooltext215312682298178
        Me.PictureBox1.Location = New System.Drawing.Point(94, 316)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 43)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Image = Global.BanCP.My.Resources.Resources.cooltext215311768361331
        Me.PictureBox3.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(531, 64)
        Me.PictureBox3.TabIndex = 56
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox4.Image = Global.BanCP.My.Resources.Resources.numTarjeta
        Me.PictureBox4.Location = New System.Drawing.Point(22, 82)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(206, 43)
        Me.PictureBox4.TabIndex = 57
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox5.Image = Global.BanCP.My.Resources.Resources.PIN
        Me.PictureBox5.Location = New System.Drawing.Point(159, 131)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(69, 43)
        Me.PictureBox5.TabIndex = 58
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox6.Image = Global.BanCP.My.Resources.Resources.Apellido
        Me.PictureBox6.Location = New System.Drawing.Point(104, 275)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(124, 43)
        Me.PictureBox6.TabIndex = 59
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox7.Image = Global.BanCP.My.Resources.Resources.nombre
        Me.PictureBox7.Location = New System.Drawing.Point(109, 232)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(119, 43)
        Me.PictureBox7.TabIndex = 60
        Me.PictureBox7.TabStop = False
        '
        'btEliminar
        '
        Me.btEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.Location = New System.Drawing.Point(166, 409)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(109, 35)
        Me.btEliminar.TabIndex = 61
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = True
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox8.Image = Global.BanCP.My.Resources.Resources.saldoingresar
        Me.PictureBox8.Location = New System.Drawing.Point(128, 180)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(100, 43)
        Me.PictureBox8.TabIndex = 62
        Me.PictureBox8.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox9.Image = Global.BanCP.My.Resources.Resources.TipoUser
        Me.PictureBox9.Location = New System.Drawing.Point(-5, 355)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(233, 43)
        Me.PictureBox9.TabIndex = 63
        Me.PictureBox9.TabStop = False
        '
        'AgregarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BanCP.My.Resources.Resources.image
        Me.ClientSize = New System.Drawing.Size(1005, 456)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.CBusu)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btRegresar)
        Me.Controls.Add(Me.dgUsuarios)
        Me.Controls.Add(Me.lbConfirmar)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtPIN)
        Me.Controls.Add(Me.txtNumero)
        Me.Name = "AgregarUsuarios"
        Me.Text = "AgregarUsuarios"
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btRegresar As Button
    Private WithEvents dgUsuarios As DataGridView
    Private WithEvents lbConfirmar As Label
    Private WithEvents txtSaldo As TextBox
    Private WithEvents btAgregar As Button
    Private WithEvents txtDireccion As TextBox
    Private WithEvents txtApellidos As TextBox
    Private WithEvents txtNombre As TextBox
    Private WithEvents txtPIN As TextBox
    Private WithEvents txtNumero As TextBox
    Friend WithEvents Nombres As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Numero_tarjeta As DataGridViewTextBoxColumn
    Friend WithEvents PIN As DataGridViewTextBoxColumn
    Friend WithEvents FechaAlta As DataGridViewTextBoxColumn
    Friend WithEvents TipoUsuario As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CBusu As ComboBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents PictureBox1 As PictureBox
    Private WithEvents PictureBox3 As PictureBox
    Private WithEvents PictureBox4 As PictureBox
    Private WithEvents PictureBox5 As PictureBox
    Private WithEvents PictureBox6 As PictureBox
    Private WithEvents PictureBox7 As PictureBox
    Private WithEvents btEliminar As Button
    Private WithEvents PictureBox8 As PictureBox
    Private WithEvents PictureBox9 As PictureBox
End Class
