using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad
{
    public class gptOOP_050725
    {
        
        public void GreetUser()
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();

            User user = new User(userName);
            Console.WriteLine(user.Greet());
        }

        public void ChangeUserName()
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();

            User user = new User(userName);
            Console.WriteLine(user.Greet());

            Console.WriteLine("Enter a new name: ");
            string newName = Console.ReadLine();
            user.ChangeName(newName);
            Console.WriteLine($"Name changed to: {user.Greet()}");
        }

        public void GreetAdminUser()
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            AdminUser adminUser = new AdminUser(userName);
            Console.WriteLine(adminUser.Greet());
        }
    }

    internal class User
    {
        protected string _name;

        public User(string name)
        {
            _name = name;
        }

        public virtual string Greet()
        {
            return $"Hello {_name}!";
        }

        public string ChangeName(string newName) 
        {
            return _name = newName;
        }
    }

    internal class AdminUser : User
    {
        public AdminUser(string name) : base(name)
        {}

        public override string Greet()
        {
            return $"Hello Admin {_name}!";
        }
    }
}
