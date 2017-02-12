using System;

namespace UniOS
{
    class Help
    {
        public static void HelpInfo(object version)
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                            UniOS Help Information                           *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                    UniOS Version: UniOS Pre-Alpha " + version +"                  *");
            Console.WriteLine("* Commands:                                                                   *");
            Console.WriteLine("*     cls            | Clears the console                                     *");
            Console.WriteLine("*     echo/n         | Writes whats after the slash to the screen             *");
            Console.WriteLine("*     run/prog       | Runs said program                                      *");
            Console.WriteLine("*     cd/dir         | Changes to said directory                              *");
            Console.WriteLine("*     md/dir         | Makes said directory folder                            *");
            Console.WriteLine("*     dir            | Shows directorys and folders in current address        *");
            Console.WriteLine("*     tdit           | Launches text editing program                          *");
            Console.WriteLine("*     tdit.help      | Shows extra tdit info and help                         *");
            Console.WriteLine("*     help           | Displays this help message                             *");
            Console.WriteLine("*     reboot         | Restarts the system                                    *");
            Console.WriteLine("*     add/n1@n2      | Adds n1 and n2 together                                *");
            Console.WriteLine("*     subtract/n1#n2 | Subtracts n1 from n2                                   *");
            Console.WriteLine("*     multiply/n1#n2 | Multiplys n1 and n2                                    *");
            Console.WriteLine("*     divide/n1#n2   | Divides n1 from n2                                     *");
            Console.WriteLine("*     power/n1#n2    | Raises n1 to the power of n2                           *");
            Console.WriteLine("*     gcd/n1#n2      | Gets greatest common divisor of n1 and n2              *");
            Console.WriteLine("*     lcm/n1#n2      | Gets least common multiplyer of n1 and n2              *");
            Console.WriteLine("*     lock           | Locks the system, unlocked with username and password  *");
            Console.WriteLine("*     package/id     | Launches a package based on id given                   *");
            Console.WriteLine("*******************************************************************************");

        }

        public static void TditHelp()
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                             TDit Help Information                           *");
            Console.WriteLine("*                              TDit Version 1.0.0                             *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("* Commands:                                                                   *");
            Console.WriteLine("*     F12    | Exits TDit                                                     *");
            Console.WriteLine("*     F11    | Clears all text written on document                            *");
            Console.WriteLine("*******************************************************************************");
        }
    }
}
