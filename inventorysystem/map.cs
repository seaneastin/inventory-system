using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Map
    {
        private int _currentLocation = 0; //ID of the current scene
        private Scene[] _sceneList; //List of all the scenes on the map

        public Map(int startingSceneID, Scene[] scenes)
        {
            _currentLocation = startingSceneID;
            _sceneList = scenes;
        }

        public void PrintCurrentScene()
        {
            //If the current scene ID is withing range
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                //Print the current scene's name and description
                Console.WriteLine("");
                Console.WriteLine(_sceneList[_currentLocation].GetName());
                Console.WriteLine(_sceneList[_currentLocation].GetDesription());
            }
            else
            {
                Console.WriteLine("\nInvalid scene ID");
            }
        }
        public int CurrentSceneID
        {
            get
            {
                return _currentLocation;
            }
            set
            {
                //If value is on the map
                if (value >= 0 && value < _sceneList.Length)
                {
                    //change to the new scene
                    _currentLocation = value;
                }
                //otherwise
                else
                {
                    //print an error
                    Console.WriteLine("\nInvalid scene ID");
                }
            }
        }
    }
}
