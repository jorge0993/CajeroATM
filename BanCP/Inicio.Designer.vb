<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.tbTarjeta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.pictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbTarjeta
        '
        Me.tbTarjeta.Location = New System.Drawing.Point(361, 442)
        Me.tbTarjeta.Name = "tbTarjeta"
        Me.tbTarjeta.Size = New System.Drawing.Size(130, 20)
        Me.tbTarjeta.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(295, 429)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(243, 33)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Ingresar tu tarjeta"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.BanCP.My.Resources.Resources.Tarjeta_de_Credito2
        Me.PictureBox1.Location = New System.Drawing.Point(284, 509)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 170)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'pictureBox6
        '
        Me.pictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox6.Image = Global.BanCP.My.Resources.Resources.flecha1
        Me.pictureBox6.Location = New System.Drawing.Point(806, 643)
        Me.pictureBox6.Name = "pictureBox6"
        Me.pictureBox6.Size = New System.Drawing.Size(49, 46)
        Me.pictureBox6.TabIndex = 21
        Me.pictureBox6.TabStop = False
        '
        'pictureBox5
        '
        Me.pictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox5.Image = Global.BanCP.My.Resources.Resources.bancp1
        Me.pictureBox5.Location = New System.Drawing.Point(243, 12)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(348, 357)
        Me.pictureBox5.TabIndex = 20
        Me.pictureBox5.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = Global.BanCP.My.Resources.Resources.comprar_online_con_seguridad
        Me.pictureBox2.Location = New System.Drawing.Point(24, 656)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(99, 33)
        Me.pictureBox2.TabIndex = 17
        Me.pictureBox2.TabStop = False
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(867, 701)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pictureBox6)
        Me.Controls.Add(Me.pictureBox5)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.tbTarjeta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox6 As PictureBox
    Private WithEvents pictureBox5 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents tbTarjeta As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
