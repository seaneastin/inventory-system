using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Inventory
    {
        int damage = 10;
        float gold = 0.00f;
        string weaponequipped = "0"; //tells game what weapon is equipped          0 = unarmed
        int maxweight = 100;
        int weaponweight = 0;
        int armorweight = 0;
        string equippedarmor = "0"; //tells game whatarmor is equipped
        string itemchoose = "0"; //items
        //0 means no armor equipped
        bool overweight = false; //tells the game if player is over the weight limit
 
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
            /*      if (equippedweapon == true)
                  {
                      Console.WriteLine("you already have a weapon equipped");
                      return;
                  }  may delete as you can only equip one weapon
                  /*weapons to be added
                   * 0. unarmed
                   * 1. dagger
                   * 2. sword
                   * 3. warhammer
                   * 4. greatsword*/
            Console.WriteLine("choose a weapon");
            Console.WriteLine("0: unarmed");
            Console.WriteLine("1: Dagger");
            Console.WriteLine("2: sword");
            Console.WriteLine("3: warhammer");
            Console.WriteLine("4: greatsword");
            Console.WriteLine("5: go back");
            weaponequipped = Console.ReadLine();
            if (weaponequipped == "1")
            {
                overweight = true;
                Console.WriteLine(" you equipped a dagger");
                damage = 20;
                Console.WriteLine("Damage: " + damage);
            }
            else if (weaponequipped == "2")
            {
                Console.WriteLine(" you equipped a sword");
                damage = 20;
                Console.WriteLine("Damage: " + damage);
            }
            else if (weaponequipped == "3")
            {
                Console.WriteLine(" you equipped a warhammer");
                damage = 20;
                Console.WriteLine("Damage: " + damage);
            }
            else if (weaponequipped == "4")
            {
                Console.WriteLine(" you equipped a GreatSword");
                damage = 20;
                Console.WriteLine("Damage: " + damage);
            }
            else if (weaponequipped == "0")
            {
                unequipWeapon(); //reuses old code from unequip weapon option
            }





        }

        public void unequipWeapon() //this is used for weapon 0 unarmed
        {
            Console.WriteLine("you are now unarmed");
            damage = 10;
            Console.WriteLine("Damage: " + damage);
        }

        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " Gold!");
            gold += amount;
            goldmincheck();
            Console.WriteLine("Gold: " + gold);
        }

        public void subtractGold(float amount)
        {
            Console.WriteLine("lost " + amount + " Gold!");
            gold -= amount;
            goldmincheck();
            Console.WriteLine("Gold: " + gold);
        }
        public void goldmincheck()
        {
            if (gold <= 0)
            {
                gold = 0;
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
            if (equippedarmor == "0")
            {
                armoruneqip();
            }
            if (equippedarmor == "1")
            {

            }
            if (equippedarmor == "2")
            {

            }
            if (equippedarmor == "3")
            {

            }

        }
        public void shopmenu()
        {
            Console.WriteLine("What do you want to buy");
            Console.WriteLine("0: potions");
            Console.WriteLine("1: go back");
            itemchoose = Console.ReadLine();
            if (itemchoose == "0")
            {
                buy("potions", 10);
            }
        }
        public void armoruneqip()
        {
            Console.WriteLine("unequiping armor");
            armorweight = 0;
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
                if (gold >= cost)
                {
                    gold = gold - cost;
                    Console.WriteLine("You now have " + gold + " gold");
                } 
                else if (gold < cost)
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
