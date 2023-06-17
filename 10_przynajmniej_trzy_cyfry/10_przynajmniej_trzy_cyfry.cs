using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę: ");
        int numer = int.Parse(Console.ReadLine());

        if (numer >= 100)
        {
            Console.WriteLine("Kolejne cyfry liczby:");

            while (numer != 0)
            {
                int digit = numer % 10;
                Console.WriteLine(digit);
                numer /= 10;
            }
        }
        else
        {
            Console.WriteLine("Podana liczba nie ma co najmniej 3 cyfr.");
        }
        Console.ReadLine();
    }
}
