Public Class Cam2
    Dim webcam As New webcam2

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        webcam.timer_tick(PictureBox1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        webcam.Iniciar(Timer1, Me)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        webcam.Detener(Timer1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        webcam.Capturar(PictureBox1)
    End Sub
    Private Sub Cam2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class