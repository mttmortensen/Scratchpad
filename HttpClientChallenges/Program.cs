namespace HttpClientChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Id to get a Star Wars Character: ");
            int charId = Int32.Parse(Console.ReadLine());

            HttpStarWars starClient = new HttpStarWars("https://swapi.dev/api/people/");

            Task<string> results = starClient.GetStringAsync(charId);

            Console.WriteLine($"Here's your Star Wars Character: {results}");
        }
    }
}
