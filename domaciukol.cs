
while (true)
{
    bool success;
    double vstupA;
    double vstupB;
    double vstupC;


    double DoubleParse()
    {
        string gun = Console.ReadLine();
        success = double.TryParse(gun, out double result);
        return result;
    }

    do
    {
        Console.WriteLine("Rovnice: ax²+bx+c=0");
        Console.Write("a = ");
        vstupA = DoubleParse();

        if (vstupA == 0)
        {
            Console.WriteLine("Neni to kvadraticka rovnice, zadej nenulové číslo.");
        }
    } while (success == false);

    do
    {
        Console.Write("b = ");
        vstupB = DoubleParse();
    } while (success == false);

    do
    {
        Console.Write("c = ");
        vstupC = DoubleParse();
    } while (success == false);



    double diskriminant = vstupB * vstupB - 4 * vstupC * vstupA;
    double reseni1 = (-vstupB + Math.Sqrt(diskriminant)) / (2 * vstupA);
    double reseni2 = (-vstupB - Math.Sqrt(diskriminant)) / (2 * vstupA);

    if (diskriminant < 0)
    {
        Console.WriteLine("Rovnice nemá řešení");
    }
    else if (diskriminant > 0)
    {
        Console.WriteLine($"Řešením rovnice jsou čísla {reseni1} a {reseni2}");
    }
    else if (diskriminant == 0)
    {
        Console.WriteLine($"Řešení rovnice je číslo {reseni1}");
    }
    
    
        Console.Write("Zadejte hodnotu x: ");
        string inputX = Console.ReadLine();



        double x;
        if (double.TryParse(inputX, out x))
        {
            double result = vstupA * x * x + vstupB * x + vstupC;
            Console.WriteLine($"Pro x = {x}, f(x) = {result}");
        }

    

    Console.Write("Pokud budete chtít program ukončit, napište: konec. Pokud budete chtít pokračovat, napiště jakékoli písmeno.");
        string continueInput = Console.ReadLine().ToLower();
        if (continueInput == "konec")
        {
            break;
        }
    
}