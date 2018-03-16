<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginPIN))
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbIntentos = New System.Windows.Forms.Label()
        Me.tbPIN = New System.Windows.Forms.TextBox()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Image = Global.BanCP.My.Resources.Resources.minibancp
        Me.pictureBox2.Location = New System.Drawing.Point(200, 1)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(154, 154)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox2.TabIndex = 18
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.Image = Global.BanCP.My.Resources.Resources.Insertar
        Me.pictureBox1.Location = New System.Drawing.Point(200, 187)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(160, 36)
        Me.pictureBox1.TabIndex = 17
        Me.pictureBox1.TabStop = False
        '
        'lbIntentos
        '
        Me.lbIntentos.AutoSize = True
        Me.lbIntentos.BackColor = System.Drawing.Color.Transparent
        Me.lbIntentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIntentos.ForeColor = System.Drawing.Color.SteelBlue
        Me.lbIntentos.Location = New System.Drawing.Point(402, 235)
        Me.lbIntentos.Name = "lbIntentos"
        Me.lbIntentos.Size = New System.Drawing.Size(150, 24)
        Me.lbIntentos.TabIndex = 16
        Me.lbIntentos.Text = "                            "
        '
        'tbPIN
        '
        Me.tbPIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPIN.Location = New System.Drawing.Point(174, 229)
        Me.tbPIN.Name = "tbPIN"
        Me.tbPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPIN.Size = New System.Drawing.Size(202, 62)
        Me.tbPIN.TabIndex = 14
        Me.tbPIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LoginPIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(609, 327)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.lbIntentos)
        Me.Controls.Add(Me.tbPIN)
        Me.Controls.Add(Me.pictureBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginPIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginPIN"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents lbIntentos As Label
    Private WithEvents tbPIN As TextBox
End Class
