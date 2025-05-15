using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad
{
    interface IDamageable
    {
        string TakeDamage(int amount);
    
    }

    interface ICanHeal
    {
        string Heal(int amount);
    }

    interface ICanCastMagic
    {
        string CastSpell();
    }


    // Base class for characters
    public abstract class Character: IDamageable, ICanHeal
    {
        protected string _name;
        protected string _classes;
        private int _health = 0;
        private int _maxHealth = 100; // Default max health

        public Character(string name, string classes)
        {
            _name = name;
            _classes = classes;
            _health = 100; // Default health

        }

        public abstract string Attack();

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

        public string Heal(int amount) 
        {
            int newHealth = _health + amount;

            if (newHealth == _maxHealth) 
            {
                return $"{_name}'s health is already at max";
            }

            if (newHealth > _maxHealth)
            {
                _health = newHealth;
            }

            return $"{_name}'s heals for {amount}";
        }

        public virtual string Rest() 
        {
            this.Heal(10);
            return $"{_name} rests and recovers 10 health.";
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

    public class Mage : Character, ICanCastMagic
    {
        private int _mana = 75; // Mana set to 75 for testing
        public Mage(string name) : base(name, "Mage")
        {}
        public override string Attack()
        {
            return $"{_name} the {_classes} casts a fireball!";
        }

        public override string Rest()
        {

            base.Rest();
            _mana += 10; // Rest for Mage subclass restores 10 mana
            return $"{_name} the {_classes} meditates and recovers 10 Mana and HP.";

        }

        public string GetMana()
        {
            return $"{_name}'s mana is currently at {_mana}";
        }

        public string CastSpell() 
        {
            if (_mana >= 10) 
            {
                _mana -= 10; // Casting a spell costs 10 mana
                return $"{_name} casts a spell!";
            }
            else
            {
                return $"{_name} does not have enough mana to cast a spell.";
            }
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
