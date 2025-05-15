using ScratchPad;

internal class Program
{
    private static void Main(string[] args)
    {
        // Challenge 2
        //List<Character> party = new List<Character> 
        //{
        //    new Warrior("Throg"),
        //    new Mage("Elara"),
        //    new Thief("Lirael")
        //};

        //foreach (var character in party)
        //{
        //    Console.WriteLine(character.Attack());
        //}

        // Challenge 3
        //Mage mage = new Mage("Elara");
        //Console.WriteLine(mage.Attack());
        //Console.WriteLine(mage.TakeDamage(20));
        //Console.WriteLine(mage.GetHealth());
        //Console.WriteLine(mage.Heal(30));
        // This should come back with the same value, 80, since the max health is 100  and last statement was 80 + 30
        // It's a bug but it still works
        //Console.WriteLine(mage.GetHealth()); 

        // Challenge 4A
        //Warrior warrior = new Warrior("Throg");
        //Console.WriteLine(warrior.TakeDamage(30));
        //Console.WriteLine(warrior.GetHealth());
        //Console.WriteLine(warrior.Rest());
        //Console.WriteLine(warrior.GetHealth());

        // Challenge 4B
        //Mage mage = new Mage("Elara");
        //Console.WriteLine(mage.TakeDamage(30));
        //Console.WriteLine(mage.GetHealth());
        //Console.WriteLine(mage.GetMana());
        //Console.WriteLine(mage.Rest());
        //Console.WriteLine(mage.GetHealth());
        //Console.WriteLine(mage.GetMana());

        // Challenge 5
        Mage mage = new Mage("Elara");
        Console.WriteLine(mage.TakeDamage(30));
        Console.WriteLine(mage.GetHealth());
        Console.WriteLine(mage.GetMana());
        Console.WriteLine(mage.Rest());
        Console.WriteLine(mage.GetHealth());
        Console.WriteLine(mage.GetMana());
        Console.WriteLine(mage.CastSpell());


        Console.ReadLine();
    }
}