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
        Me.tbConfirmar = New System.Windows.Forms.TextBox()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.lbTiempo = New System.Windows.Forms.Label()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbPIN = New System.Windows.Forms.TextBox()
        Me.tbTarjeta = New System.Windows.Forms.TextBox()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbConfirmar.Location = New System.Drawing.Point(128, 367)
        Me.lbConfirmar.Name = "lbConfirmar"
        Me.lbConfirmar.Size = New System.Drawing.Size(163, 13)
        Me.lbConfirmar.TabIndex = 43
        Me.lbConfirmar.Text = "                                                    "
        '
        'tbConfirmar
        '
        Me.tbConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConfirmar.Location = New System.Drawing.Point(213, 223)
        Me.tbConfirmar.Name = "tbConfirmar"
        Me.tbConfirmar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbConfirmar.Size = New System.Drawing.Size(146, 26)
        Me.tbConfirmar.TabIndex = 37
        '
        'btAgregar
        '
        Me.btAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAgregar.Location = New System.Drawing.Point(153, 392)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(109, 35)
        Me.btAgregar.TabIndex = 41
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = True
        '
        'lbTiempo
        '
        Me.lbTiempo.AutoSize = True
        Me.lbTiempo.BackColor = System.Drawing.Color.Transparent
        Me.lbTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTiempo.ForeColor = System.Drawing.Color.White
        Me.lbTiempo.Location = New System.Drawing.Point(100, 113)
        Me.lbTiempo.Name = "lbTiempo"
        Me.lbTiempo.Size = New System.Drawing.Size(217, 20)
        Me.lbTiempo.TabIndex = 42
        Me.lbTiempo.Text = "                                                    "
        '
        'tbDireccion
        '
        Me.tbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDireccion.Location = New System.Drawing.Point(213, 319)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(146, 26)
        Me.tbDireccion.TabIndex = 40
        '
        'tbApellidos
        '
        Me.tbApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellidos.Location = New System.Drawing.Point(213, 287)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.Size = New System.Drawing.Size(146, 26)
        Me.tbApellidos.TabIndex = 39
        '
        'tbNombre
        '
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(213, 255)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(146, 26)
        Me.tbNombre.TabIndex = 38
        '
        'tbPIN
        '
        Me.tbPIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPIN.Location = New System.Drawing.Point(213, 191)
        Me.tbPIN.Name = "tbPIN"
        Me.tbPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPIN.Size = New System.Drawing.Size(146, 26)
        Me.tbPIN.TabIndex = 36
        '
        'tbTarjeta
        '
        Me.tbTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTarjeta.Location = New System.Drawing.Point(213, 158)
        Me.tbTarjeta.Name = "tbTarjeta"
        Me.tbTarjeta.Size = New System.Drawing.Size(146, 26)
        Me.tbTarjeta.TabIndex = 35
        '
        'AgregarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 456)
        Me.Controls.Add(Me.btRegresar)
        Me.Controls.Add(Me.dgUsuarios)
        Me.Controls.Add(Me.lbConfirmar)
        Me.Controls.Add(Me.tbConfirmar)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.lbTiempo)
        Me.Controls.Add(Me.tbDireccion)
        Me.Controls.Add(Me.tbApellidos)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbPIN)
        Me.Controls.Add(Me.tbTarjeta)
        Me.Name = "AgregarUsuarios"
        Me.Text = "AgregarUsuarios"
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btRegresar As Button
    Private WithEvents dgUsuarios As DataGridView
    Private WithEvents lbConfirmar As Label
    Private WithEvents tbConfirmar As TextBox
    Private WithEvents btAgregar As Button
    Private WithEvents lbTiempo As Label
    Private WithEvents tbDireccion As TextBox
    Private WithEvents tbApellidos As TextBox
    Private WithEvents tbNombre As TextBox
    Private WithEvents tbPIN As TextBox
    Private WithEvents tbTarjeta As TextBox
    Friend WithEvents Nombres As DataGridViewTextBoxColumn
    Friend WithEvents Apellidos As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Saldo As DataGridViewTextBoxColumn
    Friend WithEvents Numero_tarjeta As DataGridViewTextBoxColumn
    Friend WithEvents PIN As DataGridViewTextBoxColumn
    Friend WithEvents FechaAlta As DataGridViewTextBoxColumn
    Friend WithEvents TipoUsuario As DataGridViewTextBoxColumn
End Class
