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
                Console.WriteLine("2: Unequip Weapon");
                Console.WriteLine("3: add gold");
                Console.WriteLine("4: subtract gold");



                //gets input from user
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    equipWeapon();
                }
                else if (choice == "2")
                {
                    unequipWeapon();
                }
                else if (choice == "3")
                {
                    Console.Write("How much gold? ");

                    float Goldadd = Convert.ToSingle(Console.ReadLine());
                    AddGold(Goldadd);
                }
                else if (choice == "4")
                {
                    Console.Write("How much gold? ");
                    float Goldsubtract = Convert.ToSingle(Console.ReadLine());
                    subtractGold(Goldsubtract);
                }
                else if (choice == "6")
                {

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

            if (equippedweapon == true)
            {
                Console.WriteLine("you already have a weapon equipped");
                return;
            }
            Console.WriteLine("choose a weapon");
            Console.WriteLine("0: unarmed");
            Console.WriteLine("1: Dagger");
            Console.WriteLine("2: sword");
            Console.WriteLine("3: warhammer");
            Console.WriteLine("4: greatsword");
            Console.WriteLine("5: go back");
            weaponequipped = Console.ReadLine();
            if (weaponequipped == "0")
            {

            }



          /*      Console.WriteLine("Equipped a weapon!");
            damage = 25;
            Console.WriteLine("Damage: " + damage);
            equippedweapon = true; */
        }

        public void unequipWeapon()
        {
            if (equippedweapon == false)
            {
                Console.WriteLine("you dont have a weapon equipped");
                return;
            }
            Console.WriteLine("unequipped a weapon!");
            damage = 10;
            Console.WriteLine("Damage: " + damage);
        }

        public void AddGold(float amount)
        {
            Console.WriteLine("Got " + amount + " Gold!");
            gold += amount;
            Console.WriteLine("Gold: " + gold);
        }

        public void subtractGold(float amount)
        {
            Console.WriteLine("lost " + amount + " Gold!");
            gold -= amount;
            if (gold <= 0)
            {
                gold = 0;
            }
            Console.WriteLine("Gold: " + gold);
        }

    }
}
