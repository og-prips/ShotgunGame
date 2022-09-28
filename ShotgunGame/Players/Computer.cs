using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunGame.Players
{
    public sealed class Computer : Player
    {
        public void GenerateComputerChoice()
        {
            Random random = new Random();

            if (this.ShotgunAvailable())
            {
                Choice = Player.Action.Shotgun;
            }
            else if (Shots == 0)
            {
                Choice = (Player.Action)random.Next(1, 3);
            }
            else
            {
                Choice = (Player.Action)random.Next(0, 3);
            }
        }
    }
}
