Module Ejercicio04

    Sub Main()

        Console.WriteLine("Escribeme el primer numero")
        Dim num1 = Convert.ToInt32(Console.ReadLine())

        Console.WriteLine("Escribeme el segundo numero")
        Dim num2 = Convert.ToInt32(Console.ReadLine())

        If (num1 >= num2) Then
            Console.WriteLine("El primer numero es mayor o igual que el segundo")
        Else
            Console.WriteLine("El segundo numero es mayor que el primero")
        End If

    End Sub


End Module
