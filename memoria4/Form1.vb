Public Class Form1
    Private Sub Clicar(sender As Object, e As EventArgs) Handles P1.Click, P2.Click, P4.Click, P3.Click, P9.Click, P8.Click, P7.Click, P6.Click, P5.Click, P12.Click, P11.Click, P10.Click
        Dim fig As New PictureBox
        Dim i = Int(Rnd() * 6)
        Select Case i
            Case 0 : fig.Image = My.Resources.aries
            Case 1 : fig.Image = My.Resources.aquarius
            Case 2 : fig.Image = My.Resources.capricornus
            Case 3 : fig.Image = My.Resources.gemini
            Case 4 : fig.Image = My.Resources.leo
            Case 5 : fig.Image = My.Resources.libra
        End Select

        Select Case sender.name
            Case "P1" : P1.BackgroundImage = fig.Image
            Case "P2" : P2.BackgroundImage = fig.Image
            Case "P3" : P3.BackgroundImage = fig.Image
            Case "P4" : P4.BackgroundImage = fig.Image
            Case "P5" : P5.BackgroundImage = fig.Image
            Case "P6" : P6.BackgroundImage = fig.Image
            Case "P7" : P7.BackgroundImage = fig.Image
            Case "P8" : P8.BackgroundImage = fig.Image
            Case "P9" : P9.BackgroundImage = fig.Image
            Case "P10" : P10.BackgroundImage = fig.Image
            Case "P11" : P11.BackgroundImage = fig.Image
            Case "P12" : P12.BackgroundImage = fig.Image
        End Select
    End Sub
End Class
