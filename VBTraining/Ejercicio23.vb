Module Ejercicio23

    Sub Main()

        For i As Integer = 0 To 100

            If (EsPrimo(i)) Then

                Console.WriteLine(i & " es primo")
            End If
        Next


    End Sub

    Function EsPrimo(ByVal numero As Integer) As Boolean

        Dim a = 0
        For i As Integer = 1 To numero
            If (numero Mod i = 0) Then
                a += 1
            End If
        Next

        Return Not (a <> 2)

    End Function

End Module
