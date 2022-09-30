using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunGame.Players
{
    public sealed class Computer : Player
    {
        public bool ForceReload { get; set; }

        public override Image? ImageWeapon
        {
            get
            {
                if (Choice == Action.Shoot)
                {
                    return Properties.Resources.shotgun2;
                }
                else if (Choice == Action.Reload)
                {
                    return Properties.Resources.reload;
                }
                else if (Choice == Action.Block)
                {
                    return Properties.Resources.shield;
                }
                else
                {
                    return null;
                }
            }
        }

        public void GenerateComputerChoice()
        {
            Random random = new Random();

            if (ForceReload == true)
            {
                Choice = Action.Reload;
            }
            else
            {
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
}
