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
        Me.lbIntentos = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.tbPIN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Image = Global.BanCP.My.Resources.Resources.bancplogo
        Me.pictureBox2.Location = New System.Drawing.Point(136, -5)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(284, 169)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox2.TabIndex = 18
        Me.pictureBox2.TabStop = False
        '
        'lbIntentos
        '
        Me.lbIntentos.AutoSize = True
        Me.lbIntentos.BackColor = System.Drawing.Color.Transparent
        Me.lbIntentos.Font = New System.Drawing.Font("Bentham", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbIntentos.ForeColor = System.Drawing.Color.White
        Me.lbIntentos.Location = New System.Drawing.Point(408, 202)
        Me.lbIntentos.Name = "lbIntentos"
        Me.lbIntentos.Size = New System.Drawing.Size(122, 23)
        Me.lbIntentos.TabIndex = 16
        Me.lbIntentos.Text = "                            "
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(241, 142)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(63, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Insertar PIN"
        '
        'tbPIN
        '
        Me.tbPIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPIN.Location = New System.Drawing.Point(176, 185)
        Me.tbPIN.MaxLength = 4
        Me.tbPIN.Name = "tbPIN"
        Me.tbPIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPIN.Size = New System.Drawing.Size(202, 62)
        Me.tbPIN.TabIndex = 14
        Me.tbPIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bentham", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(221, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 21)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Insertar PIN"
        '
        'LoginPIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(610, 291)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.lbIntentos)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.tbPIN)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginPIN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insertar PIN"
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents lbIntentos As Label
    Private WithEvents label2 As Label
    Private WithEvents tbPIN As TextBox
    Friend WithEvents Label1 As Label
End Class
