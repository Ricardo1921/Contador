Public Class Form1

    Public

End Class

Public Class MyPictureBox
        Interits Picture


        Public Property linha As Integer

        Public Property coluna As Integer

        Public Property minas As Integer

        Public Property bombas As Integer
        Private Sub clicar(sender As Object, e As EventArgs) Handles 
            Dim pic As PictureBox
            pic = sender
            pic.BackgroundImage = My.Resources.
            Dim imagem = sender.name
            Dim quadro = Int(imagem.Replace("b", ""))
            MsgBox(quadro)
        End Sub
    End Class




