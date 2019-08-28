using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Monster
    {
        private string _name = "";
        private int _health = 0;
        private int _maxHealth = 0;
        private int _damage = 0;

        public Monster(string name, int health, int damage)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _maxHealth = health;
        }
        public string GetName
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public int GetDamage
        {
            get
            {
                return _damage;
            }
            set
            {
                _damage = value;
            }
        }
        public int Health
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
        }
        public void print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Damage: " + _damage);
        }
    }
}
