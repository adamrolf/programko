using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Produkt
{
    public string Name;
    public double Price;

    public Produkt(string name, double price)
    {
        Name = name;
        Price = price;
    }


public virtual void ZobrazInfo()
{
    Console.WriteLine("Cena = " + Price + "CZK");
    Console.WriteLine("Nazev = " + Name);



    }
}