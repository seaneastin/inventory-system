using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Knight : Character
    {
        public Knight(string name) : base(name)
        {
            _health = 300;
            _maxHealth = 300;
            _mana = 30;
            _strength = 7;
            _dexterity = 2;
            _wisdom = 5;

        }
    }
}
