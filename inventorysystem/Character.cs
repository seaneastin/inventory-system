﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Character
    {
        private string _name = "";
        private int _xp = 0;
        private int _level = 1;
        private int[] _requiredXP = { 100, 300, 600, 1000 }; //required xp for leveling up

        protected int _health = 100;
        protected int _mana = 100;
        protected int _strength = 5;
        protected int _dexterity = 5;
        protected int _wisdom = 5;

        private Inventory inventory = new Inventory();


        public Character(string name)
        {
            _name = name;
        }

        public string Name()
        {
            return _name;
        }
        public void Print()
        {
            Console.WriteLine(_name);
            Console.WriteLine("level " + _level);
            Console.WriteLine("experience " + _xp);
            Console.WriteLine("Health: " + _health);
            Console.WriteLine("Dexterity: " + _dexterity);
            Console.WriteLine("Wisdom: " + _wisdom);
            Console.WriteLine("strength: " + _strength);
            Console.WriteLine("Combat Damage: " + (_strength + inventory.GetItemDamage()));


        }
        public void OpenInventory()
        {
            inventory.Menu();
        }
        public int Experience 
        {
            get
            {
                return _xp;
                
            }
            set
            {
                _xp = value;
                Console.WriteLine(_name + " gained experience and now has " + _xp);
                if (_level <= _requiredXP.Length)
                    {
                    if (_xp >= _requiredXP[_level - 1]) //subtracts 1 to make sure taht when you level up it uses the currrect slot
                    {
                        _level++;
                        Console.WriteLine(_name + "s level increased to " + _level + "!");
                    }
                }
            }
        }
    }
}
