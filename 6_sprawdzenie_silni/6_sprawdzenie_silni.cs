using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę do sprawdzenia: ");
        int x = int.Parse(Console.ReadLine());

        int n = 0;
        int oblicz = 1;

        while (oblicz <= x)
        {
            if (oblicz == x)
            {
                Console.WriteLine("Liczba {0} jest silnią liczby {1}", x, n);
                return;
            }

            n++;
            oblicz *= n;
        }

        Console.WriteLine("Podana liczba nie jest silnią żadnej liczby naturalnej.");
        Console.ReadLine();
    }
}
