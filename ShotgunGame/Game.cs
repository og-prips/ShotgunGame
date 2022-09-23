using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunGame
{
    internal class Game
    {
        public Player Human { get; set; }
        public Player Computer { get; set; }
        Player player = new Player();

        public void PlayGame()
        {
            GenerateComputerChoice();
            CalculateShots(player.Choice, Computer.Choice);
        }

        public void ResetGame()
        {
            ResetShots();
            Human.Win = false;
            Computer.Win = false;
        }

        public void ExitGame()
        {

        }

        private void ResetShots()
        {
            Human.Shots = 0;
            Computer.Shots = 0;
        }

        private void GenerateComputerChoice()
        {
            Random random = new Random();
            
            if (Computer.ShotgunAvailable)
            {
                ResetShots();
            }
            else
            {
                Computer.Choice = (PlayerChoice)random.Next(0, 3);
            }
        }

        private void CalculateShots(Enum playerChoice, Enum computerChoice)
        {
            switch (Human.Choice)
            {
                case PlayerChoice.Shoot:

                    if (Computer.Choice == PlayerChoice.Shoot)
                    {
                        Human.Shots -= 1;
                        Computer.Shots -= 1;
                    }
                    else if (Computer.Choice == PlayerChoice.Reload)
                    {
                        Human.Win = true;
                        Human.Score += 1;
                    }
                    else if (Computer.Choice == PlayerChoice.Block)
                    {
                        Human.Shots -= 1;
                    }
                    break;
            }
        }
    }
}
