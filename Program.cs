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
            Console.WriteLine("Enter Name...");
            string name = Console.ReadLine();
            Console.WriteLine("Enter password");
            string pass = Console.ReadLine();
            if (pass == "rPBF#b@AgH-Ks&^G")
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Retreving Packets " + i.ToString() + "/10");
                }
                NextGame();
            }
            else
            {
                Console.WriteLine("Incorrect password...");
                return;
            }
        }

        private static void NextGame()
        {
            Console.WriteLine("Launching attack\n\nPlease Wait...");
            Utility.KeyPress();
            return;
        }
    }
}
