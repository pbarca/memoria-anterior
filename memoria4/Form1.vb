Public Class Form1
    Dim Jogadas(11) As Integer
    Dim Matriz(11) As Integer
    Dim Quadros() As PictureBox
    Dim Anterior, Passo As Integer
    Sub Imagens(quadro)
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
        Refresh()
        Threading.Thread.Sleep(500)
        Jogadas(quadro) = 1
        If Passo = 1 Then : Anterior = quadro
        ElseIf Matriz(quadro) <> Matriz(Anterior) Then
            Jogadas(quadro) = 0
            Jogadas(Anterior) = 0
            Quadros(quadro).BackgroundImage = My.Resources.Nada
            Quadros(Anterior).BackgroundImage = My.Resources.Nada
        End If

    End Sub
    Sub Inicializa()
        Dim i As Integer
        For i = 0 To 11
            Quadros(i).BackgroundImage = My.Resources.Nada
            Matriz(i) = 0
            Jogadas(i) = 0
        Next

        For par = 0 To 5
            For x = 0 To 1
                Do : i = Int(Rnd() * 12)
                Loop While Matriz(i)
                Matriz(i) = par
            Next
        Next

        Passo = 1
    End Sub
    Private Sub Clicar(sender As Object, e As EventArgs) Handles P1.Click, P2.Click, P4.Click, P3.Click, P9.Click, P8.Click, P7.Click, P6.Click, P5.Click, P12.Click, P11.Click, P10.Click
        Dim quadro As Integer
        Select Case sender.name
            Case "P1" : quadro = 0
            Case "P2" : quadro = 1
            Case "P3" : quadro = 2
            Case "P4" : quadro = 3
            Case "P5" : quadro = 4
            Case "P6" : quadro = 5
            Case "P7" : quadro = 6
            Case "P8" : quadro = 7
            Case "P9" : quadro = 8
            Case "P10" : quadro = 9
            Case "P11" : quadro = 10
            Case "P12" : quadro = 11
        End Select
        If Jogadas(quadro) <> 0 Then Return
        Call Imagens(quadro)
        If Passo = 1 Then : Passo = 2
        Else : Passo = 1
        End If
        Dim ganhou = True
        For i = 0 To 11
            If Jogadas(i) = 0 Then ganhou = False
        Next
        If ganhou Then
            Beep()
            MsgBox("Parabéns! Jogar Novamente?",, "Fim do Jogo")
            Inicializa()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Quadros = {P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12}
        Call Inicializa()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Beep()
        Dim resposta = MsgBox("Tem a certeza?", vbYesNo, "Novo Jogo")
        If resposta = vbNo Then Return
        Inicializa()
    End Sub
End Class
