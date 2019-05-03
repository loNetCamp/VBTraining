Module Ejercicio17

    Sub Main()

        Dim num As Integer

        Console.Write("Introduzca número:")
        num = CInt(Console.ReadLine())

        While (num = 0)

            Console.Write("Introduzca número:")
            num = CInt(Console.ReadLine())
        End While

        If (num Mod 2 = 0) Then
            Console.Write("El {0} es par", num)
        Else
            Console.Write("El {0} es impar", num)
        End If


    End Sub


End Module
