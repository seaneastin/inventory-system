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
            SpellBook spellbook = new SpellBook(2);
            string name = "";    //uncomment this later dont forget
            string choice = "";
            Console.WriteLine("Enter name of party member 1:");
            name = Console.ReadLine();


            while (choice != "1" && choice != "2")
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
            dylan.Print();  


            Monster testmonster = new Monster("goodmonster1", 30, 10); //for testing
            Console.WriteLine("Health: " + testmonster.Health);



            spellbook.Page1(testmonster);

            spellbook.Page2(testmonster);
     

            //create a metod and assign it to Page1
            void Flame(Creature target)
            {
                target.Health -= 25;
                Console.WriteLine("Flame deals 25 damage to " + target.getName() + "!");
            }

            void Heal(Creature target)
            {
                target.Health += 100;
                Console.WriteLine(target.getName() + " has healed 100 hp and now has " + target.Health);
            }

            spellbook.Page1 = Flame;
            Console.WriteLine("Health: " + testmonster.Health);
            spellbook.Page2 = Heal;
            spellbook.Page1 += Heal;
            Console.WriteLine("Health: " + testmonster.Health);

            spellbook.Page1(testmonster);
            Console.WriteLine("Health: " + testmonster.Health);
            spellbook.Page2(testmonster);
            Console.WriteLine("Health: " + testmonster.Health);

            

            spellbook.book[0] = Flame;
            spellbook.book[1] = Heal;
            spellbook.book[0](testmonster);
             Console.ReadKey();
            return; //for testing purposes

            Monster testmonster2 = new Monster("goodmonster2", 4, 1); //for testing
            Monster testmonster3 = new Monster("badmonster3", 4, 50); //for testing
            Monster testmonster4 = new Monster("badmonster4", 4, 90); //for testing
            Character testguy = new Knight("dummy");
            Character testguy2 = new Wizard("awpofpawefpijewaipjf");
            Character testguy3 = new Wizard("qwerty");
            Creature[] empty = { };
            Creature[] goodteam = { player, dylan, testguy, testguy2, testguy3};
            Creature[] badteam = { testmonster3, testmonster4 };
            //0: Courtyard
            //1: castle Gate
            //2: graveyard
            //3: Village
            //                                           N, S, E, W
               Scene courtyard = new Scene("Courtyard",     1, 3, -1, 2 , "just a Courtyard exits are north", empty);
                Scene castleGate = new Scene("Castle Gate", -1, 0, -1, -1, "there is a massive gate at the entrance to the /ncastle. It appears to be locked. there is an exit tothe south.", empty);
                Scene graveyard = new Scene("Graveyard",    -1, -1, 0, -1, "The graveyard is p. spooky. Nonetheless, you pay respects. There is an exit to the east.", badteam);
                Scene village = new Scene("Village",         0, -1, -1, -1, "This is the village. THere are a bunch of building, I guess. There is an exit to the north.", empty);
                Scene[] scenes = { courtyard, castleGate, graveyard, village };
                Map map = new Map(0, scenes, goodteam);  
               
                map.Menu();








           

        /*will begin an encounter    Encounter encounter = new Encounter(goodteam, badteam);
            encounter.print();
            encounter.Start();
            encounter.BeginRound(); */
         

            Console.ReadLine();

 //dont forget to delete this line everything above is for testing  commmented this out for going back to inventory */
            /*  Inventory inventory = new Inventory(); //not sure what this does will ask the teacher
             inventory.Menu(); //opens a menu i think */

            
            


            Console.ReadKey();
        }
   /*does not work     public void inventorymenustart()
        {
            string choice = "";
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


            } */
        
    }
}
