Module Ejercicio21

    Sub Main()

        Dim num = 0, suma = 0

        Console.Write("Número:")
        num = CInt(Console.ReadLine())

        'For i As Integer = 0 To num - 1
        '    suma = suma + i


        'Next

        'Console.Write("La suma de los números que anteceden a el {0} es {1}", num, suma)

        Console.WriteLine($"La suma de los números que anteceden a el {num} es {Sumar(num - 1)}")

    End Sub

    Function Sumar(ByVal num As Integer) As Integer
        If (num > 0) Then
            Return Sumar(num - 1) + num
        End If

        Return 0
    End Function


End Module
