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
                //i will print all the things in goodmonsters array
                Monster currentMonster = _goodMonsters[i];
                currentMonster.Print();
            }
            for (int i = 0; i < _badMonsters.Length; i++)
            {
                //i will print all the things in badmonsters array
                Monster currentMonster = _badMonsters[i];
                currentMonster.Print();
            }
        }
        public void BeginRound()
        {
            //Iterate through good monsters
            //have the current good monster fight the first bad monster
            for (int i = 0; i < _goodMonsters.Length; i++)
            {
                Monster currentMonster = _goodMonsters[i];
                currentMonster.Print();
                currentMonster.fight(_badMonsters);
            }

            for (int i= 0; i < _badMonsters.Length; i++)
            {
                Monster currentMonster = _badMonsters[i];
                currentMonster.Print();
                currentMonster.fight(_goodMonsters);
            }
            //iterate through bad monsters
            //have the current bad monster fight the first good monster
        }

    }

}
