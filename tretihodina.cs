// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");

for (int d = 0; d < 20; d++)
{
    Console.Write(d % 3);
    Console.WriteLine(d);

}

for (int i = 0; i < 20; i++)
{

     if (i % 3 == 0 && i %5 ==0)
    {
        Console.WriteLine("fizzbuzz");

    }

   else  if (i % 3 == 0 )
    {
        Console.WriteLine("fizz");

    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("buzz");

    }

     else
    {
        Console.WriteLine(i);
    }
};

Console.WriteLine("Zadej číslo");
string A = Console.ReadLine();
Console.WriteLine("Zadej druhé číslo");
string B = Console.ReadLine();
Console.WriteLine("zadej operaci");
string C = Console.ReadLine();

int x = int.Parse(A);
int y = int.Parse(B);
if (C == "+") Console.WriteLine(x + y);
if (C == "-") Console.WriteLine(x - y);
if (C == "/") Console.WriteLine(x / y);
if (C == "*") Console.WriteLine(x * y);