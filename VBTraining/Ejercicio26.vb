Module Ejercicio26

    Sub Main()

        Dim valorhr, hrstrab, antigue As Double
        Dim nombre As String

        Console.Write("Nombre:")
        nombre = Console.ReadLine()

        Console.Write("Valor hora:")
        valorhr = CDbl(Console.ReadLine())

        Console.Write("Antiguedad:")
        antigue = CDbl(Console.ReadLine())

        Console.Write("Horas trabajadas:")
        hrstrab = CDbl(Console.ReadLine())

        Console.Clear()
        Console.WriteLine("Nombre: {0}", nombre)
        Console.WriteLine("Antiguedad: {0}", antigue)
        Console.WriteLine("Valor hora: {0}", valorhr)
        Console.WriteLine("Total a cobrar: {0}", valorhr * hrstrab + antigue * 30) ' TOTAL 
        Console.WriteLine("Total del descuento: {0}", (valorhr * hrstrab + antigue * 30) * 0.13) ' TOTAL * 0,13 
        Console.WriteLine("Total con descuento: {0}", ((valorhr * hrstrab + antigue * 30) - (valorhr * hrstrab + antigue * 30) * 0.13)) ' TOTAL - DESC 


    End Sub


End Module
