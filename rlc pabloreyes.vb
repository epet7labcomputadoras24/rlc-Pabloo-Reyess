Imports System

Module Program
    Sub Main()
        Dim R As Single
        Dim l As Single
        Dim c As Single
        Dim f1 As Single
        Dim xl As Single
        Dim xc As Single
        Dim x As Single
        Dim A As Single
        Dim M As Single
        Dim f0 As Single
        Const PI As Single = 3.1416
        Console.WriteLine("ingrece el valor de la resistencia")
        R = Console.ReadLine()
        Console.WriteLine("ingrece el valor de la bobina")
        l = Console.ReadLine()
        Console.WriteLine("ingrece el valor de la capasitor:")
        c = Console.ReadLine()
        Console.WriteLine("ingrece el valor de la frecuencia")
        f1 = Console.ReadLine()
        xl = 2 * PI * f1 * l
        Console.WriteLine("el valor de la ractancia inductiva  es:" & xl)
        Console.WriteLine("toque enter para ver el valor de la reactancia capacitiva")
        Console.ReadLine()
        xc = 1 / (2 * PI * f1 * c)
        Console.WriteLine("el valor de la reactancia capacitiva es:" & xc)
        Console.WriteLine("toque enter para ver el valor de la reactancia total")
        Console.ReadLine()
        x = xl - xc
        Console.WriteLine("si la reactancia total es negativa es mas capasitiva que inductiva y si es positiva es mas inductiva que capacitiva:" & x)
        Console.WriteLine("toque enter para ver el resultado del modulo")
        Console.ReadLine()
        M = Math.Sqrt((R) ^ 2 + (x) ^ 2)
        Console.WriteLine("el valor del modulo es:" & M)
        Console.WriteLine("toque enter para ver el resultado del angulo")
        Console.ReadLine()
        A = (Math.Atan(-x / R) * 180) / PI
        Console.WriteLine("el valor del angulo  es:" & A)
        Console.WriteLine("toque enter para ver la frecuencia de resonacia del circuito")
        Console.ReadLine()
        f0 = 1 / (2 * PI * Math.Sqrt(l * c))
        Console.WriteLine("la frecuencia de resonacia del circuito es:" & f0)
        Console.ReadLine()

    End Sub
End Module
