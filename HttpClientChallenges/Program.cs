namespace HttpClientChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpGetPokemon poke = new HttpGetPokemon("https://pokeapi.co/api/v2/pokemon/");

            Task results = poke.Get();

            Console.WriteLine($"{results}");


            Console.ReadLine();
        }
    }
}
