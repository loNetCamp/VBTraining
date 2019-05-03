Module Ejercicio13

    Sub Main()

        Dim numero As Integer
        Dim cont = 0, menor = 0, mayor = 0

        While (cont < 10)

            Console.Write("Introduzca número:")
            numero = CInt(Console.ReadLine())

            If (numero > 0) Then
                mayor += 1
                If (numero < 0) Then
                    menor += 1

                    cont += 1
                End If
            End If

        End While

        Console.WriteLine("De 10 números son ...\nMenores a 0  = {0} y mayores a 0 = {1}", menor, mayor)


    End Sub


End Module
