Module Ejercicio21

    Sub Main()

        Dim num = 0, suma = 0

        Console.Write("Número:")
        num = CInt(Console.ReadLine())

        For i As Integer = 0 To num - 1
            suma = suma + i

            Console.Write("La suma de los números que anteceden a el {0} es {1}\n\n", num, suma)
        Next

    End Sub


End Module
