using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Character : Creature
    {
        private string _name = "";
        private int _xp = 0;
        private int _level = 1;
        private int[] _requiredXP = { 100, 300, 600, 1000 }; //required xp for leveling up
        protected int _mana = 100;
        protected int _strength = 5;
        protected int _dexterity = 5;
        protected int _wisdom = 5;
        protected int _defence;
        protected int _damage;

        private Inventory inventory = new Inventory();


        public Character(string Getname)
        {
            _name = Getname;
            _health = 100;
            _maxHealth = 100;
        }

        public override string getName()
        {
            return _name;
        }
        public override int GetDamage()
        {
            return _strength + inventory.GetItemDamage();
            //return total damage
        }
        public override void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("level " + _level);
            Console.WriteLine("experience " + _xp);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Dexterity: " + _dexterity);
            Console.WriteLine("Wisdom: " + _wisdom);
            Console.WriteLine("strength: " + _strength);
            Console.WriteLine("Combat Damage: " + (_strength + inventory.GetItemDamage()));


        }
        public void OpenInventory()
        {
            inventory.Menu();
        }
        public int Experience
        {
            get
            {
                return _xp;

            }
            set
            {
                _xp = value;
                Console.WriteLine(_name + " gained experience and now has " + _xp);
                if (_level <= _requiredXP.Length)
                {
                    if (_xp >= _requiredXP[_level - 1]) //subtracts 1 to make sure taht when you level up it uses the currrect slot
                    {
                        _level++;
                        Console.WriteLine(_name + "s level increased to " + _level + "!");
                    }
                }
            }
        }
        public override void Fight(Creature[] targets)
        {
            if (Health <= 0)
            {
                return;
            }
            bool validInput = false;
            while (!validInput)

            {
                int choice = 0;
                Console.WriteLine("/nWho will " + getName() + "fight? ");
                for (int i = 0; i < targets.Length; i++)
                {
                    Console.WriteLine(i + ":" + targets[i].getName());
                }
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice <= targets.Length && choice >= 0)
                {
                    Fight(targets[choice]);
                    validInput = true;
                }


                //print menu
                //Iterate throguh targets
                //print each option with a number
                //Console.ReadLine to get user input
                //convert the input to an integer
                //check taht the choice is valid

            }

        }
        public override void Fight(Creature target)
        {
            int damage = GetDamage();
            if (Health <= 0)
            {
                return;
            }
            // Subtract the damage from the target monster's health
            target.Health -= damage;
            // target's health - this monster's damage
            Console.WriteLine(getName() + " attacks! " + target.getName() + " Takes " + damage + "damage!");
        }
    }
    
}
