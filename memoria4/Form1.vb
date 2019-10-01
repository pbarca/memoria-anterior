Public Class Form1
    Dim Matriz(12) As Integer
    Dim Quadros() As PictureBox
    Private Sub Inicializa()
        Dim i As Integer
        For i = 0 To 11
            Matriz(i) = 0
            Quadros(i).BackgroundImage = My.Resources.Nada
        Next

        For par = 0 To 5
            For x = 0 To 1
                Do : i = Int(Rnd() * 12)
                Loop While Matriz(i) > 0
                Matriz(i) = par
            Next
        Next
    End Sub
    Private Sub Imagem(quadro)
        Dim fig As New PictureBox
        Select Case Matriz(quadro)
            Case 0 : fig.BackgroundImage = My.Resources.aries
            Case 1 : fig.BackgroundImage = My.Resources.aquarius
            Case 2 : fig.BackgroundImage = My.Resources.pisces
            Case 3 : fig.BackgroundImage = My.Resources.gemini
            Case 4 : fig.BackgroundImage = My.Resources.leo
            Case 5 : fig.BackgroundImage = My.Resources.libra
        End Select

        Quadros(quadro).BackgroundImage = fig.BackgroundImage
    End Sub
    Private Sub Clicar(sender As Object, e As EventArgs) Handles P1.Click, P2.Click, P4.Click, P3.Click, P9.Click, P8.Click, P7.Click, P6.Click, P5.Click, P12.Click, P11.Click, P10.Click
        Select Case sender.name
            Case "P1" : Imagem(0)
            Case "P2" : Imagem(1)
            Case "P3" : Imagem(2)
            Case "P4" : Imagem(3)
            Case "P5" : Imagem(4)
            Case "P6" : Imagem(5)
            Case "P7" : Imagem(6)
            Case "P8" : Imagem(7)
            Case "P9" : Imagem(8)
            Case "P10" : Imagem(9)
            Case "P11" : Imagem(10)
            Case "P12" : Imagem(11)
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Inicializa()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Quadros = {P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12}
        Call Inicializa()
    End Sub
End Class
