using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class attackitem : Item
    {
        private int _damage;
        public int Damage
        {
            get
            {
                return _damage;
            }
        }
        public attackitem(string newname, int newDamage, int newWeight)
        {
            Name = newname;
            _damage = newDamage;
            weight = newWeight;

        }
        
    }
}
