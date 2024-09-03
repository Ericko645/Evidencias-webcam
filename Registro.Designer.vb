<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sucursalbox = New System.Windows.Forms.ComboBox()
        Me.Usuario = New System.Windows.Forms.TextBox()
        Me.contraseña = New System.Windows.Forms.TextBox()
        Me.Nivel = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sucursal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nivel"
        '
        'sucursalbox
        '
        Me.sucursalbox.FormattingEnabled = True
        Me.sucursalbox.Items.AddRange(New Object() {"GUELATAO", "TEPEYAC", "JARDIN", "OCEANIA", "EJE 6", "LA VIGA", "LAZARO CARDENAS", "CULHUACAN", "GENERAL ANAYA", "NATIVITAS", "RIO FRIO", "ROMA", "VERTIZ", "JAMAICA", "PLAZA DE TOROS", "REVOLUCION", "HONG KONG", "TECNOLOGICO", "MANANTIALES", "MONUMENTO", "PATZCUARO", "CAMELINAS", "VIRREY"})
        Me.sucursalbox.Location = New System.Drawing.Point(88, 40)
        Me.sucursalbox.Name = "sucursalbox"
        Me.sucursalbox.Size = New System.Drawing.Size(108, 21)
        Me.sucursalbox.TabIndex = 4
        '
        'Usuario
        '
        Me.Usuario.Location = New System.Drawing.Point(88, 81)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(100, 20)
        Me.Usuario.TabIndex = 5
        '
        'contraseña
        '
        Me.contraseña.Location = New System.Drawing.Point(88, 119)
        Me.contraseña.Name = "contraseña"
        Me.contraseña.Size = New System.Drawing.Size(100, 20)
        Me.contraseña.TabIndex = 6
        '
        'Nivel
        '
        Me.Nivel.FormattingEnabled = True
        Me.Nivel.Items.AddRange(New Object() {"ADMINISTRADOR", "OPERATIVO"})
        Me.Nivel.Location = New System.Drawing.Point(88, 163)
        Me.Nivel.Name = "Nivel"
        Me.Nivel.Size = New System.Drawing.Size(108, 21)
        Me.Nivel.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(49, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 46)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Registrar usuario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 300)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Nivel)
        Me.Controls.Add(Me.contraseña)
        Me.Controls.Add(Me.Usuario)
        Me.Controls.Add(Me.sucursalbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sucursalbox As ComboBox
    Friend WithEvents Usuario As TextBox
    Friend WithEvents contraseña As TextBox
    Friend WithEvents Nivel As ComboBox
    Friend WithEvents Button1 As Button
End Class
