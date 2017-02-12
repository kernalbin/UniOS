using System;

namespace UniOS
{
    class lockkernal
    {
        public static void lockpass(string passcode)
        {
            bool unlocked = false;
            while (!unlocked)
            {
                Console.Clear();
                Console.WriteLine("System Locked, Type Password to unlock");
                Console.Write("Password: ");
                string enterpass = Console.ReadLine();
                if (enterpass == passcode)
                {
                    unlocked = true;
                    Console.Clear();
                }
            }
        }
    }
}
