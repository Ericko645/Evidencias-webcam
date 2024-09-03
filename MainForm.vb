Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Remoting.Contexts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class MainForm
    Public sRuta As String
    Dim webcam1 As New webcam2
    Dim Conexion As New SqlConnection("server = sql5094.site4now.net; database = db_a09b1f_invpf; user id = db_a09b1f_invpf_admin; password = @ppdt23. ")


    Private Sub cmdcamara_Click(sender As Object, e As EventArgs) Handles cmdcamara.Click
        WebcamForm.OpenPreviewWindowCliente()


        cmdcamara.Enabled = False

    End Sub

    Private Sub cmdCapturar_Click(sender As Object, e As EventArgs) Handles cmdCapturar.Click
        WebcamForm.CapturarCliente()
        'webcam1.Capturar(PicFoto)
        WebcamForm.ClosePreviewWindow()

        cmdcamara.Enabled = True
        sucursalbox.Enabled = True
        Platformbox.Enabled = True
        txtNombre.Enabled = True

    End Sub

    Private Sub cmdBorrar_Click(sender As Object, e As EventArgs) Handles cmdBorrar.Click
        PicFoto.Image = Nothing
        txtNombre.Text = ""
        txtBuscar.Text = ""
    End Sub

    Private Sub btnGuardarFotoBase_Click(sender As Object, e As EventArgs) Handles btnGuardarFotoBase.Click

        If (sucursalbox.Text <> "") And (Platformbox.Text <> "") And (txtNombre.Text <> "") And (datetime.Text <> "") Then

            PicFoto.Image.Save("miFoto.jpg")
                Dim o As System.IO.FileStream
                Dim r As StreamReader
                Conexion.Open()
                Dim comando As New SqlClient.SqlCommand("Insert into EVIDENCIA(SUCURSAL,PLATAFORMA,NOMBRE,HORARIO,FOTOGRAFIA) values('" & sucursalbox.Text & "','" & Platformbox.Text & "','" & txtNombre.Text & "','" & datetime.Text & "',@FOTO)", Conexion)
                o = New FileStream("mifoto.jpg", FileMode.Open, FileAccess.Read, FileShare.Read)
                r = New StreamReader(o)
                Dim FileByteArray(o.Length - 1) As Byte
                o.Read(FileByteArray, 0, o.Length)
                comando.Parameters.Add("@FOTO", System.Data.SqlDbType.Binary, o.Length).Value = FileByteArray
                comando.ExecuteNonQuery()
                Conexion.Close()
                limpiarcampo(Me)
                PicFoto.Image = Nothing
            MsgBox("Datos guardados correctamente")

        Else
            MsgBox("Datos incompletos", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub btnGuardarFotoArchivo_Click(sender As Object, e As EventArgs) Handles btnGuardarFotoArchivo.Click

        Try
            If (sucursalbox.Text <> "") And (Platformbox.Text <> "") And (txtNombre.Text <> "") And (datetime.Text <> "") Then
                Dim resultado As DialogResult
                Dim sFD As New SaveFileDialog
                sFD.FileName = txtNombre.Text + "-" + Platformbox.Text + "-" + sucursalbox.Text
                sFD.Title = "Guardar Imagen"
                sFD.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp"
                If sFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.PicFoto.Image.Save(System.IO.Path.GetFullPath(sFD.FileName))

                    resultado = MsgBox("Datos guardados correctamente ¿Desea continuar?", MessageBoxButtons.OKCancel)
                    If resultado = DialogResult.Cancel Then
                        limpiarcampo(Me)
                        PicFoto.Image = Nothing
                    End If
                End If
                Else
                MsgBox("Datos incompletos", MsgBoxStyle.Critical, "Error")
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try



    End Sub

    'Private Sub LlenarGrid()
    '    Conexion.Open()
    '    Dim da As New SqlClient.SqlDataAdapter("Select * from EVIDENCIA where NOMBRE Like'%" & txtBuscar.Text & "%'", Conexion)
    '    Dim ds As New DataSet
    '    da.Fill(ds)
    '    If ds.Tables(0).Rows.Count > 0 Then
    '        DataGridView1.DataSource = ds.Tables(0)
    '    Else
    '        DataGridView1.DataSource = Nothing
    '    End If
    '    Conexion.Close()
    'End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If DataGridView1.RowCount > 0 Then
            Conexion.Open()
            Dim da As New SqlClient.SqlDataAdapter("select * from EVIDENCIA where id=" & DataGridView1.CurrentRow.Cells("ID").Value, Conexion)
            Dim ds As New DataSet
            da.Fill(ds)

            Dim c As Integer = ds.Tables(0).Rows.Count
            If c > 0 Then
                Dim bytBLOBData() As Byte =
                    ds.Tables(0).Rows(c - 1)("FOTO")
                Dim stmBLOBData As New MemoryStream(bytBLOBData)
                PicFoto.Image = Image.FromStream(stmBLOBData)
            End If

            txtNombre.Text = DataGridView1.CurrentRow.Cells("NOMBRE").Value.ToString
        End If
        Conexion.Close()
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        'LlenarGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles closecamera.Click
        WebcamForm.ClosePreviewWindow()
        cmdcamara.Enabled = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        NIP.Show()
        PicFoto.Image = Nothing
    End Sub
End Class
