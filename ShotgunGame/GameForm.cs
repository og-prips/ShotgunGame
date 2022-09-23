using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShotgunGame
{
    public partial class GameForm : Form
    {
        Game game = new Game();

        public GameForm()
        {
            InitializeComponent();
            game.Human = new Player();
            game.Computer = new Player();
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            game.Human.Choice = PlayerChoice.Shoot;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            game.Human.Choice = (PlayerChoice)1;
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            game.Human.Choice = PlayerChoice.Block;
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            game.Human.Choice = PlayerChoice.Shotgun;
        }

        private void anyButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (game.Human.Win)
            {
                game.ResetGame();
                lblHumanScore.Text = $"Your score: {game.Human.Score.ToString()}";
            }
            else if (game.Computer.Win)
            {
                game.ResetGame();
                lblComputerScore.Text = $"Computer score: {game.Computer.Score.ToString()}";
            }
            else
            {
                game.PlayGame();
            }

            lblPlayerShots.Text = game.Human.Shots.ToString();
            lblComputerShots.Text = game.Computer.Shots.ToString();
        }
    }
}
