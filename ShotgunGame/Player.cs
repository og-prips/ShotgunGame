using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShotgunGame
{
    public enum PlayerChoice
    {
        Shoot = 0,
        Reload = 1,
        Block = 2,
        Shotgun = 3
    }

    internal class Player
    {
        private int _shots;

        public int Score { get; set; } = 0;
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
        public string Name { get; set; } = String.Empty;
        public bool ShotgunAvailable { get; set; } = false;
        public PlayerChoice Choice { get; set; }
        public bool Win { get; set; }
    }
}
