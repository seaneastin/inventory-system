using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Inventory
    {
        private int _itemdamage = 10;
        private float _gold = 0.00f;
        private string _weaponequipped = "0"; //tells game what weapon is equipped          0 = unarmed
        private int _maxweight = 100;
        private int _weaponweight = 0;
        private int _armorweight = 0;
        private string _equippedarmor = "0"; //tells game whatarmor is equipped
        private string _itemchoose = "0"; //items
        private int _itemDefense = 20;
        /* if (_weaponequipped == "1")
 {
     weaponequip("Dagger", 20);
 }
 else if (_weaponequipped == "2")
 {
     weaponequip("Sword", 40);
 }
 else if (_weaponequipped == "3")
 {
     weaponequip("Warhammer", 50);
 }
 else if (_weaponequipped == "4")
 {
     weaponequip("GreatSword", 60);
 }
 else if (_weaponequipped == "0")
 {
     unequipWeapon(); //reuses old code from unequip weapon option
 } */
        private Attackitem unarmed = new Attackitem("no weapon", 0, 0);
        private Attackitem mastersword = new Attackitem("Master Sword", 999, 0); 
        private Attackitem dagger = new Attackitem("Dagger", 20, 3);
        private Attackitem sword = new Attackitem("Sword", 40, 10);
        private Attackitem warhammer = new Attackitem("Warhammer", 50, 30);
        private Attackitem greatsword = new Attackitem("GreatSword", 60, 50);

        private Attackitem[] weapons;
        public Inventory()
        {
            Attackitem[] weaponBag = { unarmed , mastersword, dagger, sword, warhammer, greatsword};
            weapons = weaponBag;
        }
        //0 means no armor equipped
        bool overweight = false; //tells the game if player is over the weight limit

        //returns the damage our weapon deals
        public int GetItemDamage()
        {
            return _itemdamage;
        }
        //returns the defense our armor grants
        public int GetItemDefense()
        {
            return _itemDefense;
        }
 
        public void Menu()
        {
            string choice = "";

            while (choice != "0")
            {
                //displays menu
                Console.WriteLine("\nMenu");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Equip Weapon");
                Console.WriteLine("2: add gold");
                Console.WriteLine("3: subtract gold");
                Console.WriteLine("4: equip Armor");
                Console.WriteLine("5: shopmenu");
                //Console.WriteLine("6:Cheats"); possible feature





                //gets input from user
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    equipWeapon();
                }
                else if (choice == "2")
                {
                    Console.Write("How much gold? ");

                    float Goldadd = Convert.ToSingle(Console.ReadLine());
                    AddGold(Goldadd);
                }
                else if (choice == "3")
                {
                    Console.Write("How much gold? ");
                    float Goldsubtract = Convert.ToSingle(Console.ReadLine());
                    subtractGold(Goldsubtract);
                }
                else if (choice == "4")
                {
                    Armormenu();
                }
                else if (choice == "5")
                {
                    shopmenu();
                }
            }
        }

        public void equipWeapon()
        {
                   /*weapons to be added
                   * 0. unarmed
                   * 1. dagger
                   * 2. sword
                   * 3. warhammer
                   * 4. greatsword*/
             Console.WriteLine("choose a weapon");
            Console.WriteLine("0: unarmed");
            Console.WriteLine("1: dagger");
            Console.WriteLine("2: sword");
            Console.WriteLine("3: warhammer");
            Console.WriteLine("4: greatsword");
            Console.WriteLine("5: MasterSword");
            Console.WriteLine("5: go back"); 
            _weaponequipped = Console.ReadLine();
            Console.WriteLine("this feature is being rewritten");
             if (_weaponequipped == "1")
             {
                 weaponequip("Dagger", 20);
             }
             else if (_weaponequipped == "2")
             {
                 weaponequip("Sword", 40);
             }
             else if (_weaponequipped == "3")
             {
                 weaponequip("Warhammer", 50);
             }
             else if (_weaponequipped == "4")
             {
                 weaponequip("GreatSword", 60);
             }
             else if (_weaponequipped == "0")
             {
                 unequipWeapon(); //reuses old code from unequip weapon option
             } 
             else if (_weaponequipped == "5")
            {

            }



        }

        public void weaponequip(string weaponname, int damage)
        {
            if (overweight == false)
            {
                Console.WriteLine(" you equipped a " + weaponname);
                _itemdamage = damage;
                Console.WriteLine("Damage: " + _itemdamage);
            }
            if (overweight == true)
            {
                Console.WriteLine("you have gone over your max weight limit");
            }
        }


        public void unequipWeapon() //this is used for weapon 0 unarmed
        {
            Console.WriteLine("you are now unarmed");
            _itemdamage = 10;
            Console.WriteLine("Damage: " + _itemdamage);
        }

        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " Gold!");
            _gold += amount;
            goldmincheck();
            Console.WriteLine("Gold: " + _gold);
        }

        public void subtractGold(float amount)
        {
            Console.WriteLine("lost " + amount + " Gold!");
            _gold -= amount;
            goldmincheck();
            Console.WriteLine("Gold: " + _gold);
        }
        public void goldmincheck()
        {
            if (_gold <= 0)
            {
                _gold = 0;
            }
        }
        public void Armormenu()
        {
            /*armor values
            0 = no armor
            1 = armor
            2 = heavy armor
            */
            Console.WriteLine("choosearmor");
            Console.WriteLine("0: no armor"); // removes armor
            Console.WriteLine("1: armor"); //
            Console.WriteLine("2: heavy armor"); //
            Console.WriteLine("3: go back");
            Console.ReadLine();
            Console.WriteLine("this feature is being rewritten");
            /*if (_equippedarmor == "0")
            {
                armoruneqip();
            }
            if (_equippedarmor == "1")
            {

            }
            if (_equippedarmor == "2")
            {

            }
            if (_equippedarmor == "3")
            {

            }  */

        }
        public void shopmenu()
        {
            Console.WriteLine("What do you want to buy");
            Console.WriteLine("0: potions");
            Console.WriteLine("1: go back");
            _itemchoose = Console.ReadLine();
            if (_itemchoose == "0")
            {
                buy("potions", 10);
            }
        }
        public void armoruneqip()
        {
            Console.WriteLine("unequiping armor");
            _armorweight = 0;
        }
        /* public void weightcheck()
         {
             if (weight >= maxweight)
             {
                 Console.WriteLine("you are over the max weight");
                 return;
             } 
         } */
        public void buy(string itemname, int basecost)
        {
            int cost = 0;
            int amount = 0;
            string buy = "0";
            Console.WriteLine(itemname + " costs " + basecost + " gold " + "how much do you want");
            amount = Convert.ToInt32(Console.ReadLine());
            cost = amount * basecost;
            Console.WriteLine("do you want to buy " + amount + itemname + " for " + cost + "gold");
            Console.WriteLine("1. buy");
            Console.WriteLine("2. dont buy");
            buy = Console.ReadLine();
            if (buy == "1")
            {
                if (_gold >= cost)
                {
                    _gold = _gold - cost;
                    Console.WriteLine("You now have " + _gold + " gold");
                } 
                else if (_gold < cost)
                {
                    Console.WriteLine("you dont have enough gold");
                    return;
                }
      
            }
            else if (buy == "2")
            {

            }
            
        }


    }
}
