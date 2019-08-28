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

            Monster testmonster = new Monster("testmonster1", 100, 10); //for testing
            Monster testmonster2 = new Monster("testmonster2", 100, 10); //for testing
            Monster testmonster3 = new Monster("testmonster3", 100, 10); //for testing
            Monster testmonster4 = new Monster("testmonster4", 100, 10); //for testing
            Monster[] goodteam = { testmonster, testmonster2 };
            Monster[] badteam = { };
            Encounter encounter = new Encounter(goodteam, badteam);
            testmonster.Print();
            testmonster2.Print();
            encounter.print();
            testmonster.fight(testmonster2);
            testmonster.Print();
            testmonster2.Print();

            testmonster2.fight(testmonster);

            Console.ReadLine();

            return; //dont forget to delete this line everything above is for testing
            /*  Inventory inventory = new Inventory(); //not sure what this does will ask the teacher
             inventory.Menu(); //opens a menu i think */
            string name = "";
            string choice = "";
            Console.WriteLine("Enter name of party member 1:");
            name = Console.ReadLine();


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

            Console.WriteLine(player.Name());
            Console.ReadLine();
            Wizard dylan = new Wizard("dylan");
            Character Sarah = new Character("Sarah");
            dylan.Print();
            choice = "";
            while (choice != "0")
            {
                //displays menu
                Console.WriteLine("\nWhoose inventory:");
                Console.WriteLine("1: " + player.Name());
                Console.WriteLine("2: " + dylan.Name());
                Console.WriteLine("3: " + Sarah.Name());
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    player.OpenInventory();
                }
                if (choice == "2")
                {
                    dylan.OpenInventory();
                }
                if (choice == "3")
                {
                    Sarah.OpenInventory();
                }


            }


            Console.ReadKey();
        }
    }
}
