using ShotgunGame.Players;
using System.Reflection;

namespace ShotgunGame
{
    internal class Game
    {
        public Human Human { get; set; }
        public Computer Computer { get; set; }

        public Player Winner
        {
            get
            {
                return checkForWinner(Human, Computer);
            }
        }

        private Player? checkForWinner(Player playerOne, Player playerTwo)
        {
            if (playerOne.Choice == Player.Action.Shoot && playerTwo.Choice == Player.Action.Reload ||
                playerOne.Choice == Player.Action.Shotgun && playerTwo.Choice != Player.Action.Shotgun)
            {
                return playerOne;
            }
            else if (playerTwo.Choice == Player.Action.Shoot && playerOne.Choice == Player.Action.Reload ||
                     playerTwo.Choice == Player.Action.Shotgun && playerOne.Choice != Player.Action.Shotgun)
            {
                return playerTwo;
            }

            return null;
        }

        public void PlayGame()
        {
            Computer.GenerateComputerChoice();
            CalculateShots(Human.Choice, Computer.Choice);
        }

        public async void QuickDraw(ProgressBar progressBar)
        {
            int countdown = 100;

            while (countdown >= 0)
            {
                if (Human.HasShotQuickDraw)
                {
                    GameOver(Human);
                    break;
                }
                else
                {
                    progressBar.Value = countdown;
                    countdown--;
                    await Task.Delay(15);
                }

                if (countdown >= 66)
                {
                    progressBar.ForeColor = Color.Green;
                }
                else if (countdown >= 33)
                {
                    progressBar.ForeColor = Color.Yellow;
                }
                else
                {
                    progressBar.ForeColor = Color.Red;
                }
            }

            if (!Human.HasShotQuickDraw)
            {
                GameOver(Computer);
            }
        }

        public void GameOver(Player winner)
        {
            winner.Score += 1;

            ResetShots();
        }

        private void ResetShots()
        {
            Human.Shots = 0;
            Computer.Shots = 0;
        }

        private void CalculateShots(Enum playerChoice, Enum computerChoice)
        {
            
            switch (Human.Choice)
            {
                case Player.Action.Shoot:

                    if (Computer.Choice == Player.Action.Shoot)
                    {
                        Human.Shots -= 1;
                        Computer.Shots -= 1;
                        GameForm.SetShotsMessage(-1, -1);
                    }
                    else if (Computer.Choice == Player.Action.Reload)
                    {
                        Human.Shots += 1;
                        GameForm.SetShotsMessage(1, 0);
                    }
                    else if (Computer.Choice == Player.Action.Block)
                    {
                        Human.Shots -= 1;
                        GameForm.SetShotsMessage(-1, 0);
                    }
                    break;

                case Player.Action.Reload:

                    if (Computer.Choice == Player.Action.Shoot)
                    {
                        Computer.Shots += 1;
                        GameForm.SetShotsMessage(1, 0);
                    }
                    else if (Computer.Choice == Player.Action.Reload)
                    {
                        Human.Shots += 1;
                        Computer.Shots += 1;
                        GameForm.SetShotsMessage(1, 1);
                    }
                    else if (Computer.Choice == Player.Action.Block)
                    {
                        Human.Shots += 1;
                        GameForm.SetShotsMessage(1, 0);
                    }
                    break;

                case Player.Action.Block:

                    if (Computer.Choice == Player.Action.Shoot)
                    {
                        Computer.Shots -= 1;
                        GameForm.SetShotsMessage(-1, 0);
                    }
                    else if (Computer.Choice == Player.Action.Reload)
                    {
                        Computer.Shots += 1;
                        GameForm.SetShotsMessage(1, 0);
                    }
                    else if (Computer.Choice == Player.Action.Block)
                    {
                        GameForm.SetShotsMessage(0, 0);
                        break;
                    }
                    break;
            }
        }
    }
}
