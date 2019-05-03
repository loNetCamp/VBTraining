Module Ejercicio27

    Sub Main()
        Dim num As Integer

        Do

            Console.Write("Introduzca un número entre 0 y 10:")
            num = CInt(Console.ReadLine())

        Loop While (num < 1 Or num > 9)

        For i As Integer = 1 To 9
            Console.WriteLine("{0} x {1} = {2}", num, i, num * i)
        Next


    End Sub


End Module
