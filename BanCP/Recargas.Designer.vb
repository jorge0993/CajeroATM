<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recargas
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
        Me.button1 = New System.Windows.Forms.Button()
        Me.pictureBox6 = New System.Windows.Forms.PictureBox()
        Me.pictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.tbnumero = New System.Windows.Forms.TextBox()
        Me.comboCantidad = New System.Windows.Forms.ComboBox()
        Me.btPagar = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rdatt = New System.Windows.Forms.RadioButton()
        Me.rdMovistar = New System.Windows.Forms.RadioButton()
        Me.rdTelcel = New System.Windows.Forms.RadioButton()
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(26, 385)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(116, 38)
        Me.button1.TabIndex = 28
        Me.button1.Text = "Atras"
        Me.button1.UseVisualStyleBackColor = True
        '
        'pictureBox6
        '
        Me.pictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox6.Image = Global.BanCP.My.Resources.Resources.tam
        Me.pictureBox6.Location = New System.Drawing.Point(349, 226)
        Me.pictureBox6.Name = "pictureBox6"
        Me.pictureBox6.Size = New System.Drawing.Size(422, 65)
        Me.pictureBox6.TabIndex = 27
        Me.pictureBox6.TabStop = False
        '
        'pictureBox5
        '
        Me.pictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox5.Image = Global.BanCP.My.Resources.Resources.num
        Me.pictureBox5.Location = New System.Drawing.Point(384, 115)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(359, 65)
        Me.pictureBox5.TabIndex = 26
        Me.pictureBox5.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Image = Global.BanCP.My.Resources.Resources.Logo
        Me.pictureBox2.Location = New System.Drawing.Point(440, 12)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(271, 81)
        Me.pictureBox2.TabIndex = 25
        Me.pictureBox2.TabStop = False
        '
        'tbnumero
        '
        Me.tbnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbnumero.Location = New System.Drawing.Point(457, 186)
        Me.tbnumero.Name = "tbnumero"
        Me.tbnumero.Size = New System.Drawing.Size(186, 29)
        Me.tbnumero.TabIndex = 24
        '
        'comboCantidad
        '
        Me.comboCantidad.Enabled = False
        Me.comboCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboCantidad.FormattingEnabled = True
        Me.comboCantidad.Items.AddRange(New Object() {"20", "30", "50", "100", "200", "500"})
        Me.comboCantidad.Location = New System.Drawing.Point(489, 316)
        Me.comboCantidad.Name = "comboCantidad"
        Me.comboCantidad.Size = New System.Drawing.Size(154, 32)
        Me.comboCantidad.TabIndex = 23
        '
        'btPagar
        '
        Me.btPagar.Enabled = False
        Me.btPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPagar.Location = New System.Drawing.Point(506, 366)
        Me.btPagar.Name = "btPagar"
        Me.btPagar.Size = New System.Drawing.Size(116, 38)
        Me.btPagar.TabIndex = 22
        Me.btPagar.Text = "Pagar"
        Me.btPagar.UseVisualStyleBackColor = True
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.Transparent
        Me.panel1.Controls.Add(Me.pictureBox4)
        Me.panel1.Controls.Add(Me.pictureBox3)
        Me.panel1.Controls.Add(Me.pictureBox1)
        Me.panel1.Controls.Add(Me.rdatt)
        Me.panel1.Controls.Add(Me.rdMovistar)
        Me.panel1.Controls.Add(Me.rdTelcel)
        Me.panel1.Location = New System.Drawing.Point(21, 12)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(312, 314)
        Me.panel1.TabIndex = 21
        '
        'pictureBox4
        '
        Me.pictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox4.Image = Global.BanCP.My.Resources.Resources.AT_T_logo_2005
        Me.pictureBox4.Location = New System.Drawing.Point(37, 226)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(162, 65)
        Me.pictureBox4.TabIndex = 17
        Me.pictureBox4.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox3.Image = Global.BanCP.My.Resources.Resources.Movistar_2010
        Me.pictureBox3.Location = New System.Drawing.Point(25, 129)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(269, 65)
        Me.pictureBox3.TabIndex = 16
        Me.pictureBox3.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox1.Image = Global.BanCP.My.Resources.Resources.Telcel_logo
        Me.pictureBox1.Location = New System.Drawing.Point(25, 0)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(303, 81)
        Me.pictureBox1.TabIndex = 15
        Me.pictureBox1.TabStop = False
        '
        'rdatt
        '
        Me.rdatt.AutoSize = True
        Me.rdatt.Location = New System.Drawing.Point(5, 248)
        Me.rdatt.Name = "rdatt"
        Me.rdatt.Size = New System.Drawing.Size(14, 13)
        Me.rdatt.TabIndex = 2
        Me.rdatt.UseVisualStyleBackColor = True
        '
        'rdMovistar
        '
        Me.rdMovistar.AutoSize = True
        Me.rdMovistar.Location = New System.Drawing.Point(5, 160)
        Me.rdMovistar.Name = "rdMovistar"
        Me.rdMovistar.Size = New System.Drawing.Size(14, 13)
        Me.rdMovistar.TabIndex = 1
        Me.rdMovistar.UseVisualStyleBackColor = True
        '
        'rdTelcel
        '
        Me.rdTelcel.AutoSize = True
        Me.rdTelcel.Location = New System.Drawing.Point(5, 22)
        Me.rdTelcel.Name = "rdTelcel"
        Me.rdTelcel.Size = New System.Drawing.Size(14, 13)
        Me.rdTelcel.TabIndex = 0
        Me.rdTelcel.UseVisualStyleBackColor = True
        '
        'Recargas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.BanCP.My.Resources.Resources.image
        Me.ClientSize = New System.Drawing.Size(795, 448)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.pictureBox6)
        Me.Controls.Add(Me.pictureBox5)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.tbnumero)
        Me.Controls.Add(Me.comboCantidad)
        Me.Controls.Add(Me.btPagar)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Recargas"
        Me.Text = "Recargas"
        CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents button1 As Button
    Private WithEvents pictureBox6 As PictureBox
    Private WithEvents pictureBox5 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents tbnumero As TextBox
    Private WithEvents comboCantidad As ComboBox
    Private WithEvents btPagar As Button
    Private WithEvents panel1 As Panel
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents rdatt As RadioButton
    Private WithEvents rdMovistar As RadioButton
    Private WithEvents rdTelcel As RadioButton
End Class
