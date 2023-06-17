using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wartość podstawy: ");
        int podstawa = int.Parse(Console.ReadLine());

        Console.Write("Podaj wartość wykładnika: ");
        int wykladnik = int.Parse(Console.ReadLine());

        int wynik = 1;

        for (int i = 0; i < wykladnik; i++)
        {
            wynik *= podstawa;
        }

        Console.WriteLine("Wynik potęgowania: " + wynik);
        Console.ReadLine();
    }
}
