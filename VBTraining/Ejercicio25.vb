Module Ejercicio25

    Sub Main()
        Dim lado(3) As Double
        Dim mayor = 0.0, sumar = 0.0
        Dim auxi = 0, flag = 0

        For i As Integer = 0 To lado.Length - 1

            Console.Write("Lado 0}:", i + 1)
            lado(i) = CDbl(Console.ReadLine())

            If (lado(i) > mayor) Then

                mayor = lado(i)
                auxi = i
            End If
        Next

        For i As Integer = 0 To lado.Length - 1
            If (auxi <> i) Then
                sumar += lado(i)
            End If
        Next

        If (mayor < sumar) Then

            Console.Write("Es un triangulo")

            For i As Integer = 0 To 1
                For j As Integer = i + 1 To 2
                    If (lado(i) = lado(j)) Then
                        flag += 1
                    End If
                Next
            Next
            If (flag = 3) Then
                Console.Write(" ---> Equilatero")
            Else

                flag = 0
                For i As Integer = 0 To 1
                    For j As Integer = i + 1 To lado.Length - 1
                        If (lado(i) <> lado(j)) Then
                            flag += 1
                        End If
                    Next
                Next
                If (flag = 3) Then
                    Console.Write(" ---> Escaleno")
                Else
                    Console.Write(" ---> Isosceles")
                End If
            End If

        Else

            Console.Write("No es un triangulo")
        End If

    End Sub


End Module
