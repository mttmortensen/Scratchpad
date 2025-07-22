namespace HttpClientChallenges
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpToDo todo = new HttpToDo("https://jsonplaceholder.typicode.com/");


            Console.WriteLine("Enter the ID to update a ToDo Item: ");
            int Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the updated Title: ");
            string updatedTitle = Console.ReadLine();

            Console.WriteLine("Now update the status: (True/False)");
            bool updatedStatus = bool.Parse(Console.ReadLine());

            ToDoItem updatedBody = new ToDoItem() 
            {
                Id = Id,
                Title = updatedTitle,
                Completed = updatedStatus
            };

            ToDoItem? updatedTodo = await todo.UpdateToDoItem(Id, updatedBody);

            Console.WriteLine($"Updated! Todo Item: {updatedTodo.Title}");
            Console.WriteLine($"\n Updated Status: {updatedTodo.Completed}");
            Console.WriteLine($"\n Todo Item ID: {updatedTodo.Id}");

            Console.ReadLine();
        }
    }
}
