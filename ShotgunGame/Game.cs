using ShotgunGame.Players;

namespace ShotgunGame
{
    public class Game
    {
        public Human Human { get; set; }
        public Computer Computer { get; set; }
        public Player? Winner;

        public Player? GetWinner()
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

            return null;
        }

        public void PlayGame()
        {
            Computer.GenerateChoice(Human);
            CalculateShots(Human.Choice, Computer.Choice);
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
