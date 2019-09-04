using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Creature
    {
        protected int _health = 10;
        protected int _maxHealth = 10;
        public virtual void Fight(Creature target)
        {

            Console.WriteLine("you should not be seeing this line contact developer");
        }
        public virtual void Fight(Creature[] targets)
        {
            Console.WriteLine("you should not be seeing this line contact developer");
        }
        public virtual int GetDamage()
        {
            return 0;
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
        public virtual string getName()
        {
            return "if this is your name please contact the developer this should not happen"; //this line is overided and not used just leave it
        }
        public virtual void Print()
        {

        }
    }
}
