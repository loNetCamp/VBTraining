Module Ejercicio15

    Sub Main()

        Dim bas, alt As Double

        Console.Write("Introduzca base:")
        bas = CDbl(Console.ReadLine())
        Console.Write("Introduzca altura:")
        alt = CDbl(Console.ReadLine())

        Console.Write($"El área del triángulo es {(bas * alt) / 2}")


    End Sub


End Module
