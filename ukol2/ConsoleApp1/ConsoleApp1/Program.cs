


using System;

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
                    //case "kvádr":
                    //    ProcessCuboid();
                    //    break;
                    //case "koule":
                    //    ProcessSphere();
                    //    break;
                    //case "kužel":
                    //    ProcessCone();
                    //    break;
                    //case "obecný trojúhelník":
                    //    ProcessTriangle();
                    //    break;
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
                Console.WriteLine($"Krychle - Povrch = " +  (povrch));
                break;
            }
            else
            {
                Console.WriteLine("Neplatný vstup pro délku. Zadejte prosím kladné číslo.");
            }
        }
        

    }











}




