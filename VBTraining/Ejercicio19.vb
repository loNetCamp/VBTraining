Module Ejercicio19

    Sub Main()

        Dim cms As Double

        Console.Write("Ingrese cm:")
        cms = CDbl(Console.ReadLine())

        Console.Write("{0} centímetros equivalen a {1} pies y {2} pulgadas", cms, 0.030003 * cms, 0.0336034 * cms)


    End Sub


End Module
