namespace HttpClientChallenges
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpPokemonGets trainer = new HttpPokemonGets("https://pokeapi.co/api/v2/");

            Console.WriteLine("Random Pokemon from 1-151: ");

            await trainer.DisplayRandomPokemonStats();

            Console.ReadLine();
        }
    }
}
