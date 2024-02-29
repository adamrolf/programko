class Kniha : Produkt
{
    string Author;
    public string Manufacturer;
    public Kniha(string name, double price, string author) : base(name, price)
    {
        Name = name;
        Price = price;
        Author = author;
    }


    public override void ZobrazInfo()
    {
        Console.WriteLine("Cena = " + Price + "CZK");
        Console.WriteLine("Nazev = " + Name);
        Console.WriteLine("Autor = " + Author);

    }
}
