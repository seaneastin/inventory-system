using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace inventorysystem
{
    class Map
    {
        private int _currentLocation = 0; //ID of the current scene
        private Scene[] _sceneList; //List of all the scenes on the map
        private Creature[] _players;

        public Map(int startingSceneID, Scene[] scenes, Creature[] players)
        {
            _currentLocation = startingSceneID;
            _sceneList = scenes;
            _players = players;
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
        public void Menu()
        {
            string choice = "";
            while (choice != "0")
            {
                //let the player know hwere they are
                PrintCurrentScene();
                //print the menu
                Console.WriteLine("\nMenue:");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Travel");
                Console.WriteLine("2: Save");
                Console.WriteLine("3: Load");
                Console.WriteLine("4: search");
                Console.WriteLine("5: testcheckforcreaturesfunction");
                //get the player's choice
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Travel();
                }
                else if (choice == "2")
                {
                    Save("save.txt");
                }
                else if (choice == "3")
                {
                    Load("save.txt");
                }
                else if (choice == "4")
                {
                    Search();
                }
                else if (choice == "5")
                {
                    CheckForCreatures();
                }
            }
        }
        public void Travel()
        {
            int destination = -1;
            //If the current scene is valid...
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                //ask the player where to go
                destination = _sceneList[_currentLocation].ChooseExit();
            }
            //if the destination is on the map....
            if (destination >= 0 && destination < _sceneList.Length)
            {
                //...Go there
                CurrentSceneID = destination;
            }
            else
            {
                Console.WriteLine("There is nothing in that direction.");
                //otherwise....
                //...tell the player they cannot
            }
            CheckForCreatures();






        }
        public void Save(string path)
        {
            StreamWriter writer = File.CreateText(path);
            //write to it the say we write
            writer.WriteLine(CurrentSceneID);
            //close it
            writer.Close();
        }
        public void Load(string path)
        {
            if (File.Exists(path))
            {
                StreamReader reader = File.OpenText(path);
                CurrentSceneID = Convert.ToInt32(reader.ReadLine());
                reader.Close();
            }
            else
            {
                Console.WriteLine("Save file not found");
            }
        }
        public void Search()
        {
            CheckForCreatures();
            int destination = -1;
            //If the current scene is valid...
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                //search the room
                Console.WriteLine(_sceneList[_currentLocation].GetHidden());
            }
        }
        public void CheckForCreatures()
        {
            //If the current location is valid...
            if (_currentLocation >= 0 && _currentLocation < _sceneList.Length)
            {
                //...Check the current scene
                Scene currentScene = _sceneList[_currentLocation];
                if (currentScene.GetCleared() == false)
                {
                    //FIGHT!!!!
                    Encounter encounter = new Encounter(_players, currentScene.GetEnemies());
                    encounter.Start();

                }
            }
        }

    }
}
