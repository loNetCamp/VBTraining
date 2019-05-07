Module Ejercicio22

    Sub Main()

        Dim num As Integer

        Console.Write("Número:")
        num = CInt(Console.ReadLine())

        For i As Integer = 1 To num
            Console.Write("{0},", i)
        Next

        Console.WriteLine(Environment.NewLine + "****************")

        For Each i As Integer In Enumerable.Range(1, num)
            Console.Write("{0},", i)
        Next

        Console.WriteLine(Environment.NewLine + "****************")

        Console.WriteLine(String.Join(", ", Enumerable.Range(1, num)))

        Console.WriteLine(Environment.NewLine + "****************")

        MostrarInferiores(num)
    End Sub

    Sub MostrarInferiores(ByVal num As Integer)
        If (num > 0) Then
            MostrarInferiores(num - 1)
            Console.Write(num & ", ")
        End If
    End Sub


End Module
