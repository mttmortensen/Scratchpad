using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad
{
    public class gptOOP_050725
    {
        

        public void TestMethod()
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();

            User user = new User(userName);
            Console.WriteLine(user.Greet());
        }
    }

    internal class User
    {
        private string _name;

        public User(string name)
        {
            _name = name;
        }

        public string Greet()
        {
            return $"Hello {_name}!";
        }
    }
}
