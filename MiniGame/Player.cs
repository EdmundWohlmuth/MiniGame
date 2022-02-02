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
        public char player;

        public void UpdatePlayer()
        {
            player = '@';

            ConsoleKey keyPress = Console.ReadKey(true).Key;
            switch (keyPress)
            {
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

                default:

                    break;
            }
        }
    }
}
