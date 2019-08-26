using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  Inventory inventory = new Inventory(); //not sure what this does will ask the teacher
             inventory.Menu(); //opens a menu i think */
            string name = "";
            string choice = "";
            Console.WriteLine("Enter name of party member 1:");
            string nane = Console.ReadLine();


            while (choice != "1" && choice != "2" )
            {
                //displays menu
                Console.WriteLine("\nChoose a job:");
                Console.WriteLine("1: Knight");
                Console.WriteLine("2: Wizard");
                choice = Console.ReadLine();

            }
            Character player;
            if (choice == "1")
            {
                player = new Knight(name);
            }
            else if (choice == "2")
            {
                player = new Wizard(name);
            }
            else
            {
                player = new Character(name);
            }

            player.Print();
            player.OpenInventory();
            Console.WriteLine(player.Name());
            Console.ReadLine();
            Wizard dylan = new Wizard("dylan");
            Character Sarah = new Character("Sarah");
            dylan.Print();

            while (choice != "1" && choice != "2")
            {
                //displays menu
                Console.WriteLine("\nWhoose inventory:");
                Console.WriteLine("1: " + player.Name());
                Console.WriteLine("2: " + player.Name());
                choice = Console.ReadLine();

            }

            player.Experience = 30;
            player.Experience = player.Experience + 50;
            player.Experience++;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience += 40;
            player.Experience++;
            player.Experience++;
            player.Experience++;
            player.Experience++;
            player.Experience++;
            player.Experience++;
            player.Experience++;
            player.Experience++;
            player.Experience++;
            player.Experience++;
            player.Experience++;
            player.Experience++;
            player.Experience++;
            player.Experience++;
            player.Experience++;
            dylan.Experience += 1;
            dylan.Experience++;
            dylan.Experience++;
            dylan.Experience++;
            dylan.Experience++;
            dylan.Experience++;
            dylan.Experience++;
            dylan.Experience++;
            dylan.Experience++;
            dylan.Experience++;
            dylan.Experience++;
            dylan.Experience += 100;
            dylan.Experience++;
            dylan.Experience++;
            dylan.Experience++;
            dylan.Experience++;
            dylan.Experience++;
            dylan.Experience++;
            dylan.Experience++;
            dylan.Experience++;
            int[] testArray = new int[4];
            testArray[0] = 1;
            testArray[1] = 3;
            testArray[2] = 5;
            testArray[3] = 7;

            int[] testArray2 = { 2, 4, 6, 8 };
            string[] stringarray = new string[3];
            Character[] party = { player, dylan, new Character("Like") }; //ask teacher about arrays


            Console.ReadKey();
        }
    }
}
