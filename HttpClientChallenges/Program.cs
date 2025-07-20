namespace HttpClientChallenges
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            Console.WriteLine("Enter your Todo Item title: ");
            string? title = Console.ReadLine();

            Console.WriteLine("Has it been completed? (True/False)");
            bool done = bool.Parse(Console.ReadLine());

            HttpToDoPost todo = new HttpToDoPost("https://jsonplaceholder.typicode.com/");
            TodoItem? item = await todo.PostToDoItem(title, done);

            if(item.Completed)
            {
                Console.WriteLine($"Added! Todo Item: {item.Title}, has been completed");
            }
            else 
            {
                Console.WriteLine($"Added! Todo Item: {item.Title}, hasn't been completed yet");
            }

            Console.ReadLine();
        }
    }
}
