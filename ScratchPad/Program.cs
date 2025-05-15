using ScratchPad;

internal class Program
{
    private static void Main(string[] args)
    {
        // Challenge 2
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

        // Challenge 3
        Mage mage = new Mage("Elara");
        Console.WriteLine(mage.Attack());
        Console.WriteLine(mage.TakeDamage(20));
        Console.WriteLine(mage.GetHealth());

        Console.ReadLine();
    }
}