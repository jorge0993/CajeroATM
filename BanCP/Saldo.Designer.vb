<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Saldo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Saldo))
        Me.lbSaldo = New System.Windows.Forms.Label()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btAtras = New System.Windows.Forms.Button()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbSaldo
        '
        Me.lbSaldo.AutoSize = True
        Me.lbSaldo.BackColor = System.Drawing.Color.Transparent
        Me.lbSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSaldo.ForeColor = System.Drawing.Color.Transparent
        Me.lbSaldo.Location = New System.Drawing.Point(301, 267)
        Me.lbSaldo.Name = "lbSaldo"
        Me.lbSaldo.Size = New System.Drawing.Size(123, 37)
        Me.lbSaldo.TabIndex = 22
        Me.lbSaldo.Text = "100000"
        Me.lbSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox1.Image = Global.BanCP.My.Resources.Resources.saldo
        Me.pictureBox1.Location = New System.Drawing.Point(109, 168)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(522, 87)
        Me.pictureBox1.TabIndex = 21
        Me.pictureBox1.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Image = Global.BanCP.My.Resources.Resources.minibancp
        Me.pictureBox2.Location = New System.Drawing.Point(270, 8)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(154, 154)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox2.TabIndex = 20
        Me.pictureBox2.TabStop = False
        '
        'btAtras
        '
        Me.btAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtras.Image = Global.BanCP.My.Resources.Resources.btnAtras
        Me.btAtras.Location = New System.Drawing.Point(26, 363)
        Me.btAtras.Name = "btAtras"
        Me.btAtras.Size = New System.Drawing.Size(195, 42)
        Me.btAtras.TabIndex = 19
        Me.btAtras.UseVisualStyleBackColor = False
        '
        'Saldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(683, 417)
        Me.Controls.Add(Me.lbSaldo)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.btAtras)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Saldo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Saldo"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lbSaldo As Label
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents btAtras As Button
End Class
