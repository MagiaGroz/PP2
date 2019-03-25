using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Snake

{

    class GameState

    {
        Worm worm = new Worm('O');
       public Food food = new Food('@');
        Wall wall = new Wall('#');
        public GameState()

        {
            Console.SetWindowSize(60, 40);
            Console.SetBufferSize(60, 40);
            Console.CursorVisible = false;
        }



        public void Draw()
        {
            worm.Draw();
            wall.Draw();
            food.Draw();
            CheckCollisionFoodGen();
        }
        int score = 0;

        public void CheckCollision()

        {

            foreach (Point s in worm.body) {
                if (worm.CheckIntersection(s))

                {


                    Console.SetCursorPosition(43, 4);
                    Console.WriteLine("|---YOU LOST---|");
                    Program.IsCollisionWithWallOrYourself = false;


                }
            }


            if (worm.CheckIntersection(food.body[0]))

            {
                
                worm.Eat(food.body[0]);
               
                CheckCollisionFoodGen();
                food.Generate();
                CheckCollisionFoodGen();


                Console.SetCursorPosition(43, 2);
                score += 1;
                Console.WriteLine("Your score is: " + score);
                if (score==3)
                {
                    Console.Clear();
                    Console.SetCursorPosition(43, 1);
                    Console.WriteLine("Player: " + Program.Username);

                    Console.SetCursorPosition(43, 2);
                    score = 0;
                    Console.WriteLine("Your score is: " + score);
                    wall.LoadLevel(2);
                    
                }
            }

            foreach (Point p in wall.body)
            {
                if (worm.CheckIntersection(p)) {
                    Console.SetCursorPosition(43, 4);
                    Console.WriteLine("|---YOU LOST---|");
                    Program.IsCollisionWithWallOrYourself = false;
                };
            }

        }


        public void CheckCollisionFoodGen()

        {

            foreach (Point s in worm.body)
            {
                if (CheckIntersectionFoodGen(s))

                {
                    food.Generate();
                }
            }

            foreach (Point p in wall.body)
            {
                if (CheckIntersectionFoodGen(p))
                {
                    
                    food.Generate();
                };
            }

        }

    
        public bool CheckIntersectionFoodGen(Point point)

        {

            bool res = false;
            if (point == food.body[0]) { return false; }

            if (food.body[0].X == point.X && food.body[0].Y == point.Y)
            {
                res = true;
            }


            return res;
        }

        public void ProcessKey(ConsoleKeyInfo consoleKeyInfo)

        {

            switch (consoleKeyInfo.Key)
            {

                case ConsoleKey.UpArrow:
                    worm.Move(0, -1);
                    break;

                case ConsoleKey.DownArrow:
                   worm.Move(0, 1);
                    break;

                case ConsoleKey.LeftArrow:
                    worm.Move(-1, 0);
                    break;

                case ConsoleKey.RightArrow:
                    worm.Move(1, 0);
                    break;
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
            CheckCollision();

        }

    }

}
