Module EjercicioLinq

    Sub Main()

        Dim lista = New List(Of Integer)() From {31, 42, 39, 4, 5, 11, 99, 67, 66, 1, -45}

        Console.WriteLine($"original = {String.Join(", ", lista)}")

        Console.WriteLine($"max = {lista.Max()}")
        Console.WriteLine($"menor = {lista.Min()}")
        Console.WriteLine($"total = {lista.Count()}")
        Console.WriteLine($"tercero = {lista.ElementAt(2)}")
        Console.WriteLine($"Media = {lista.Average()}")
        Console.WriteLine($"tiene_par = {lista.Any(Function(i) i Mod 2 = 0)}")
        Console.WriteLine($"todos_pares = {lista.All(Function(i) (i Mod 2) = 0)}")
        Console.WriteLine($"entre10y20 = {lista.Exists(Function(i) (i >= 10) And (i <= 20))}")
        Console.WriteLine($"totalPares = {lista.Where(Function(i) (i Mod 2) = 0).Count()}")
        Console.WriteLine($"primero = {lista.First()}")
        Console.WriteLine($"ultimo = {lista.Last()}")
        Console.WriteLine($"primer_impar = {String.Join(", ", lista.First(Function(i) (i Mod 2) <> 0))}")
        Console.WriteLine($"ocho_ultimos = {String.Join(", ", lista.Skip(lista.Count - 8))}")
        Console.WriteLine($"seis_primeros = {String.Join(", ", lista.Take(6))}")
        Console.WriteLine($"primos = {String.Join(", ", lista.Where(Function(i) Ejercicio23.EsPrimo(i)).Take(2))}")
        Console.WriteLine($"suma2 = {String.Join(", ", lista.Skip(CInt(Math.Floor(lista.Count / 2))).Take(3).Sum())}")
        Console.WriteLine($"ascendente = {String.Join(", ", lista.OrderBy(Function(i) i))}")
        Console.WriteLine($"descendente = {String.Join(", ", lista.OrderByDescending(Function(i) i))}")
        Dim start = CInt(Math.Floor(lista.Count / 2))
        lista.Reverse(start, lista.Count - start)
        Console.WriteLine($"reversed = {String.Join(", ", lista)}")

    End Sub


End Module
