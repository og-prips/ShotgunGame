namespace ShotgunGame
{
    internal class Game
    {
        public Player Human { get; set; }
        public Player Computer { get; set; }

        public void PlayGame()
        {
            GenerateComputerChoice();
            CalculateShots(Human.Choice, Computer.Choice);
        }

        public void ResetGame()
        {
            ResetShots();
        }

        public void ExitGame()
        {
            // write to files
        }

        private void ResetShots()
        {
            Human.Shots = 0;
            Computer.Shots = 0;
        }

        private void GenerateComputerChoice()
        {
            Random random = new Random();
            
            if (Computer.ShotgunAvailable())
            {
                Computer.Choice = Player.PlayerChoice.Shotgun;
            }
            else
            {
                Computer.Choice = (Player.PlayerChoice)random.Next(0, 3);
            }
        }

        private void CalculateShots(Enum playerChoice, Enum computerChoice)
        {
            switch (Human.Choice)
            {
                case Player.PlayerChoice.Shoot:

                    if (Computer.Choice == Player.PlayerChoice.Shoot)
                    {
                        Human.Shots -= 1;
                        Computer.Shots -= 1;
                        GameForm.SetShotsMessage(-1, -1);
                    }
                    else if (Computer.Choice == Player.PlayerChoice.Reload)
                    {
                        Human.Shots += 1;
                        GameForm.SetShotsMessage(1, 0);
                    }
                    else if (Computer.Choice == Player.PlayerChoice.Block)
                    {
                        Human.Shots -= 1;
                        GameForm.SetShotsMessage(-1, 0);
                    }
                    break;

                case Player.PlayerChoice.Reload:

                    if (Computer.Choice == Player.PlayerChoice.Shoot)
                    {
                        Computer.Shots += 1;
                        GameForm.SetShotsMessage(1, 0);
                    }
                    else if (Computer.Choice == Player.PlayerChoice.Reload)
                    {
                        Human.Shots += 1;
                        Computer.Shots += 1;
                        GameForm.SetShotsMessage(1, 1);
                    }
                    else if (Computer.Choice == Player.PlayerChoice.Block)
                    {
                        Human.Shots += 1;
                        GameForm.SetShotsMessage(1, 0);
                    }
                    break;

                case Player.PlayerChoice.Block:

                    if (Computer.Choice == Player.PlayerChoice.Shoot)
                    {
                        Computer.Shots -= 1;
                        GameForm.SetShotsMessage(-1, 0);
                    }
                    else if (Computer.Choice == Player.PlayerChoice.Reload)
                    {
                        Computer.Shots += 1;
                        GameForm.SetShotsMessage(1, 0);
                    }
                    else if (Computer.Choice == Player.PlayerChoice.Block)
                    {
                        GameForm.SetShotsMessage(0, 0);
                        break;
                    }
                    break;
            }
        }

        public Player? CheckForWinner(Player playerOne, Player playerTwo)
        {
            if (playerOne.Choice == Player.PlayerChoice.Shoot && playerTwo.Choice == Player.PlayerChoice.Reload ||
                playerOne.Choice == Player.PlayerChoice.Shotgun && playerTwo.Choice != Player.PlayerChoice.Shotgun)
            {
                return playerOne;
            }
            else if (playerTwo.Choice == Player.PlayerChoice.Shoot && playerOne.Choice == Player.PlayerChoice.Reload || 
                     playerTwo.Choice == Player.PlayerChoice.Shotgun && playerOne.Choice != Player.PlayerChoice.Shotgun)
            {
                return playerTwo;
            }

            return null;
        }
    }
}
