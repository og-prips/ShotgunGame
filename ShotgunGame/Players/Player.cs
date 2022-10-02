namespace ShotgunGame
{
    public class Player
    {
        private int shots;

        public enum Action
        {
            Shoot,
            Reload,
            Block,
            Shotgun
        }

        //public Image[] ImageShots = new Image[3];        

        public virtual Image? ImageWeapon
        {
            get
            {
                if (Choice == Action.Shoot)
                {
                    return Properties.Resources.shotgun;
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

        public Image? ImageFragments
        {
            get
            {
                if (Choice == Action.Shoot)
                {
                    return Properties.Resources.ammunition;
                }
                else
                {
                    return null;
                }
            }
        }

        public Action Choice { get; set; }
        public int Score { get; set; } = 0;

        public int Shots
        {
            get
            {
                return shots;
            }
            set
            {
                shots = value;
                if (shots <= 0) shots = 0;
            }
        }

        public bool ShotgunAvailable()
        {
            if (Shots >= 3) return true;

            return false;
        }
    }
}
