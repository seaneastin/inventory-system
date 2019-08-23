using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class inventory
    {
        int damage = 10;
        float gold = 0.00f;
        bool equippedweapon = false; //tells game if weapon is equipped may be removed
        string weaponequipped = "0"; //tells game what weapon is equipped
        int maxweight = 100;
        int weaponweight = 0;
        int armorweight = 0;
        bool armorequipped = false; //tells the game if armor is equiipped
        string equippedarmor = "0"; //tells game whatarmor is equipped
        bool overweight = false; //tells the game if player is over the weight limit
        //0 = unarmed
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
                equippedweapon = true; //will not be used later will try to check in other ways
            }
            else if (weaponequipped == "2")
            {
                Console.WriteLine(" you equipped a sword");
                damage = 20;
                Console.WriteLine("Damage: " + damage);
                equippedweapon = true; //will not be used later will try to check in other ways
            }
            else if (weaponequipped == "3")
            {
                Console.WriteLine(" you equipped a warhammer");
                damage = 20;
                Console.WriteLine("Damage: " + damage);
                equippedweapon = true; //will not be used later will try to check in other ways
            }
            else if (weaponequipped == "4")
            {
                Console.WriteLine(" you equipped a GreatSword");
                damage = 20;
                Console.WriteLine("Damage: " + damage);
                equippedweapon = true; //will not be used later will try to check in other ways
            }
            else if (weaponequipped == "0")
            {
                unequipWeapon(); //reuses old code from unequip weapon option
            }




            /*      Console.WriteLine("Equipped a weapon!");
              damage = 25;
              Console.WriteLine("Damage: " + damage);
              equippedweapon = true; */
        }

        public void unequipWeapon() //this is used for weapon 0 unarmed
        {
            /*  if (equippedweapon == false)
              {
                  Console.WriteLine("you dont have a weapon equipped");
                  return;
              } */
            Console.WriteLine("you are now unarmed");
            damage = 10;
            Console.WriteLine("Damage: " + damage);
            equippedweapon = false;
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
            Console.WriteLine("test");
        }
        public void shopmenu()
        {
            Console.WriteLine("WIP");
        }
       /* public void weightcheck()
        {
            if (weight >= maxweight)
            {
                Console.WriteLine("you are over the max weight");
                return;
            } 
        } */


    }
}
