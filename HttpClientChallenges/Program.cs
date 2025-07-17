namespace HttpClientChallenges
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter a Id to get a Star Wars Character: ");
            int charId = Int32.Parse(Console.ReadLine());

            HttpStarWars starClient = new HttpStarWars("http://swapi.info/api/people/");

            string results = await starClient.GetStringAsync(charId);

            Console.WriteLine($"Here's your Star Wars Character: \n{results}");

            Console.ReadLine();
        }
    }
}
