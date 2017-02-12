using System;
using System.IO;

namespace UniOS
{
    class SHAFS
    {
        public static void writeFile(string Adr, string[] data) // Write text to a file
        {
            File.WriteAllLines(Adr, data);
        }

        public static string[] readFile(string Adr) // Read text from a file
        {
            string[] read;
            read = File.ReadAllLines(Adr);
            return read;
        }

        public static void createDir(string Adr) //Create a folder
        {
            Directory.CreateDirectory(Adr);
        }

        public static string[] readFiles(string Adr) // Get Files From Address
        {
            string[] Files = new string[256];
            if (Directory.GetFiles(Adr).Length > 0)
                Files = Directory.GetFiles(Adr);
            else
                Files[0] = "No files found.";
            return Files;
        }

        public static string[] readDirectories(string Adr) // Get Directories From Address
        {
            var Dirs = Directory.GetDirectories(Adr);
            return Dirs;
        }

        public static bool directoryExists(string Adr) // Test to see if a given adress actually exists.
        {
            Console.WriteLine("Not Implemented!");
            return false;
        }
    }
}
