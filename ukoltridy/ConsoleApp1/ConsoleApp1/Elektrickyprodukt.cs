
class Elektrickyprodukt : Produkt
{
     public string Manufacturer;
    public Elektrickyprodukt(string name, double price, string manufacturer) : base(name, price)
    {
        Name = name;
        Price = price;
        Manufacturer = manufacturer;
    }

    public override void ZobrazInfo()
    {
        Console.WriteLine("Cena = " + Price + "CZK");
        Console.WriteLine("Nazev = " + Name);
        Console.WriteLine("Vyrobce = " + Manufacturer);
        Console.WriteLine(" ");

    }
}