Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Contexts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO

Public Class Form1
    Public sRuta As String
    Dim Conexion As New SqlConnection("server = sql5094.site4now.net; database = db_a09b1f_invpf; user id = db_a09b1f_invpf_admin; password = @ppdt23. ")


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim adaptador As New SqlClient.SqlDataAdapter("Select * from EVIDENCIA where nombre Like '%" & nombre.Text & "%'", Conexion)

        Dim datos As New DataSet

        adaptador.Fill(datos)
        If datos.Tables(0).Rows.Count > 0 Then

            Dim c As Integer = datos.Tables(0).Rows.Count
            If c > 0 Then
                Dim bytBLOBData() As Byte =
                    datos.Tables(0).Rows(c - 1)("FOTOGRAFIA")
                Dim stmBLOBData As New MemoryStream(bytBLOBData)
                pictureload.Image = Image.FromStream(stmBLOBData)
            End If

            nombre.Text = datos.Tables(0).Rows(0).Item("NOMBRE").ToString
            Platformbox.Text = datos.Tables(0).Rows(0).Item("Plataforma").ToString
            sucbox.Text = datos.Tables(0).Rows(0).Item("Sucursal").ToString
            Fechatxt.Text = datos.Tables(0).Rows(0).Item("Horario").ToString



        Else

            MessageBox.Show("No hay imagenes con este ID" + nombre.Text, "Se inserto una imagen", MessageBoxButtons.OK)
            nombre.Text = ""
            Platformbox.Text = ""
            sucbox.Text = ""
            Fechatxt.Text = ""
            pictureload.Visible = False


        End If
    End Sub



    Private Sub pictureload_Click(sender As Object, e As EventArgs) Handles pictureload.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim sFD As New SaveFileDialog
            sFD.FileName = nombre.Text + "-" + Platformbox.Text + "-" + sucbox.Text
            sFD.Title = "Guardar Imagen"
            sFD.Filter = "Imagenes|*.jpg;*.gif;*.png;*.bmp"
            If sFD.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.pictureload.Image.Save(System.IO.Path.GetFullPath(sFD.FileName))
                MsgBox("Datos guardados correctamente")
            End If
        Catch ex As Exception
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        limpiarcampo(Me)
        pictureload.Image = Nothing
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class