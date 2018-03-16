<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Movimientos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movimientos))
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.button1 = New System.Windows.Forms.Button()
        Me.btAtras = New System.Windows.Forms.Button()
        Me.dgMovimientos = New System.Windows.Forms.DataGridView()
        Me.Tarjeta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Image = Global.BanCP.My.Resources.Resources.bancplogo
        Me.pictureBox2.Location = New System.Drawing.Point(211, -17)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(284, 169)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox2.TabIndex = 21
        Me.pictureBox2.TabStop = False
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(568, 420)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(127, 37)
        Me.button1.TabIndex = 20
        Me.button1.Text = "Imprimir"
        Me.button1.UseVisualStyleBackColor = False
        '
        'btAtras
        '
        Me.btAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtras.Location = New System.Drawing.Point(12, 420)
        Me.btAtras.Name = "btAtras"
        Me.btAtras.Size = New System.Drawing.Size(127, 37)
        Me.btAtras.TabIndex = 19
        Me.btAtras.Text = "Atras"
        Me.btAtras.UseVisualStyleBackColor = False
        '
        'dgMovimientos
        '
        Me.dgMovimientos.AllowUserToAddRows = False
        Me.dgMovimientos.AllowUserToDeleteRows = False
        Me.dgMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgMovimientos.BackgroundColor = System.Drawing.Color.White
        Me.dgMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Tarjeta, Me.TipoMovimiento, Me.CantidadMovimiento})
        Me.dgMovimientos.Location = New System.Drawing.Point(93, 101)
        Me.dgMovimientos.Name = "dgMovimientos"
        Me.dgMovimientos.ReadOnly = True
        Me.dgMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMovimientos.Size = New System.Drawing.Size(446, 218)
        Me.dgMovimientos.TabIndex = 18
        '
        'Tarjeta
        '
        Me.Tarjeta.DataPropertyName = "Tarjeta"
        Me.Tarjeta.HeaderText = "No. Tarjeta"
        Me.Tarjeta.Name = "Tarjeta"
        Me.Tarjeta.ReadOnly = True
        Me.Tarjeta.Width = 85
        '
        'TipoMovimiento
        '
        Me.TipoMovimiento.DataPropertyName = "TipoMovimiento"
        Me.TipoMovimiento.HeaderText = "Movimiento"
        Me.TipoMovimiento.Name = "TipoMovimiento"
        Me.TipoMovimiento.ReadOnly = True
        Me.TipoMovimiento.Width = 86
        '
        'CantidadMovimiento
        '
        Me.CantidadMovimiento.DataPropertyName = "CantidadMovimiento"
        Me.CantidadMovimiento.HeaderText = "Cantidad"
        Me.CantidadMovimiento.Name = "CantidadMovimiento"
        Me.CantidadMovimiento.ReadOnly = True
        Me.CantidadMovimiento.Width = 74

        '
        'Movimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(707, 469)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.btAtras)
        Me.Controls.Add(Me.dgMovimientos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Movimientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents button1 As Button
    Private WithEvents btAtras As Button
    Private WithEvents dgMovimientos As DataGridView
    Friend WithEvents Tarjeta As DataGridViewTextBoxColumn
    Friend WithEvents TipoMovimiento As DataGridViewTextBoxColumn
    Friend WithEvents CantidadMovimiento As DataGridViewTextBoxColumn
End Class
