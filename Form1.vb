Public Class Form1

    Dim random As New Random
    Dim aleatory(15) As Integer
    Dim n As Integer = 0
    Dim suma As Integer = 0
    Dim cadena As String
    Dim i As Integer


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()


        For i = 0 To 14

            aleatory(i) = random.Next(1, 50)

            cadena = (cadena & " " & aleatory(i) & "  ")
        Next

        n = TextBox1.Text

        For i = 0 To n - 1

            n = TextBox1.Text
            suma += aleatory(i)

        Next

        cadena = ("Esta es la cadena generada" & cadena & vbNewLine & "Esta es la suma de los numero de la cadena introducidos" & suma)
        TextBox2.Text = cadena


    End Sub
End Class
