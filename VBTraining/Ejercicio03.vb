Module Ejercicio03

    Sub Main()

        Console.WriteLine("Escribe tu nombre")
        Dim nombre = Console.ReadLine()

        Console.WriteLine("Escribe tu edad")
        Dim texto = Console.ReadLine()

        Dim edad = Convert.ToInt32(texto)

        Console.WriteLine("Te llamas " & nombre & " y tienes " & edad & " años")

    End Sub


End Module
