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
        private int _health = 0;

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

        public string TakeDamage(int amount)
        {
            _health -= amount;
            if (_health < 0)
            {
                _health = 0;
            }

            return $"{_name} takes {amount} damage";
        }

        public string GetHealth() 
        {
            return $"{_name}'s health is currently at { _health}";
        }
    }

    // Derived classes for specific character types
    public class Warrior : Character
    {
        public Warrior(string name) : base(name, "Warrior")
        {}
        public override string Attack()
        {
            return $"{_name} the {_classes} attacks with a sword!";
        }

    }

    public class Mage : Character
    {
        public Mage(string name) : base(name, "Mage")
        {}
        public override string Attack()
        {
            return $"{_name} the {_classes} casts a fireball!";
        }
    }

    public class Thief : Character
    {
        public Thief(string name) : base(name, "Thief")
        {}
        public override string Attack()
        {
            return $"{_name} the {_classes} strikes from the shadows!";
        }
    }
}
