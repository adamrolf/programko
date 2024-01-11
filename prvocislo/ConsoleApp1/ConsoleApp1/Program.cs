using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Zadej číslo:");

        int cislo = int.Parse(Console.ReadLine());

        bool jePrvocislo = JePrvocislo(cislo);

        if (jePrvocislo)
        {
            Console.WriteLine($"{cislo} je prvočíslo.");
        }
        else
        {
            Console.WriteLine($"{cislo} není prvočíslo.");
        }

        Console.ReadLine();
    }


    static bool JePrvocislo(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
while (true)
{
    Console.WriteLine("Enter number: ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        PrintPrimeFact(number);
    }
    else
    {
        Console.WriteLine("input not valid");
    }
    Console.WriteLine("\nPress any key to continue.");
    Console.ReadKey();
    Console.Clear();

}

static void PrintPrimeFact(int number)
{
    for (int i = 2; i <= number; i++)
    {
        while (number % i == 0)
        {
            Console.Write($"{i} ");
            number /= i;
        }
    }
}
