Imports System.IO
Public Class Form1

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim arquivo As StreamWriter
        If Not File.Exists("texto.txt") Then
            arquivo = File.CreateText("texto.txt")
            arquivo.Close()
        End If

        arquivo = File.AppendText("texto.txt")
        arquivo.Write(ControlChars.CrLf)
        arquivo.WriteLine(txtTexto.Text)
        arquivo.Write(ControlChars.CrLf)
        arquivo.WriteLine("Criado por Marcus")
        arquivo.Close()

    End Sub

    Private Sub btnLerFim_Click(sender As Object, e As EventArgs) Handles btnLerFim.Click
        Dim arquivo As StreamReader

        arquivo = File.OpenText("texto.txt")

        txtTexto.Text = arquivo.ReadToEnd

        arquivo.Close()

    End Sub

    Private Sub btnLerLinha_Click(sender As Object, e As EventArgs) Handles btnLerLinha.Click
        Dim linha As String = ""

        Dim arquivo As StreamReader = File.OpenText("texto.txt")

        While arquivo.Peek <> -1
            linha += arquivo.ReadLine()
            linha += ControlChars.CrLf
        End While

        arquivo.Close()

        txtTexto.Text = linha

    End Sub
End Class
