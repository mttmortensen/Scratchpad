namespace HttpClientChallenges
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpToDoDelete todo = new HttpToDoDelete("https://jsonplaceholder.typicode.com/");

            Console.WriteLine("Enter the ID to delete a ToDo Item: ");
            int Id = int.Parse(Console.ReadLine());

            var results = await todo.DeleteToDoItem(Id);

            Console.WriteLine($"Item is now deleted: {results}");

            Console.ReadLine();
        }
    }
}
