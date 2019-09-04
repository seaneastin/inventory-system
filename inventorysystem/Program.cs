using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventorysystem
{
    class Program
    {
        public static Random random = new Random();

        static void Main(string[] args)
        {
            //0: Courtyard
            //1: castle Gate
            //2: graveyard
            //3: Village
            //                                           N, S, E, W
            /*    Scene courtyard = new Scene("Courtyard",     1, 3, -1, 2 , "just a Courtyard exits are north");
                Scene castleGate = new Scene("Castle Gate", -1, 0, -1, -1, "there is a massive gate at the entrance to the /ncastle. It appears to be locked. there is an exit tothe south.");
                Scene graveyard = new Scene("Graveyard",    -1, -1, 0, -1, "The graveyard is p. spooky. Nonetheless, you pay respects. There is an exit to the east.");
                Scene village = new Scene("Village",         0, -1, -1, -1, "This is the village. THere are a bunch of building, I guess. There is an exit to the north.");
                Scene[] scenes = { courtyard, castleGate, graveyard, village };
                Map map = new Map(0, scenes);  
                /*
                map.PrintCurrentScene();
                map.CurrentSceneID = 1;
                map.PrintCurrentScene();
                map.CurrentSceneID = 2;
                map.PrintCurrentScene();
                map.CurrentSceneID = 3;
                map.PrintCurrentScene();
                map.CurrentSceneID = 4;
                map.PrintCurrentScene();
                Console.ReadKey();

                map.Menu();
                return; */









            Console.WriteLine("test");
            Monster testmonster = new Monster("goodmonster1", 400, 10); //for testing
            Monster testmonster2 = new Monster("goodmonster2", 400, 1); //for testing
            Monster testmonster3 = new Monster("badmonster3", 400, 50); //for testing
            Monster testmonster4 = new Monster("badmonster4", 400, 90); //for testing
            Character testguy = new Knight("Sean");
            Creature[] goodteam = { testmonster, testmonster2, testguy };
            Creature[] badteam = { testmonster3, testmonster4};
            Encounter encounter = new Encounter(goodteam, badteam);
            encounter.print();
            encounter.Start();
            encounter.BeginRound();
         

            Console.ReadLine();

            return; //dont forget to delete this line everything above is for testing  commmented this out for going back to inventory */
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

            Console.WriteLine(player.getName());
            Console.ReadLine();
            Wizard dylan = new Wizard("dylan");
            Character Sarah = new Character("Sarah");
            dylan.Print();
            choice = "";
            while (choice != "0")
            {
                //displays menu
                Console.WriteLine("\nWhoose inventory:");
                Console.WriteLine("1: " + player.getName());
                Console.WriteLine("2: " + dylan.getName());
                Console.WriteLine("3: " + Sarah.getName());
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
