<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.btnGuardarFotoBase = New System.Windows.Forms.Button()
        Me.btnGuardarFotoArchivo = New System.Windows.Forms.Button()
        Me.cmdcamara = New System.Windows.Forms.Button()
        Me.cmdBorrar = New System.Windows.Forms.Button()
        Me.cmdCapturar = New System.Windows.Forms.Button()
        Me.PicFoto = New System.Windows.Forms.PictureBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Platformbox = New System.Windows.Forms.ComboBox()
        Me.sucursalbox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.closecamera = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.datetime = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardarFotoBase
        '
        Me.btnGuardarFotoBase.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarFotoBase.Image = CType(resources.GetObject("btnGuardarFotoBase.Image"), System.Drawing.Image)
        Me.btnGuardarFotoBase.Location = New System.Drawing.Point(424, 110)
        Me.btnGuardarFotoBase.Name = "btnGuardarFotoBase"
        Me.btnGuardarFotoBase.Size = New System.Drawing.Size(170, 80)
        Me.btnGuardarFotoBase.TabIndex = 167
        Me.btnGuardarFotoBase.Text = "Guardar en Base de datos"
        Me.btnGuardarFotoBase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardarFotoBase.UseVisualStyleBackColor = True
        '
        'btnGuardarFotoArchivo
        '
        Me.btnGuardarFotoArchivo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarFotoArchivo.Image = CType(resources.GetObject("btnGuardarFotoArchivo.Image"), System.Drawing.Image)
        Me.btnGuardarFotoArchivo.Location = New System.Drawing.Point(424, 17)
        Me.btnGuardarFotoArchivo.Name = "btnGuardarFotoArchivo"
        Me.btnGuardarFotoArchivo.Size = New System.Drawing.Size(170, 78)
        Me.btnGuardarFotoArchivo.TabIndex = 166
        Me.btnGuardarFotoArchivo.Text = "Guardar en archivo local"
        Me.btnGuardarFotoArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardarFotoArchivo.UseVisualStyleBackColor = True
        '
        'cmdcamara
        '
        Me.cmdcamara.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcamara.Image = CType(resources.GetObject("cmdcamara.Image"), System.Drawing.Image)
        Me.cmdcamara.Location = New System.Drawing.Point(18, 237)
        Me.cmdcamara.Name = "cmdcamara"
        Me.cmdcamara.Size = New System.Drawing.Size(125, 66)
        Me.cmdcamara.TabIndex = 163
        Me.cmdcamara.Text = "Camara"
        Me.cmdcamara.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdcamara.UseVisualStyleBackColor = True
        '
        'cmdBorrar
        '
        Me.cmdBorrar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBorrar.Image = CType(resources.GetObject("cmdBorrar.Image"), System.Drawing.Image)
        Me.cmdBorrar.Location = New System.Drawing.Point(275, 237)
        Me.cmdBorrar.Name = "cmdBorrar"
        Me.cmdBorrar.Size = New System.Drawing.Size(118, 66)
        Me.cmdBorrar.TabIndex = 165
        Me.cmdBorrar.Text = "Borrar"
        Me.cmdBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdBorrar.UseVisualStyleBackColor = True
        '
        'cmdCapturar
        '
        Me.cmdCapturar.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCapturar.Image = CType(resources.GetObject("cmdCapturar.Image"), System.Drawing.Image)
        Me.cmdCapturar.Location = New System.Drawing.Point(149, 237)
        Me.cmdCapturar.Name = "cmdCapturar"
        Me.cmdCapturar.Size = New System.Drawing.Size(120, 66)
        Me.cmdCapturar.TabIndex = 164
        Me.cmdCapturar.Text = "Capturar"
        Me.cmdCapturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCapturar.UseVisualStyleBackColor = True
        '
        'PicFoto
        '
        Me.PicFoto.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton
        Me.PicFoto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicFoto.Image = CType(resources.GetObject("PicFoto.Image"), System.Drawing.Image)
        Me.PicFoto.Location = New System.Drawing.Point(12, 2)
        Me.PicFoto.Name = "PicFoto"
        Me.PicFoto.Size = New System.Drawing.Size(393, 229)
        Me.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicFoto.TabIndex = 168
        Me.PicFoto.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(83, 384)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(150, 21)
        Me.txtNombre.TabIndex = 169
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "Codigo/ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 175
        Me.Label3.Text = "Plataforma:"
        '
        'Platformbox
        '
        Me.Platformbox.Enabled = False
        Me.Platformbox.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Platformbox.FormattingEnabled = True
        Me.Platformbox.Items.AddRange(New Object() {"", "UBER", "RAPPI"})
        Me.Platformbox.Location = New System.Drawing.Point(83, 351)
        Me.Platformbox.Name = "Platformbox"
        Me.Platformbox.Size = New System.Drawing.Size(150, 24)
        Me.Platformbox.TabIndex = 176
        '
        'sucursalbox
        '
        Me.sucursalbox.Enabled = False
        Me.sucursalbox.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sucursalbox.FormattingEnabled = True
        Me.sucursalbox.Items.AddRange(New Object() {"", "TEPEYAC", "EJE 6", "NATIVITAS", "CULHUACAN", "JARDINES", "GENERAL ANAYA", "LA VIGA ", "VERTIZ", "LAZARO", "RIO", "GUELATAO"})
        Me.sucursalbox.Location = New System.Drawing.Point(83, 316)
        Me.sucursalbox.Name = "sucursalbox"
        Me.sucursalbox.Size = New System.Drawing.Size(150, 23)
        Me.sucursalbox.TabIndex = 178
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 177
        Me.Label4.Text = "Sucursal:"
        '
        'closecamera
        '
        Me.closecamera.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closecamera.Image = CType(resources.GetObject("closecamera.Image"), System.Drawing.Image)
        Me.closecamera.Location = New System.Drawing.Point(275, 312)
        Me.closecamera.Name = "closecamera"
        Me.closecamera.Size = New System.Drawing.Size(118, 52)
        Me.closecamera.TabIndex = 179
        Me.closecamera.Text = "Cerrar camara"
        Me.closecamera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.closecamera.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 418)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 15)
        Me.Label5.TabIndex = 180
        Me.Label5.Text = "Fecha de Captura:"
        '
        'datetime
        '
        Me.datetime.Enabled = False
        Me.datetime.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetime.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.datetime.Location = New System.Drawing.Point(128, 414)
        Me.datetime.Name = "datetime"
        Me.datetime.Size = New System.Drawing.Size(217, 21)
        Me.datetime.TabIndex = 181
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(644, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(156, 260)
        Me.DataGridView1.TabIndex = 172
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Location = New System.Drawing.Point(644, 8)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(157, 20)
        Me.txtBuscar.TabIndex = 171
        Me.txtBuscar.Text = " "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(424, 208)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 80)
        Me.Button1.TabIndex = 182
        Me.Button1.Text = "Busqueda de imagen"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AccessibleName = " "
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(615, 469)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.datetime)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.closecamera)
        Me.Controls.Add(Me.sucursalbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Platformbox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.PicFoto)
        Me.Controls.Add(Me.btnGuardarFotoBase)
        Me.Controls.Add(Me.btnGuardarFotoArchivo)
        Me.Controls.Add(Me.cmdcamara)
        Me.Controls.Add(Me.cmdBorrar)
        Me.Controls.Add(Me.cmdCapturar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura de Imagen."
        CType(Me.PicFoto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardarFotoBase As System.Windows.Forms.Button
    Friend WithEvents btnGuardarFotoArchivo As System.Windows.Forms.Button
    Friend WithEvents cmdcamara As System.Windows.Forms.Button
    Friend WithEvents cmdBorrar As System.Windows.Forms.Button
    Friend WithEvents cmdCapturar As System.Windows.Forms.Button
    Friend WithEvents PicFoto As System.Windows.Forms.PictureBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Platformbox As ComboBox
    Friend WithEvents sucursalbox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents closecamera As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents datetime As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Button1 As Button
End Class
