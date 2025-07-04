﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatChallenges
{
    public class gptOOP_050725
    {
        
        public void GreetUser()
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();

            IGreetable user = new User(userName);
            Console.WriteLine(user.Greet());
        }

        public void ChangeUserName()
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();

            IGreetable user = new User(userName);
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
            IGreetable adminUser = new AdminUser(userName);
            Console.WriteLine(adminUser.Greet());
        }

        public void GetUserStatus() 
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();
            User user = new User(userName);
            Console.WriteLine(user.Greet());
            Console.WriteLine("Enter your status: ");
            string status = Console.ReadLine();
            user.SetStatus(status);
            Console.WriteLine(user.GetStatus());
        }
    }

    // This interface defines the contract for greeting and changing names
    interface IGreetable
    {
        string Greet();

        string ChangeName(string newName);
    }

    internal class User : IGreetable
    {
        protected string _name;
        private string _status;

        public User(string name)
        {
            _name = name;
        }

        public string Greet()
        {
            return $"Hello {_name}!";
        }

        public string ChangeName(string newName) 
        {
            return _name = newName;
        }

        // These methods are not part of IGreetable
        public string GetStatus()
        {
            return $"Current Status: {_status}";
        }

        public string SetStatus(string status)
        {
            _status = status;
            return _status;
        }

    }

    // Using "User" allows for AdminUser not to declare _name again
    internal class AdminUser : User, IGreetable
    {

        public AdminUser(string name): base(name)
        { }

        // Unlike the User class, it seems the AdminUser class does not need to implement ChangeName
        public string Greet()
        {
            return $"Hello Admin {_name}!";
        }
    }
}
