Module Ejercicio14

    Sub Main()

        Dim radio As Double

        Console.Write("Introduzca radio:")
        radio = CDbl(Console.ReadLine())

        Console.WriteLine("El perímetro es {0}", Math.PI * (radio * 2))
        Console.Write("El área del círculo es {0}", Math.PI * radio * radio)


    End Sub


End Module
