using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Wizard : Character
    {
        public Wizard(string name) : base(name)
        {
            _health = 50;
            _mana = 200;
            _strength = 2;
            _dexterity = 5;
            _wisdom = 8;
        }
    }
}
