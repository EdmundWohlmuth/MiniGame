using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame
{
    class Player
    {
        public int playerX;
        public int playerY;

        public void MovePlayer()
        {
            ConsoleKey keyPress = Console.ReadKey(true).Key;
            switch (keyPress)
            {
                // ----------------------- WASD --------------------------
                case ConsoleKey.W:
                    playerX -= 1;
                    Console.WriteLine(playerX + "," + playerY);
                    break;

                case ConsoleKey.S:
                    playerX += 1;
                    Console.WriteLine(playerX + "," + playerY);
                    break;

                case ConsoleKey.D:
                    playerY += 1;
                    Console.WriteLine(playerX + "," + playerY);
                    break;

                case ConsoleKey.A:
                    playerY -= 1;
                    Console.WriteLine(playerX + "," + playerY);
                    break;

                    // ----------------- Arrow Keys -------------------------
                case ConsoleKey.UpArrow:
                    playerX -= 1;
                    Console.WriteLine(playerX + "," + playerY);
                    break;

                case ConsoleKey.DownArrow:
                    playerX += 1;
                    Console.WriteLine(playerX + "," + playerY);
                    break;

                case ConsoleKey.RightArrow:
                    playerY += 1;
                    Console.WriteLine(playerX + "," + playerY);
                    break;

                case ConsoleKey.LeftArrow:
                    playerY -= 1;
                    Console.WriteLine(playerX + "," + playerY);
                    break;

                default:

                    break;
            }
        }
    }
}
