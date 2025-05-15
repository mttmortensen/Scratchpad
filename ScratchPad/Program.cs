using ScratchPad;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Character> party = new List<Character> 
        {
            new Warrior("Throg"),
            new Mage("Elara"),
            new Thief("Lirael")
        };

        foreach (var character in party)
        {
            Console.WriteLine(character.Attack());
        }

        Console.ReadLine();
    }
}