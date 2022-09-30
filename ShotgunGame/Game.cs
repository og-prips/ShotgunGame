using ShotgunGame.Players;
using System.Reflection;

namespace ShotgunGame
{
    public static class Game
    {
        private static bool _taskComplete;

        public static Human Human { get; set; }
        public static Computer Computer { get; set; }

        public static Player? Winner
        {
            get
            {
                return GetWinner();
            }
        }

        private static Player? GetWinner()
        {
            if (Human.Choice == Player.Action.Shoot && Computer.Choice == Player.Action.Reload ||
                Human.Choice == Player.Action.Shotgun && Computer.Choice != Player.Action.Shotgun)
            {
                return Human;
            }
            else if (Computer.Choice == Player.Action.Shoot && Human.Choice == Player.Action.Reload ||
                     Computer.Choice == Player.Action.Shotgun && Human.Choice != Player.Action.Shotgun)
            {
                return Computer;
            }
            else if (GameForm.IsQuickDraw)
            {
                if (_taskComplete && Human.HasShotQuickDraw) return Human;
                else if (_taskComplete && !Human.HasShotQuickDraw) return Computer;
            }

            return null;
        }

        public static void PlayGame()
        {
            Computer.GenerateComputerChoice();
            CalculateShots(Human.Choice, Computer.Choice);
        }

        public static async void QuickDraw(Panel progressBar)
        {
            int countdown = progressBar.Width;
            var initialWidth = progressBar.Width;
            _taskComplete = false;

            while (countdown >= 0)
            {
                if (Human.HasShotQuickDraw)
                {
                    break;
                }
                else
                {
                    progressBar.Width = countdown;
                    countdown -= initialWidth / 100;
                    await Task.Delay(13);
                }

                if (countdown >= (initialWidth / 3) * 2)
                {
                    progressBar.BackColor = Color.Green;
                }
                else if (countdown >= initialWidth / 3)
                {
                    progressBar.BackColor = Color.Yellow;
                }
                else
                {
                    progressBar.BackColor = Color.Red;
                }
            }

            _taskComplete = true;
        }

        public static void GameOver(Player winner)
        {
            winner.Score += 1;

            ResetShots();
        }

        private static void ResetShots()
        {
            Human.Shots = 0;
            Computer.Shots = 0;
        }

        private static void CalculateShots(Enum playerChoice, Enum computerChoice)
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
