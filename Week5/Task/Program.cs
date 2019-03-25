using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Snake
{
    class Program
    {
        public static bool IsCollisionWithWallOrYourself = true;
        public static string Username;
        public static void username()
        {
            Console.WriteLine("Enter your username");
            Username = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(43, 1);
            Console.WriteLine("Player: " + Username);
        }

        static void Main(string[] args)
        {
            
           GameState gameState = new GameState();

            
            int score = 0;
            username();
           
            Console.SetCursorPosition(43, 2);
            Console.WriteLine("Your score is: " + score);
            
            while (IsCollisionWithWallOrYourself)
            {
                gameState.Draw();
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                gameState.ProcessKey(consoleKeyInfo);
            }
        }
    }
}