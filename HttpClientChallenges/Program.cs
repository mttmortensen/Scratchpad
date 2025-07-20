namespace HttpClientChallenges
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpBlogPost blog = new HttpBlogPost("https://jsonplaceholder.typicode.com/");

            var content = await blog.PostBlogPost("Some Title", "Some body");

            Console.WriteLine(content.Title, content.Id);

            Console.ReadLine();
        }
    }
}
