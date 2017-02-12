using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniOS.UniAdd.Games
{
    class rocketdodge
    {
        string[] rows = new string[] { " ^  ", "    ", "    ", "    ", "    "};
        string pos1 = " ^  ";
        string pos2 = "  ^ ";
        string ast1 = "##  ";
        string ast2 = "  ##";
        int count_time = 0;
        int time_to_wait = 5;
        double time_interval = 0.2;
        int pos = 1;
        int score = 0;

        void newasteroid()
        {
            if(count_time < time_to_wait)
            {
                count_time++;
            }
            else
            {
                Random rnd = new Random();
                int astpos = rnd.Next(2);
                if(astpos == 0)
                {
                    rows[5] = ast1;
                }
                else
                {
                    rows[5] = ast2;
                }
                count_time = 0;
            }
        }

        static void playerdead(int score)
        {
            Console.Clear();
            Console.WriteLine("You have died, your score was: " + score)
        }

        public static void update()
        {
            
        }

        static void exit()
        {

        }
    }
}
