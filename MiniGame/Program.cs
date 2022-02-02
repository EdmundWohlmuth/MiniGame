using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniGame
{
    class Program
    {
        //dec       
        static bool gameOver = false;


        static void Main(string[] args)
        {
            //int
            Map newMap = new Map();
            Player player = new Player();

            while (!gameOver)
            {
                newMap.DrawMap();
                newMap.MovePlayer(player.playerX, player.playerY, '@');
                player.UpdatePlayer();
            }
           
        }
    }
}
