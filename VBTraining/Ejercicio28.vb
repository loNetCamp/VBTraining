Module Ejercicio28

    Sub Main()

        Dim flag = 0, i = 0, mayordia = 0, menordia = 0, x = 30
        Dim dia(31) As Integer
        Dim menor = 0.0, mayor = 0.0, promedio = 0.0, contagua = 0.0
        Dim agua(x + 1) As Double

        Dim data As New Dictionary(Of Integer, Integer) From {
            {1, 10},
            {2, 6},
            {3, 0},
            {4, 40},
            {5, 0}
        }

        mayor = data.Values.Max()
        menor = data.Values.Min()
        promedio = data.Values.Average()

        'Do

        '    Console.Write("Introduzca día:")
        '    dia(i) = CInt(Console.ReadLine())

        '    Console.Write("Introduzca agua caída:")
        '    agua(i) = CDbl(Console.ReadLine())

        '    If (flag = 0) Then

        '        mayordia = data(i)
        '        menordia = dia(i)
        '        mayor = agua(i)
        '        menor = agua(i)
        '        flag = 1

        '    Else

        '        If (agua(i) > mayor) Then

        '            mayordia = dia(i)
        '            mayor = agua(i)
        '        End If
        '        If (agua(i) < menor) Then

        '            menordia = dia(i)
        '            menor = agua(i)
        '        End If
        '    End If

        '    contagua += agua(i)

        '    If (i = 29) Then

        '        Console.Write("El mes tiene 31 días s/n ?")
        '        If (Console.ReadLine() = "s") Then
        '            x = x + 1
        '        End If
        '        i += 1
        '    End If
        'Loop While (i < x)

        'promedio = contagua / i

        If (menor = mayor) Then

            Console.Write("No hubo mayor y menor día de agua caída, fue igual para todos los días {0}", menor)

        Else

            Console.WriteLine("La mayor cantidad de agua caída fue de {0} milímetros el/los día/s ...", mayor)
            For Each item In data
                If (item.Value = mayor) Then
                    Console.Write("Dia {0}", item.Key)
                End If

            Next

            Console.WriteLine()

            Console.WriteLine("La menor cantidad de agua caída fue de {0} milímetros el/los día/s ...", menor)
            For Each item In data
                If (item.Value = menor) Then
                    Console.Write("Dia {0} ", item.Key)
                End If

            Next

            Console.WriteLine()

            Console.WriteLine("El promedio de agua caída en {0} días es {1}", x, promedio)

        End If
    End Sub


End Module
