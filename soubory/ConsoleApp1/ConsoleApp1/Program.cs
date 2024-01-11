string[] pokemons = File.ReadAllLines("npokedex.txt");

foreach (string pokemon in pokemons)
{
    Console.WriteLine(pokemon);
}

StreamReader reader = new StreamReader("npokedex.txt");

while (!reader.EndOfStream)
{
    string line = reader.ReadLine();
    Console.WriteLine(line);
}

reader.Close();

using System.Net.
NetworkInformation;

Console.WriteLine("What is zour favorite pokemon<");

string favorite = Console.ReadLine();

File.WriteAllText("favorite.txt", favorite);

string previousFavorite = File.ReadAllText("favorite.txt");
Console.WriteLine("What your previous favorite pokemon was:");
Console.WriteLine(previousFavorite);

string[] pokemonStats = File.ReadAllLines("npokedex.txt");

foreach (string pokemon in pokemonStats) 
{
    string[] parts = pokemon.Split(",");
    Console.WriteLine("pokemon:" + (parts[1]));
    Console.WriteLine("type1:" + (parts[2]));
    Console.WriteLine("type2:" + (parts[3]));
}
