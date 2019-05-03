Module Ejercicio16

    Sub Main()

        Dim num As Integer

        Console.Write("Introduzca número:")
        num = CInt(Console.ReadLine())

        If num = 0 Then
            Console.Write("El {0} no es negativo ni positivo es neutro", num)

            If (num > 0) Then
                Console.Write("El {0} es positivo", num)
                If (num < 0) Then
                    Console.Write("El {0} es negativo", num)
                End If
            End If
        End If


    End Sub


End Module
