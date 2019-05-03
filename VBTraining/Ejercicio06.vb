Module Ejercicio06

    Sub Main()

        Console.WriteLine("Escribe el precio del producto")
        Dim precio = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("Escribe la forma de pago: tarjeta o efectivo")
        Dim forma = (Console.ReadLine()).ToLower()

        If (forma.Equals("tarjeta")) Then

            Console.WriteLine("Introduce el numero de tarjeta")
            Dim numero_cuenta = Convert.ToInt32(Console.ReadLine())

            Console.WriteLine("El producto con precio " & precio & " se ha pagado " &
                "con el numero de cuenta " & numero_cuenta)

        ElseIf (forma.Equals("efectivo")) Then

            Console.WriteLine("El producto con precio " & precio & " se ha pagado")

        Else

            Console.WriteLine("La forma de pago no es correcta")

        End If

    End Sub


End Module
