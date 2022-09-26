namespace ShotgunGame
{
    internal class Player
    {
        private int _shots;

        public enum PlayerChoice
        {
            Shoot,
            Reload,
            Block,
            Shotgun
        }

        public PlayerChoice Choice { get; set; }
        public int Score { get; set; } = 0;
        public string Name { get; set; } = String.Empty;
        
        public int Shots
        {
            get
            {
                return _shots;
            }
            set
            {
                _shots = value;
                if (_shots <= 0) _shots = 0;
            }
        }

        public bool ShotgunAvailable()
        {
            if (Shots >= 3)
            {
                return true;
            }

            return false;
        }
    }
}
