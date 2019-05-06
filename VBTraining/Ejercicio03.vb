Module Ejercicio03

    Sub Main()

        Console.WriteLine("Escribe tu nombre")
        Dim nombre = Console.ReadLine()

        Console.WriteLine("Escribe tu edad")
        Dim texto = Console.ReadLine()

        'Dim edad = CInt(texto)
        'Integer.Parse(texto)

        Dim edad As Integer
        If (Integer.TryParse(texto, edad)) Then
            Console.WriteLine("Te llamas " & nombre & " y tienes " & edad & " años")
        End If


        'Dim edad = Convert.ToInt32(texto)



    End Sub


End Module
