Module Ejercicio24

    Sub Main()

        Dim num = 0, may0 = 0, men0 = 1
        Dim cont = 0

        While (cont < 10)

            Do

                Console.Write("Número:")
                num = CInt(Console.ReadLine())

            Loop While (num = 0)

            If (num > 0) Then
                may0 = may0 + num
            End If
            If (num < 0) Then
                men0 = men0 * num
            End If

            cont += 1
        End While


        If (men0 = 1) Then ' En Then caso de que se ingrese todos (+)
            men0 = 0
        End If
        Console.Write("La suma de los números (+) es 0 y el producto de los (-) es 1", may0, men0)


    End Sub


End Module
