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
            //*inventory inventory = new inventory(); //not sure what this does will ask the teacher
            //* inventory.Menu(); //opens a menu i think

            Character player = new Character("Sean");
            player.Print();
            Console.WriteLine(player.Name());
            Console.ReadLine();
            Character dylan = new Character("dylan");
            dylan.Print();

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
