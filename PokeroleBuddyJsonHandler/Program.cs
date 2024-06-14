using PRJsonClasses;
using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string pokemonCollectionJson;
        PokemonCollection pokemonCollection;

        using (StreamReader r = new StreamReader("PokemonDataCollection.json"))
        {
            pokemonCollectionJson = r.ReadToEnd();
            pokemonCollection = JsonSerializer.Deserialize<PokemonCollection>(pokemonCollectionJson);
        }

        

    }
}