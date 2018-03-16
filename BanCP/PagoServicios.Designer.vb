<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PagoServicios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PagoServicios))
        Me.grouTipo = New System.Windows.Forms.GroupBox()
        Me.rdAgua = New System.Windows.Forms.RadioButton()
        Me.rdLuz = New System.Windows.Forms.RadioButton()
        Me.rdMegacable = New System.Windows.Forms.RadioButton()
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.pictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btAtras = New System.Windows.Forms.Button()
        Me.pictureBox4 = New System.Windows.Forms.PictureBox()
        Me.pictureBox3 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btPagar = New System.Windows.Forms.Button()
        Me.grouTipo.SuspendLayout()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grouTipo
        '
        Me.grouTipo.BackColor = System.Drawing.Color.Transparent
        Me.grouTipo.Controls.Add(Me.pictureBox4)
        Me.grouTipo.Controls.Add(Me.pictureBox3)
        Me.grouTipo.Controls.Add(Me.pictureBox1)
        Me.grouTipo.Controls.Add(Me.rdAgua)
        Me.grouTipo.Controls.Add(Me.rdLuz)
        Me.grouTipo.Controls.Add(Me.rdMegacable)
        Me.grouTipo.Location = New System.Drawing.Point(27, 128)
        Me.grouTipo.Name = "grouTipo"
        Me.grouTipo.Size = New System.Drawing.Size(140, 274)
        Me.grouTipo.TabIndex = 18
        Me.grouTipo.TabStop = False
        Me.grouTipo.Text = "Servicios"
        '
        'rdAgua
        '
        Me.rdAgua.AutoSize = True
        Me.rdAgua.Location = New System.Drawing.Point(19, 224)
        Me.rdAgua.Name = "rdAgua"
        Me.rdAgua.Size = New System.Drawing.Size(14, 13)
        Me.rdAgua.TabIndex = 5
        Me.rdAgua.UseVisualStyleBackColor = True
        '
        'rdLuz
        '
        Me.rdLuz.AutoSize = True
        Me.rdLuz.Location = New System.Drawing.Point(19, 125)
        Me.rdLuz.Name = "rdLuz"
        Me.rdLuz.Size = New System.Drawing.Size(14, 13)
        Me.rdLuz.TabIndex = 4
        Me.rdLuz.UseVisualStyleBackColor = True
        '
        'rdMegacable
        '
        Me.rdMegacable.AutoSize = True
        Me.rdMegacable.Location = New System.Drawing.Point(19, 45)
        Me.rdMegacable.Name = "rdMegacable"
        Me.rdMegacable.Size = New System.Drawing.Size(14, 13)
        Me.rdMegacable.TabIndex = 3
        Me.rdMegacable.UseVisualStyleBackColor = True
        '
        'tbCantidad
        '
        Me.tbCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCantidad.Location = New System.Drawing.Point(334, 264)
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.Size = New System.Drawing.Size(188, 29)
        Me.tbCantidad.TabIndex = 17
        Me.tbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pictureBox5
        '
        Me.pictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox5.Image = Global.BanCP.My.Resources.Resources.cantidad
        Me.pictureBox5.Location = New System.Drawing.Point(253, 207)
        Me.pictureBox5.Name = "pictureBox5"
        Me.pictureBox5.Size = New System.Drawing.Size(373, 43)
        Me.pictureBox5.TabIndex = 21
        Me.pictureBox5.TabStop = False
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox2.Image = Global.BanCP.My.Resources.Resources.minibancp
        Me.pictureBox2.Location = New System.Drawing.Point(352, 12)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(154, 154)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureBox2.TabIndex = 20
        Me.pictureBox2.TabStop = False
        '
        'btAtras
        '
        Me.btAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAtras.Image = Global.BanCP.My.Resources.Resources.btnAtras
        Me.btAtras.Location = New System.Drawing.Point(34, 491)
        Me.btAtras.Name = "btAtras"
        Me.btAtras.Size = New System.Drawing.Size(168, 50)
        Me.btAtras.TabIndex = 19
        Me.btAtras.UseVisualStyleBackColor = True
        '
        'pictureBox4
        '
        Me.pictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox4.Image = Global.BanCP.My.Resources.Resources.agua
        Me.pictureBox4.Location = New System.Drawing.Point(54, 207)
        Me.pictureBox4.Name = "pictureBox4"
        Me.pictureBox4.Size = New System.Drawing.Size(63, 40)
        Me.pictureBox4.TabIndex = 17
        Me.pictureBox4.TabStop = False
        '
        'pictureBox3
        '
        Me.pictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox3.Image = Global.BanCP.My.Resources.Resources.cfe
        Me.pictureBox3.Location = New System.Drawing.Point(54, 115)
        Me.pictureBox3.Name = "pictureBox3"
        Me.pictureBox3.Size = New System.Drawing.Size(63, 40)
        Me.pictureBox3.TabIndex = 16
        Me.pictureBox3.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pictureBox1.Image = Global.BanCP.My.Resources.Resources.joV7apee
        Me.pictureBox1.Location = New System.Drawing.Point(54, 18)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(63, 62)
        Me.pictureBox1.TabIndex = 15
        Me.pictureBox1.TabStop = False
        '
        'btPagar
        '
        Me.btPagar.Enabled = False
        Me.btPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPagar.Image = Global.BanCP.My.Resources.Resources.btnPagar
        Me.btPagar.Location = New System.Drawing.Point(334, 352)
        Me.btPagar.Name = "btPagar"
        Me.btPagar.Size = New System.Drawing.Size(186, 50)
        Me.btPagar.TabIndex = 16
        Me.btPagar.UseVisualStyleBackColor = True
        '
        'PagoServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(776, 564)
        Me.Controls.Add(Me.pictureBox5)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.btAtras)
        Me.Controls.Add(Me.grouTipo)
        Me.Controls.Add(Me.tbCantidad)
        Me.Controls.Add(Me.btPagar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PagoServicios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PagoServicios"
        Me.grouTipo.ResumeLayout(False)
        Me.grouTipo.PerformLayout()
        CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBox5 As PictureBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents btAtras As Button
    Private WithEvents grouTipo As GroupBox
    Private WithEvents pictureBox4 As PictureBox
    Private WithEvents pictureBox3 As PictureBox
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents rdAgua As RadioButton
    Private WithEvents rdLuz As RadioButton
    Private WithEvents rdMegacable As RadioButton
    Private WithEvents tbCantidad As TextBox
    Private WithEvents btPagar As Button
End Class
