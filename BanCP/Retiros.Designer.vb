<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Retiros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Retiros))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btAtras = New System.Windows.Forms.Button()
        Me.bt2000 = New System.Windows.Forms.Button()
        Me.btOtra = New System.Windows.Forms.Button()
        Me.bt1000 = New System.Windows.Forms.Button()
        Me.bt500 = New System.Windows.Forms.Button()
        Me.bt200 = New System.Windows.Forms.Button()
        Me.bt50 = New System.Windows.Forms.Button()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox1.Image = Global.BanCP.My.Resources.Resources.retiros
        Me.pictureBox1.Location = New System.Drawing.Point(251, 23)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(219, 87)
        Me.pictureBox1.TabIndex = 24
        Me.pictureBox1.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Image = Global.BanCP.My.Resources.Resources.bancp1
        Me.pictureBox2.Location = New System.Drawing.Point(194, 102)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(331, 331)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox2.TabIndex = 23
        Me.pictureBox2.TabStop = False
        '
        'btAtras
        '
        Me.btAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtras.Location = New System.Drawing.Point(42, 464)
        Me.btAtras.Name = "btAtras"
        Me.btAtras.Size = New System.Drawing.Size(131, 36)
        Me.btAtras.TabIndex = 22
        Me.btAtras.Text = "Atras"
        Me.btAtras.UseVisualStyleBackColor = True
        '
        'bt2000
        '
        Me.bt2000.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt2000.Location = New System.Drawing.Point(547, 295)
        Me.bt2000.Name = "bt2000"
        Me.bt2000.Size = New System.Drawing.Size(131, 42)
        Me.bt2000.TabIndex = 21
        Me.bt2000.Text = "2000"
        Me.bt2000.UseVisualStyleBackColor = False
        '
        'btOtra
        '
        Me.btOtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btOtra.Location = New System.Drawing.Point(547, 382)
        Me.btOtra.Name = "btOtra"
        Me.btOtra.Size = New System.Drawing.Size(131, 42)
        Me.btOtra.TabIndex = 20
        Me.btOtra.Text = "Otra Cantidad.."
        Me.btOtra.UseVisualStyleBackColor = False
        '
        'bt1000
        '
        Me.bt1000.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt1000.Location = New System.Drawing.Point(547, 204)
        Me.bt1000.Name = "bt1000"
        Me.bt1000.Size = New System.Drawing.Size(131, 44)
        Me.bt1000.TabIndex = 19
        Me.bt1000.Text = "1000"
        Me.bt1000.UseVisualStyleBackColor = False
        '
        'bt500
        '
        Me.bt500.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt500.Location = New System.Drawing.Point(42, 382)
        Me.bt500.Name = "bt500"
        Me.bt500.Size = New System.Drawing.Size(131, 42)
        Me.bt500.TabIndex = 18
        Me.bt500.Text = "500"
        Me.bt500.UseVisualStyleBackColor = False
        '
        'bt200
        '
        Me.bt200.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt200.Location = New System.Drawing.Point(42, 295)
        Me.bt200.Name = "bt200"
        Me.bt200.Size = New System.Drawing.Size(131, 43)
        Me.bt200.TabIndex = 17
        Me.bt200.Text = "200"
        Me.bt200.UseVisualStyleBackColor = False
        '
        'bt50
        '
        Me.bt50.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt50.Location = New System.Drawing.Point(42, 215)
        Me.bt50.Name = "bt50"
        Me.bt50.Size = New System.Drawing.Size(131, 42)
        Me.bt50.TabIndex = 16
        Me.bt50.Text = "50"
        Me.bt50.UseVisualStyleBackColor = False
        '
        'Retiros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(720, 512)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.btAtras)
        Me.Controls.Add(Me.bt2000)
        Me.Controls.Add(Me.btOtra)
        Me.Controls.Add(Me.bt1000)
        Me.Controls.Add(Me.bt500)
        Me.Controls.Add(Me.bt200)
        Me.Controls.Add(Me.bt50)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Retiros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retiros"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents btAtras As Button
    Private WithEvents bt2000 As Button
    Private WithEvents btOtra As Button
    Private WithEvents bt1000 As Button
    Private WithEvents bt500 As Button
    Private WithEvents bt200 As Button
    Private WithEvents bt50 As Button
End Class
