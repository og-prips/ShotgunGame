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

        public void GenerateChoice(Human human)
        {
            Random random = new Random();

            if (ForceReload)
            {
                Choice = Action.Reload;
            }
            else if (ShotgunAvailable())
            {
                Choice = Action.Shotgun;
            }
            else if (Shots == 0 && human.Shots == 0)
            {
                Choice = Action.Reload;
            }
            else if (Shots > 0 && human.Shots == 0)
            {
                Choice = Action.Shoot;
            }
            else if (Shots == 0)
            {
                Choice = (Action)random.Next(1, 3);
            }
            else
            {
                Choice = (Action)random.Next(0, 3);
            }
        }
    }
}
