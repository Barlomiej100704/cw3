using System;

class Program
{
    static void Main()
    {
        int min = 1;
        int max = 20;
        int zgadnij;

        do
        {
            zgadnij = (min + max) / 2;

            Console.WriteLine("Czy liczba, którą masz na myśli, to {0}? (Wpisz: -1 - za mała, 1 - za duża, 0 - zgadłeś)", zgadnij);
            int odp = int.Parse(Console.ReadLine());

            if (odp == -1)
            {
                min = zgadnij + 1;
            }
            else if (odp == 1)
            {
                max = zgadnij - 1;
            }
            else if (odp == 0)
            {
                Console.WriteLine("Odgadłem liczbę! Jest to {0}.", zgadnij);
                break;
            }
            else
            {
                // Nieprawidłowy kod odpowiedzi, zapytaj ponownie
                Console.WriteLine("Nieprawidłowa odpowiedź. Wpisz: -1 - za mała, 1 - za duża, 0 - zgadłeś");
            }
        } while (true);
        Console.ReadLine();
    }
}
