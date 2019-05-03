Module Ejercicio05

    Sub Main()

        Console.WriteLine("Escribe un día de la semana")
        Dim dia = Console.ReadLine()

        Select Case dia.ToLower()

            Case "lunes", "martes", "miercoles", "jueves", "viernes"
                Console.WriteLine("No es fin de semana")

            Case "sabado", "domingo"
                Console.WriteLine("Es fin de semana")


            Case Else
                Console.WriteLine("Ese día no es correcto")
        End Select

    End Sub


End Module
