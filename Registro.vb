Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Contexts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Registro
    Public sRuta As String
    Dim webcam1 As New webcam2
    Dim Conexion As New SqlConnection("server = sql5094.site4now.net; database = db_a09b1f_invpf; user id = db_a09b1f_invpf_admin; password = @ppdt23. ")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (sucursalbox.Text <> "") And (Usuario.Text <> "") And (contraseña.Text <> "") And (Nivel.Text <> "") Then

            Dim comando As New SqlClient.SqlCommand
            comando.CommandType = CommandType.Text
            comando.CommandText = ("insert into USERSUCURSAL (SUCURSAL, USUARIO, PASS, NIVEL ) values ('" & sucursalbox.Text & "','" & Usuario.Text & "','" & contraseña.Text & "','" & Nivel.Text & "')")
            comando.Connection = Conexion
            Conexion.Open()
            comando.ExecuteNonQuery()
            Conexion.Close()
            MsgBox("Se registro correctamente", MsgBoxStyle.Information, "Correcto")

            MessageBox.Show("Usuario registrado", "Mensaje")
            limpiarcampo(Me)
        Else
            MessageBox.Show("Datos faltantes" & vbCrLf & "Revisar")
        End If
    End Sub

    Private Sub Usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Usuario.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            MessageBox.Show("Solo numeros", "Alerta")
            e.Handled = True

        End If
    End Sub

    Private Sub contraseña_TextChanged(sender As Object, e As EventArgs) Handles contraseña.TextChanged

    End Sub

    Private Sub contraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contraseña.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            MessageBox.Show("Solo numeros", "Alerta")
            e.Handled = True

        End If
    End Sub
End Class