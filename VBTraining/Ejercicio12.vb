Module Ejercicio12

    Sub Main()

        Dim num As Double

        Console.Write("Introduzca un número:")
        num = CDbl(Console.ReadLine())

        While (num < 1)

            Console.Write("ERROR.Reingrese número:")
            num = CDbl(Console.ReadLine())
        End While

        Console.Write("El cuadrado de {0} es {1}", num, num * num)


    End Sub


End Module
