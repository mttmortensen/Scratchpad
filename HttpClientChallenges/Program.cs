namespace HttpClientChallenges
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpPokemonGets trainer = new HttpPokemonGets("https://pokeapi.co/api/v2/");

            Console.WriteLine("Enter the name of a Pokemon to look up: ");
            string pokemon = Console.ReadLine();

            await trainer.DisplayPokemonAbilities(pokemon);

            Console.ReadLine();
        }
    }
}
