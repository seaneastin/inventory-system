using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Encounter
    {
        private Monster[] _goodMonsters;
        private Monster[] _badMonsters;

        public Encounter(Monster[] team1, Monster[] team2)
        {
            _goodMonsters = team1;
            _badMonsters = team2;
        }
        public void print()
        {
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Monster currentMonster = _goodMonsters[i];
                currentMonster.Print();
            }
        }
    }

}
