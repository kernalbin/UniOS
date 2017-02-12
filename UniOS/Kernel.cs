using System;
using Sys = Cosmos.System;

namespace UniOS
{
    public class Kernel : Sys.Kernel
    {
        string osversion = "20161026"; // OS Version!!!
        string user = "";
        string pass = "";
        string current_path = @"0:\";
        public bool file_system_init = false;

        // Remember = Console is 80wx25h

        protected override void BeforeRun()
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                 UniOS Setup                                 *");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*                                                                             *");
            Console.WriteLine("*   Enable File System? (Y/N):                                                  *");
            Console.WriteLine("*      **Warning: Filesystem unfinished, may cause crashing and damage**      *");
            Console.WriteLine("*******************************************************************************");
            string file_system_string = Console.ReadLine();
            if(file_system_string == "Y" || file_system_string == "y")
            {
                file_system_init = true;
                Console.Clear();
                Console.WriteLine("File System Will Be Initialized!");
                var fs = new Sys.FileSystem.CosmosVFS();
                Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("File System Will NOT Be Initialized!");
                Console.ReadKey();
            }

            Console.Clear();
            Console.WriteLine("       :::    :::      ::::    :::     :::::::::::     ::::::::      ::::::::");
            Console.WriteLine("      :+:    :+:      :+:+:   :+:         :+:        :+:    :+:    :+:    :+:");
            Console.WriteLine("     +:+    +:+      :+:+:+  +:+         +:+        +:+    +:+    +:+        ");
            Console.WriteLine("    +#+    +:+      +#+ +:+ +#+         +#+        +#+    +:+    +#++:++#++  ");
            Console.WriteLine("   +#+    +#+      +#+  +#+#+#         +#+        +#+    +#+           +#+   ");
            Console.WriteLine("  #+#    #+#      #+#   #+#+#         #+#        #+#    #+#    #+#    #+#    ");
            Console.WriteLine("  ########       ###    ####     ###########     ########      ########      ");
            Console.WriteLine("                                                                             ");
            Console.WriteLine("                               Version: " + osversion);
            Console.WriteLine("                           UniOS Booted Successfully");
            Console.WriteLine("                                    Made by:");
            Console.WriteLine("                                Spencer Huntsman");
        }

        protected override void Run()
        {
            if(user != "")
            {
                Console.Write(current_path + "~" + user + "~|>");
            } else
            {
                Console.Write(current_path + "~~|>");
            }
            
            var input = Console.ReadLine();
            var co = input;
            var vars = "";
            if (input.ToLower().IndexOf('/') != -1)
            {
                string[] parts = input.Split('/');
                co = parts[0];
                vars = parts[1];
            }
            
            switch (co)
            {
                case "lock": // Temporarily locks the kernal
                    Console.Write("Set Passcode: ");
                    pass = Console.ReadLine();
                    lockkernal.lockpass(pass);
                    break;

                case "cls": //Clears the screen
                    Console.Clear();
                    break;

                case "echo": // Returns the given value
                    Console.WriteLine(vars);
                    break;

                case "cd": // Moves to given directory
                    if (file_system_init)
                    {
                        current_path = vars;
                    }
                    else
                    {
                        Console.WriteLine("File System Not Enabled!");
                    }
                    break;

                case "md": // Creates a directory
                    if (file_system_init)
                    {
                        SHAFS.createDir(current_path + vars);
                    }
                    else
                    {
                        Console.WriteLine("File System Not Enabled!");
                    }
                    break;

                case "dir": // Displays current location
                    if (file_system_init)
                    {
                        string[] back = SHAFS.readFiles(current_path);
                        string[] front = SHAFS.readDirectories(current_path);
                        string[] combined = new string[front.Length + back.Length];
                        Array.Copy(front, combined, front.Length);
                        Array.Copy(back, 0, combined, front.Length, back.Length);
                        foreach (var item in combined)
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                    else
                    {
                        Console.WriteLine("File System Not Enabled!");
                    }
                    break;

                case "tdit": // Launches text editor
                    if (file_system_init)
                    {
                        //Launch Text Editor
                        Console.Clear();
                        tdit.init();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("File System Not Enabled!");
                    }
                    break;

                case "help": // Displays help
                    Console.WriteLine(" ");
                    Help.HelpInfo(osversion);
                    Console.WriteLine(" ");
                    break;

                case "tdit.help": // Displays tdit help
                    Console.WriteLine(" ");
                    Help.TditHelp();
                    Console.WriteLine(" ");
                    break;

                case "reboot": // Restarts the system
                    Sys.Power.Reboot();
                    break;

                ///case "halt":
                ///    Sys.Power.Shutdown();
                ///    break;
                ///                                  Currently does not work!!

                case "add": // Adds given numbers
                    string[] inputvarsa = vars.Split('#');
                    Console.WriteLine(Math.Add(inputvarsa[0], inputvarsa[1]));
                    break;

                case "subtract": // Subtracts given numbers
                    string[] inputvarsb = vars.Split('#');
                    Console.WriteLine(Math.Subtract(inputvarsb[0], inputvarsb[1]));
                    break;

                case "multiply": // Multiplys given numbers
                    string[] inputvarsc = vars.Split('#');
                    Console.WriteLine(Math.Multiply(inputvarsc[0], inputvarsc[1]));
                    break;
                    
                case "divide": // Divides given numbers
                    string[] inputvarsd = vars.Split('#');
                    Console.WriteLine(Math.Divide(inputvarsd[0], inputvarsd[1]));
                    break;

                case "power": // Raises given number to other given number
                    string[] inputvarse = vars.Split('#');
                    Console.WriteLine(Math.ToPower(inputvarse[0], inputvarse[1]));
                    break;

                case "gcd": // Gives gcd conversion of given numbers
                    string[] inputvarsf = vars.Split('#');
                    Console.WriteLine(Math.GcdCon(inputvarsf[0], inputvarsf[1]));
                    break;

                case "lcm": // Gives lcm conversion of given numbers
                    string[] inputvarsg = vars.Split('#');
                    Console.WriteLine(Math.LcmCon(inputvarsg[0], inputvarsg[1]));
                    break;

                case "package": // Launches optional packages
                    string packageid = vars;
                    CosmosKernel2.Runner.packages(packageid);
                    break;

                default:
                    Console.WriteLine("Command does not exist! Type help for help!");
                    break;
            }
        }
    }
}