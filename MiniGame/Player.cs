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
        Map map = new Map();

        public void UpdatePlayer()
        {
            player = '@';

            ConsoleKey keyPress = Console.ReadKey(true).Key;
            switch (keyPress)
            {
                case ConsoleKey.A:
                    playerX -= 1;
                    Console.WriteLine(playerX + "," + playerY);
                    break;

                case ConsoleKey.D:
                    playerX += 1;
                    Console.WriteLine(playerX + "," + playerY);
                    break;

                case ConsoleKey.S:
                    playerY += 1;
                    Console.WriteLine(playerX + "," + playerY);
                    break;

                case ConsoleKey.W:
                    playerY -= 1;
                    Console.WriteLine(playerX + "," + playerY);
                    break;

                default:

                    break;
            }
        }

        public void MovePlayer()
        {
            map.gameMap[playerX, playerY] = player;
        }
    }
}
