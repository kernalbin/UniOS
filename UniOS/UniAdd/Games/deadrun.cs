using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniOS.UniAdd.Games
{
    class deadrun
    {
        

        public static void deadrungame()
        {
            // Ints:
            int correct = 0;
            int Player_One_Handed = 0;
            int Player_Two_Handed = 0;
            int Player_Ranged_Weapon = 0;
            int Player_Magic = 0;
            int array_count = 0;

            //Strings:
            string gender;
            string race;
            string pclass;
            string[] Inventory = new string[28];
            string input;

/// ______               _  ______
/// |  _  \             | | | ___ \           
/// | | | |___  __ _  __| | | |_/ /   _ _ __
/// | | | / _ \/ _` |/ _` | |    / | | | '_ \ 
/// | |/ /  __/ (_| | (_| | | |\ \ |_| | | | |
/// |___/ \___|\__,_|\__,_| \_| \_\__,_|_| |_|

            Console.Clear();
            Console.WriteLine(@"*******************************************************************************");
            Console.WriteLine(@"                   ______               _  ______                              ");
            Console.WriteLine(@"                   |  _  \             | | | ___ \                             ");
            Console.WriteLine(@"                   | | | |___  __ _  __| | | |_/ /   _ _ __                    ");
            Console.WriteLine(@"                   | | | / _ \/ _` |/ _` | |    / | | | '_ \                   ");
            Console.WriteLine(@"                   | |/ /  __/ (_| | (_| | | |\ \ |_| | | | |                  ");
            Console.WriteLine(@"                   |___/ \___|\__,_|\__,_| \_| \_\__,_|_| |_|                  ");
            Console.WriteLine(@"                                                                               ");
            Console.WriteLine(@"*******************************************************************************");
            Console.ReadKey();
            Console.Clear();


            // Get Gender
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter gender");
                Console.WriteLine("Male/Female");
                Console.Write("Gender: ");
                gender = Console.ReadLine().ToUpper();

                if (gender == "MALE")
                {
                    correct = 1;
                }
                if (gender == "FEMALE")
                {
                    correct = 1;
                } else { }
            } while (correct == 0);
            correct = 0;

            /// Get Race
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter race");
                Console.WriteLine("Human");
                Console.WriteLine("Dwarf");
                Console.WriteLine("Elf");
                Console.WriteLine("Ork");
                Console.Write("Race: ");
                race = Console.ReadLine().ToUpper();
                if (race == "HUMAN" || race == "DWARF" || race == "ELF" || race == "ORK")
                {
                    correct = 1;
                }
            } while (correct == 0);
            correct = 0;

            /// Get Class
            do
            {
                Console.Clear();
                Console.WriteLine("Please enter class");
                Console.WriteLine("Warrior");
                Console.WriteLine("Hunter");
                Console.WriteLine("Mage");
                Console.WriteLine("Theif");
                Console.Write("Class: ");
                pclass = Console.ReadLine().ToUpper();
                if (pclass == "WARRIOR" || pclass == "HUNTER" || pclass == "MAGE" || pclass == "THEIF")
                {
                    correct = 1;
                }
            } while (correct == 0);
            correct = 0;

            // Race Bonuses
            if(race == "HUMAN")
            {
                Player_One_Handed++;
                Player_Two_Handed++;
                Player_Ranged_Weapon++;
                Player_Magic++;
            }
            if (race == "DWARF")
            {
                Player_One_Handed++;
                Player_Two_Handed += 2;
                Player_Ranged_Weapon++;
            }
            if (race == "ELF")
            {
                Player_One_Handed++;
                Player_Ranged_Weapon += 2;
                Player_Magic++;
            }
            if (race == "ORK")
            {
                Player_One_Handed += 2;
                Player_Two_Handed += 2;
            }

            // Class Bonuses
            if (pclass == "WARRIOR")
            {
                Player_One_Handed += 2;
                Player_Two_Handed += 2;
            }
            if (pclass == "HUNTER")
            {
                Player_One_Handed++;
                Player_Two_Handed++;
                Player_Ranged_Weapon += 2;
            }
            if (pclass == "MAGE")
            {
                Player_One_Handed++;
                Player_Ranged_Weapon++;
                Player_Magic += 2;
            }
            if (pclass == "THEIF")
            {
                Player_One_Handed += 2;
                Player_Ranged_Weapon++;
                Player_Magic++;
            }

            // Inventory System
            Inventory[1] = "1"; Inventory[2] = "2"; Inventory[3] = "snails";

            Console.Clear();
            Console.Write("Write Inventory:");
            input = Console.ReadLine().ToUpper();
            
            if(input == "INVENTORY")
            {
                Console.WriteLine("Inventory:");
                for(array_count = 0; array_count < 20; array_count++)
                {
                    int write_pos = 2;
                    write_pos += array_count;
                    Console.SetCursorPosition (0, write_pos);
                    Console.WriteLine(Inventory[array_count]);
                }
            } else { }



        }
    }
}
