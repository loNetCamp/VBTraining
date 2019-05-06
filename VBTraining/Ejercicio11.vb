Module Ejercicio11

    Sub Main()

        Dim i = 0
        Dim num As Double
        Dim acu = 0.0

        While (i < 5)

            Console.Write("Introduzca {0}º número:", i + 1)
            num = CDbl(Console.ReadLine())
            acu += num
            i += 1
        End While
        Console.Write($"El promedio de los 5 números es {acu / 5}")


    End Sub


End Module
