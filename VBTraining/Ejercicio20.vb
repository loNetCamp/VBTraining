Module Ejercicio20

    Sub Main()

        Dim a = 0, e = 0, i = 0, o = 0, u = 0

        Console.Write("Introduzca una frase:")
        Dim frase As String = Console.ReadLine()
        For x As Integer = 0 To frase.Length - 1
            Select Case frase(x)
                Case "a"c
                    a += 1
                Case "e"c
                    e += 1
                Case "i"c
                    i += 1
                Case "o"c
                    o += 1
                Case "u"c
                    u += 1

            End Select
        Next

        Console.WriteLine("a = {0}, e = {1}, i = {2}, o = {3}, u = {4}", a, e, i, o, u)


    End Sub


End Module
