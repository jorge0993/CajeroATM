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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarUsuarios))
        Me.btRegresar = New System.Windows.Forms.Button()
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.Numero_tarjeta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombres = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaAlta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbConfirmar = New System.Windows.Forms.Label()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPIN = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBusu = New System.Windows.Forms.ComboBox()
        Me.btEliminar = New System.Windows.Forms.Button()
        Me.btModificar = New System.Windows.Forms.Button()
        Me.btLimpiar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btRegresar
        '
        Me.btRegresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegresar.Location = New System.Drawing.Point(12, 409)
        Me.btRegresar.Name = "btRegresar"
        Me.btRegresar.Size = New System.Drawing.Size(108, 35)
        Me.btRegresar.TabIndex = 45
        Me.btRegresar.Text = "Regresar"
        Me.btRegresar.UseVisualStyleBackColor = False
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AllowUserToAddRows = False
        Me.dgUsuarios.AllowUserToDeleteRows = False
        Me.dgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Numero_tarjeta, Me.Nombres, Me.Apellidos, Me.Direccion, Me.TipoUsuario, Me.PIN, Me.Saldo, Me.FechaAlta})
        Me.dgUsuarios.Location = New System.Drawing.Point(406, 113)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.ReadOnly = True
        Me.dgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUsuarios.Size = New System.Drawing.Size(577, 267)
        Me.dgUsuarios.TabIndex = 44
        '
        'Numero_tarjeta
        '
        Me.Numero_tarjeta.DataPropertyName = "Numero_tarjeta"
        Me.Numero_tarjeta.HeaderText = "No. Tarjeta"
        Me.Numero_tarjeta.Name = "Numero_tarjeta"
        Me.Numero_tarjeta.ReadOnly = True
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
        'TipoUsuario
        '
        Me.TipoUsuario.DataPropertyName = "TipoUsuario"
        Me.TipoUsuario.HeaderText = "Tipo"
        Me.TipoUsuario.Name = "TipoUsuario"
        Me.TipoUsuario.ReadOnly = True
        '
        'PIN
        '
        Me.PIN.DataPropertyName = "PIN"
        Me.PIN.HeaderText = "PIN"
        Me.PIN.Name = "PIN"
        Me.PIN.ReadOnly = True
        Me.PIN.Visible = False
        '
        'Saldo
        '
        Me.Saldo.DataPropertyName = "Saldo"
        Me.Saldo.HeaderText = "Saldo"
        Me.Saldo.Name = "Saldo"
        Me.Saldo.ReadOnly = True
        Me.Saldo.Visible = False
        '
        'FechaAlta
        '
        Me.FechaAlta.DataPropertyName = "FechaAlta"
        Me.FechaAlta.HeaderText = "Fecha_Alta"
        Me.FechaAlta.Name = "FechaAlta"
        Me.FechaAlta.ReadOnly = True
        Me.FechaAlta.Visible = False
        '
        'lbConfirmar
        '
        Me.lbConfirmar.AutoSize = True
        Me.lbConfirmar.BackColor = System.Drawing.Color.Transparent
        Me.lbConfirmar.ForeColor = System.Drawing.Color.White
        Me.lbConfirmar.Location = New System.Drawing.Point(144, 325)
        Me.lbConfirmar.Name = "lbConfirmar"
        Me.lbConfirmar.Size = New System.Drawing.Size(163, 13)
        Me.lbConfirmar.TabIndex = 43
        Me.lbConfirmar.Text = "                                                    "
        '
        'btAgregar
        '
        Me.btAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(322, 409)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(109, 35)
        Me.btAgregar.TabIndex = 41
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = False
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(234, 269)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(146, 26)
        Me.txtDireccion.TabIndex = 40
        '
        'txtApellidos
        '
        Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(234, 228)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(146, 26)
        Me.txtApellidos.TabIndex = 39
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(234, 185)
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
        Me.txtNumero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNumero.Size = New System.Drawing.Size(146, 26)
        Me.txtNumero.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bentham", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 21)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Numero de Tarjeta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bentham", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "PIN:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bentham", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(145, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bentham", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(138, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 21)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Apellido:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bentham", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(127, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 21)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Dirección:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bentham", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(79, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(139, 21)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Tipo de Usuario:"
        '
        'CBusu
        '
        Me.CBusu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBusu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CBusu.FormattingEnabled = True
        Me.CBusu.Items.AddRange(New Object() {"ADMINISTRATOR", "USUARIO"})
        Me.CBusu.Location = New System.Drawing.Point(234, 321)
        Me.CBusu.Name = "CBusu"
        Me.CBusu.Size = New System.Drawing.Size(146, 21)
        Me.CBusu.TabIndex = 53
        '
        'btEliminar
        '
        Me.btEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEliminar.Location = New System.Drawing.Point(466, 409)
        Me.btEliminar.Name = "btEliminar"
        Me.btEliminar.Size = New System.Drawing.Size(109, 35)
        Me.btEliminar.TabIndex = 61
        Me.btEliminar.Text = "Eliminar"
        Me.btEliminar.UseVisualStyleBackColor = False
        '
        'btModificar
        '
        Me.btModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btModificar.Location = New System.Drawing.Point(610, 409)
        Me.btModificar.Name = "btModificar"
        Me.btModificar.Size = New System.Drawing.Size(109, 35)
        Me.btModificar.TabIndex = 64
        Me.btModificar.Text = "Modificar"
        Me.btModificar.UseVisualStyleBackColor = False
        Me.btModificar.Visible = False
        '
        'btLimpiar
        '
        Me.btLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btLimpiar.Location = New System.Drawing.Point(850, 409)
        Me.btLimpiar.Name = "btLimpiar"
        Me.btLimpiar.Size = New System.Drawing.Size(133, 35)
        Me.btLimpiar.TabIndex = 65
        Me.btLimpiar.Text = "Limpiar campos"
        Me.btLimpiar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Benne Text", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(124, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 41)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Agregar usuarios"
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Image = Global.BanCP.My.Resources.Resources.bancplogo
        Me.pictureBox2.Location = New System.Drawing.Point(671, 12)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(271, 93)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pictureBox2.TabIndex = 54
        Me.pictureBox2.TabStop = False
        '
        'AgregarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1005, 456)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btLimpiar)
        Me.Controls.Add(Me.btModificar)
        Me.Controls.Add(Me.btEliminar)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.CBusu)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btRegresar)
        Me.Controls.Add(Me.dgUsuarios)
        Me.Controls.Add(Me.lbConfirmar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtPIN)
        Me.Controls.Add(Me.txtNumero)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgregarUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarUsuarios"
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btRegresar As Button
    Private WithEvents dgUsuarios As DataGridView
    Private WithEvents lbConfirmar As Label
    Private WithEvents btAgregar As Button
    Private WithEvents txtDireccion As TextBox
    Private WithEvents txtApellidos As TextBox
    Private WithEvents txtNombre As TextBox
    Private WithEvents txtPIN As TextBox
    Private WithEvents txtNumero As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CBusu As ComboBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents btEliminar As Button
    Private WithEvents btModificar As Button
    Friend WithEvents Numero_tarjeta As DataGridViewTextBoxColumn
    Friend WithEvents Nombres As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents TipoUsuario As DataGridViewTextBoxColumn
    Friend WithEvents PIN As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents FechaAlta As DataGridViewTextBoxColumn
    Private WithEvents btLimpiar As Button
    Friend WithEvents Label3 As Label
End Class
