
class Program
{
    static void Main()
    {
        string[] shapes = { "čtverec", "obdélník", "kruh", "krychle", "kvádr", "koule", "kužel", "obecný trojúhelník" };

        while (true)
        {
            Console.WriteLine("Možné tvary: čtverec, obdélník, kruh, krychle, kvádr, koule, kužel, obecný trojúhelník");
            Console.Write("Zvolte tvar, se kterým chcete pracovat: ");
            string selectedShape = Console.ReadLine().ToLower();

            if (Array.Exists(shapes, shape => shape.ToLower() == selectedShape))
            {
                switch (selectedShape)
                {
                    case "čtverec":
                        ProcessSquare();
                        break;
                    case "obdélník":
                        ProcessRectangle();
                        break;
                    case "kruh":
                        ProcessCircle();
                        break;
                    case "krychle":
                        ProcessCube();
                        break;
                    case "kvádr":
                        ProcessCuboid();
                        break;
                    case "koule":
                        ProcessSphere();
                        break;
                    case "kužel":
                        ProcessCone();
                        break;
                    case "obecný trojúhelník":
                        ProcessTriangle();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Neplatný vstup. Zvolte tvar ze seznamu.");
            }

            Console.Write("Chcete pracovat s jiným tvarem? (ano/ne): ");
            string continueInput = Console.ReadLine().ToLower();
            if (continueInput != "ano")
            {
                break;
            }
        }

        Console.WriteLine("Program byl ukončen.");
    }

    static void ProcessSquare()
    {
        double side;

        while (true)
        {
            Console.Write("Zadejte délku strany čtverce: ");
            if (double.TryParse(Console.ReadLine(), out side) && side > 0)
            {
                double area = side * side;
                double perimeter = 4 * side;

                Console.WriteLine($"Čtverec - Délka strany: {side}, Obsah: {area}, Obvod: {perimeter}");
                break;
            }
            else
            {
                Console.WriteLine("Neplatný vstup. Zadejte prosím kladné číslo pro délku strany.");
            }
        }
    }

    static void ProcessRectangle()
    {
        double length, width;

        while (true)
        {
            Console.Write("Zadejte délku obdélníku: ");
            if (double.TryParse(Console.ReadLine(), out length) && length > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Neplatný vstup pro délku. Zadejte prosím kladné číslo.");
            }
        }

        while (true)
        {
            Console.Write("Zadejte šířku obdélníku: ");
            if (double.TryParse(Console.ReadLine(), out width) && width > 0)
            {
                double area = length * width;
                double perimeter = 2 * (length + width);

                Console.WriteLine($"Obdélník - Délka: {length}, Šířka: {width}, Obsah: {area}, Obvod: {perimeter}");
                break;
            }
            else
            {
                Console.WriteLine("Neplatný vstup pro šířku. Zadejte prosím kladné číslo.");
            }
        }
    }

    static void ProcessCircle()
    {
        double radius;

        while (true)
        {
            Console.Write("Zadejte poloměr kruhu: ");
            if (double.TryParse(Console.ReadLine(), out radius) && radius > 0)
            {
                double area = Math.PI * radius * radius;
                double circumference = 2 * Math.PI * radius;

                Console.WriteLine($"Kruh - Poloměr: {radius}, Obsah: {area}, Obvod: {circumference}");
                break;
            }
            else
            {
                Console.WriteLine("Neplatný vstup. Zadejte prosím kladné číslo pro poloměr.");
            }
        }
    }
    static void ProcessCube()
    {
        double length;

        while (true)
        {
            Console.Write("Zadejte délku strany: ");
            if (double.TryParse(Console.ReadLine(), out length) && length > 0)
            {
                double povrch = 6 * (length * length);
                double objem = length * length * length;
                Console.WriteLine($"Krychle - Povrch = " + (povrch) + "   Objem = " + (objem));
                break;
            }
            else
            {
                Console.WriteLine("Neplatný vstup. Zadejte prosím kladné číslo.");
            }
        }


    }

    static void ProcessCuboid()
    {

        double lengthA;
        double lengthB;
        double lengthC;

        while (true)
        {
            Console.Write("Zadejte postupně šířku, výšku a hloubku kvádru: ");
            if ((double.TryParse(Console.ReadLine(), out lengthA) && lengthA > 0) &&
                (double.TryParse(Console.ReadLine(), out lengthB) && lengthB > 0) &&
                (double.TryParse(Console.ReadLine(), out lengthC) && lengthC > 0))
            {
                double povrch = 2 * ((lengthA * lengthB) + (lengthB * lengthC) + (lengthA * lengthC));
                double objem = lengthA * lengthB * lengthC;
                Console.WriteLine($"Kvádr - Povrch = " + (povrch) + "   Objem = " + (objem));
                break;
            }
            else
            {
                Console.WriteLine("Neplatný vstup. Zadejte prosím kladné číslo.");
            }
        }


    }
    static void ProcessSphere()
    {
        double length;

        while (true)
        {
            Console.Write("Zadejte poloměr koule: ");
            if (double.TryParse(Console.ReadLine(), out length) && length > 0)
            {
                double povrch = 4 * Math.PI * length * length;
                double objem = 4/3 * Math.PI * length * length * length;
                Console.WriteLine($"Koule - Povrch = " + (povrch) + "   Objem = " + (objem));
                break;
            }
            else
            {
                Console.WriteLine("Neplatný vstup. Zadejte prosím kladné číslo.");
            }
        }


    }
    static void ProcessCone()
    {

        double lengthA;
        double lengthB;
        double lengthC;

        while (true)
        {
            Console.Write("Zadejte postupně poloměr podstavy a výšku a délku strany kužele: ");
            if ((double.TryParse(Console.ReadLine(), out lengthA) && lengthA > 0) &&
                (double.TryParse(Console.ReadLine(), out lengthB) && lengthB > 0) &&
                (double.TryParse(Console.ReadLine(), out lengthC) && lengthB > 0))

            {
                double povrch = Math.PI * lengthA * (lengthA + lengthB);
                double objem = 1/3 * Math.PI * lengthA + lengthA * lengthC ;
                Console.WriteLine($"Ku6el - Povrch = " + (povrch) + "   Objem = " + (objem));
                break;
            }
            else
            {
                Console.WriteLine("Neplatný vstup. Zadejte prosím kladné číslo.");
            }
        }


    }
    static void ProcessTriangle()
    {
        double lengthA;
        double lengthB;
        double lengthC;
        while (true)
        {
            Console.Write("Zadejte postupně délku strany a výšku trojuhelníku: ");
            if ((double.TryParse(Console.ReadLine(), out lengthA) && lengthA > 0) &&
                (double.TryParse(Console.ReadLine(), out lengthB) && lengthB > 0) &&
                (double.TryParse(Console.ReadLine(), out lengthC) && lengthC > 0))
            {
               
                double obvod = lengthA + lengthB + lengthC;
                double povrch = Math.Sqrt(obvod * (obvod - lengthA) * (obvod - lengthB) * (obvod - lengthC));
                Console.WriteLine($"Koule - Povrch = " + (povrch) + "   Objem = " + (obvod));
                break;
            }
            else
            {
                Console.WriteLine("Neplatný vstup. Zadejte prosím kladné číslo.");
            }
        }
    }

}

