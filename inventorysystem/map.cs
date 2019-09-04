﻿using System;
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
                //get the player's choice
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    Travel();
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






        }
    }
}
