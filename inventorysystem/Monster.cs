using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Monster : Creature
    {
        private string _name = "";
        private int _damage = 0;

        public Monster(string name, int health, int damage)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _maxHealth = health;
        }
        public override string getName()
        {
            return _name;
        }
        public override int GetDamage()
        {
            return _damage;
        }
       /* public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                if (_health > _maxHealth)
                {
                    _health = _maxHealth;
                }
                else if (_health < 0)
                {
                    _health = 0;
                }

            }
        } */
        public override void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Damage: " + _damage);
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
        public override void Fight(Creature[] targets)
        {
            if (Health <= 0)
            {
                return;
            }
            int choice = Program.random.Next(0, targets.Length);
            Fight(targets[choice]);
          /*  bool validInput = false;
            while (!validInput)
            
            {
                int choice = 0;
                Console.WriteLine("/nWho will " + getName() + "fight? ");
                for (int i = 0; i < targets.Length; i++)
                {
                    Console.WriteLine(i + ":" + targets[i].getName());
                }
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice <=  targets.Length && choice >= 0)
                {
                    Fight(targets[choice]);
                    validInput = true;
                }  */
                

                //print menu
                //Iterate throguh targets
                //print each option with a number
                //Console.ReadLine to get user input
                //convert the input to an integer
                //check taht the choice is valid

            
        }
    }
}
