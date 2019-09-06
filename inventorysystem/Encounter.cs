using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Encounter
    {
        private Creature[] _playerteam;
        private Creature[] _Enemyteam;

        public Encounter(Creature[] team1, Creature[] team2)
        {
            _playerteam = team1;
            _Enemyteam = team2;
        }
        public void print()
        {
            for (int i = 0; i < _playerteam.Length; i++)
            {
                //i will print all the things in goodmonsters array
                Creature currentMonster = _playerteam[i];
                currentMonster.Print();
            }
            for (int i = 0; i < _Enemyteam.Length; i++)
            {
                //i will print all the things in badmonsters array
                Creature currentMonster = _Enemyteam[i];
                currentMonster.Print();
            }
        }
        public void BeginRound()
        {
            //Iterate through good monsters
            //have the current good monster fight the first bad monster
            for (int i = 0; i < _playerteam.Length; i++)
            {
                Creature currentMonster = _playerteam[i];
                currentMonster.Print();
                currentMonster.Fight(_Enemyteam);
            }

            for (int i = 0; i < _Enemyteam.Length; i++)
            {
                Creature currentMonster = _Enemyteam[i];
                currentMonster.Print();
                currentMonster.Fight(_playerteam);
            }
            //iterate through bad monsters
            //have the current bad monster fight the first good monster
        }
        public void Start()
        {
            Console.WriteLine("/nEncounter Start!");
            bool stillFighting = true;
            while (stillFighting)
            {
                //check if team 1 is allive
                bool goodisAlive = false;
                //check if team 2 is alive
                for (int i = 0; i < _playerteam.Length; i++) //good is alivwe
                {
                    Creature currentMonster = _playerteam[i];
                    if (currentMonster.Health > 0)
                    {
                        //our team is alive and not dead, break out
                        //of the loop
                        goodisAlive = true;
                        break;
                    }
                    else if (currentMonster.Health <= 0)
                    {
                        //our team may be dead
                        goodisAlive = false;
                        break;
                    }
                }
                bool badisAlive = false;
                //check if team 2 is alive
                for (int i = 0; i < _Enemyteam.Length; i++) //good is alivwe
                {
                    Creature currentMonster = _Enemyteam[i];
                    if (currentMonster.Health > 0)
                    {
                        //our team is alive and not dead, break out
                        //of the loop
                        badisAlive = true;
                        break;
                    }
                    else if (currentMonster.Health <= 0)
                    {
                        //our team may be dead
                        badisAlive = false;
                        break;

                    }
                }

                //if both teams are alive
                if (goodisAlive && badisAlive)
                {
                    //fight
                    stillFighting = true;
                    BeginRound();
                }
                if (!goodisAlive || !badisAlive)
                {
                    //stop
                    stillFighting = false;
                    if (goodisAlive)
                    {
                        for (int i = 0; i < _playerteam.Length; i++)
                        {
                            Character goodguy = _playerteam[i] as Character;
                            Console.WriteLine("you won the battle");
                            goodguy.experience += 1000000;
                        }
                    }
                }
                    print();

                    //otherwise
                    //stop
                
            }

        }

    }
}
