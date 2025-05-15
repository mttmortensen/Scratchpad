using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad
{
    // Base class for characters
    public class Character
    {
        protected string _name;
        protected string _classes;
        protected int _health = 0;

        public Character(string name, string classes)
        {
            _name = name;
            _classes = classes;
            _health = 100; // Default health

        }

        public virtual string Attack()
        {
            return $"The {_classes} is attacking!";
        }
    }
    public class Warror : Character
    {
        public Warror(string name, int health) : base(name, "Warror")
        {
            _health = health;
        }
        public override string Attack()
        {
            return $"{_name} the {_classes} is attacking with a sword!";
        }

    }
}
