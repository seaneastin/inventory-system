using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Scene
    {
        private string _name;
        private string _description;
        private int _north;
        private int _south;
        private int _east;
        private int _west;
        private string _hidden;
        private Creature[] _enemies;
        private bool _cleared = false;

        public Scene(string name, int northID, int southID, int eastID, int westID, string description, Creature[] enemies)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = eastID;
            _west = westID;
            _hidden = "nothing was found.";
            _enemies = enemies;
            if (_enemies.Length == 0)
            {
                _cleared = true;
            }
        }
        public Scene(string name, int northID, int southID, int eastID, int westID, string description, string hidden, Creature[] enemies)
        {
            _name = name;
            _description = description;
            _north = northID;
            _south = southID;
            _east = eastID;
            _west = westID;
            _hidden = hidden;
            _enemies = enemies;
            if (_enemies.Length == 0)
            {
                _cleared = true;
            }

        }

        public string GetName()
        {
            return _name;
        }
        public string GetDesription()
        {
            return _description;
        }
        public Creature[] GetEnemies()
        {
            return _enemies;
        }
        public bool GetCleared()
        {
            return _cleared;
        }

        public int ChooseExit()
        {
            //Until the player chooses a direction...
            string choice = "";
            Console.WriteLine("choose a direction");
            while (choice != "N" && choice != "S" && choice != "E" && choice != "W" )
            {
                //ask the player which way to go
                Console.WriteLine("Which direction will you go? (N/S/E/W)");
                choice = Console.ReadLine();
                choice = choice.ToUpper();
            }
            //Return the integer ID of that direction
            if (choice == "N")
            {
                return _north;
            }
            else if (choice == "S")
            {
                return _south;
            }
            else if (choice == "E")
            {
                return _east;
            }
            else if (choice == "W")
            {
                return _west;
            }
            else
            {
                //if we somehow have an invalid choice, we can return -1.
                //We have to make sure the Map knows not to attempt to
                //travel to -1
                return -1;
            }
            

        }
        public string GetHidden()
        {
            return _hidden;
        }
        
    }
}
