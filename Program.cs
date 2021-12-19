using System;

namespace Zeta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game();
        }

        private static void Game()
        {
            Console.WriteLine("Enter Name...\n");
            string name = Console.ReadLine();
            Console.WriteLine("\nEnter password\n");
            string pass = Console.ReadLine();
            if (pass == "rPBF#b@AgH-Ks&^G")
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("\nRetreving Packets \n" + i.ToString() + "/10");
                }
                NextGame();
            }
            else
            {
                Console.WriteLine("\n\nIncorrect password...");
                return;
            }
        }

        private static void NextGame()
        {
            Console.WriteLine("\nEnter Target IP...");
            string ip = Console.ReadLine();
            Console.WriteLine($"\nLaunching attack on {ip}\nPlease Wait...");
            Utility.KeyPress();
            return;
        }
    }
}
