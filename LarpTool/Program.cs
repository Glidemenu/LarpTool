using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;


namespace LarpTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "LarpTool";
            Banner();
            Menu();
            Console.ReadKey();


        }

        static void Banner()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"


         
 ██▓    ▄▄▄       ██▀███   ██▓███  ▄▄▄█████▓ ▒█████   ▒█████   ██▓    
▓██▒   ▒████▄    ▓██ ▒ ██▒▓██░  ██▒▓  ██▒ ▓▒▒██▒  ██▒▒██▒  ██▒▓██▒    
▒██░   ▒██  ▀█▄  ▓██ ░▄█ ▒▓██░ ██▓▒▒ ▓██░ ▒░▒██░  ██▒▒██░  ██▒▒██░    
▒██░   ░██▄▄▄▄██ ▒██▀▀█▄  ▒██▄█▓▒ ▒░ ▓██▓ ░ ▒██   ██░▒██   ██░▒██░    
░██████▒▓█   ▓██▒░██▓ ▒██▒▒██▒ ░  ░  ▒██▒ ░ ░ ████▓▒░░ ████▓▒░░██████▒
░ ▒░▓  ░▒▒   ▓▒█░░ ▒▓ ░▒▓░▒▓▒░ ░  ░  ▒ ░░   ░ ▒░▒░▒░ ░ ▒░▒░▒░ ░ ▒░▓  ░
░ ░ ▒  ░ ▒   ▒▒ ░  ░▒ ░ ▒░░▒ ░         ░      ░ ▒ ▒░   ░ ▒ ▒░ ░ ░ ▒  ░
  ░ ░    ░   ▒     ░░   ░ ░░         ░      ░ ░ ░ ▒  ░ ░ ░ ▒    ░ ░   
    ░  ░     ░  ░   ░                           ░ ░      ░ ░      ░  ░
                                                             larptool by bigbubbychubby

");
        }
        static void Menu()
        {
            Console.WriteLine("\n1. Yo");
            Console.WriteLine("\n2 This is just the bones of the project.");
            Console.WriteLine("\n3. Do the rest yourself");
        }
    }
}
