Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Contexts


Public Class NIP
    Public sRuta As String
    Dim webcam1 As New webcam2
    Dim Conexion As New SqlConnection("server = sql5094.site4now.net; database = db_a09b1f_invpf; user id = db_a09b1f_invpf_admin; password = @ppdt23. ")

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles niptxt.TextChanged

    End Sub

    Private Sub NIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        niptxt.Text += "1"
        Userbox.Text += "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        niptxt.Text += "2"
        Userbox.Text += "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        niptxt.Text += "3"
        Userbox.Text += "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        niptxt.Text += "4"
        Userbox.Text += "4"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        niptxt.Text += "5"
        Userbox.Text += "5"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        niptxt.Text += "6"
        Userbox.Text += "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        niptxt.Text += "7"
        Userbox.Text += "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        niptxt.Text += "8"
        Userbox.Text += "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        niptxt.Text += "0"
        Userbox.Text += "0"
    End Sub

    Private Sub ButBORRAR_Click(sender As Object, e As EventArgs) Handles ButBORRAR.Click
        niptxt.Text = ""
        Userbox.Text = ""
    End Sub

    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        Dim adaptador As New SqlClient.SqlDataAdapter("Select * from USERSUCURSAL where USUARIO ='" & Userbox.Text & "' and PASS ='" & niptxt.Text & "'", Conexion)
        Dim eldelosdatos As New DataSet
        adaptador.Fill(eldelosdatos)
        If (eldelosdatos.Tables(0).Rows.Count > 0) Then
            If eldelosdatos.Tables(0).Rows(0).Item("NIVEL") = "ADMINISTRADOR" Then
                Back_Office_camara.Show()
            End If
            If eldelosdatos.Tables(0).Rows(0).Item("NIVEL") = "OPERATIVO" Then
                MainForm.Show()
            End If

            limpiarcampo(Me)

            Me.Hide()
        Else
            MsgBox("Error de usuario o contraseña", MsgBoxStyle.Information, "Incorrecto")
        End If

    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        niptxt.Text += "0"
    End Sub

    Private Sub Userbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Userbox.KeyPress
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

    Private Sub niptxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles niptxt.KeyPress
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

    Private Sub Userbox_TextChanged(sender As Object, e As EventArgs) Handles Userbox.TextChanged

    End Sub
End Class