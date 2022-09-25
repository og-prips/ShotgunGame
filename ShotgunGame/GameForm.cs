using System.Diagnostics;

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
            game.Human.Choice = Player.PlayerChoice.Shoot;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            game.Human.Choice = Player.PlayerChoice.Reload;
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            game.Human.Choice = Player.PlayerChoice.Block;
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            game.Human.Choice = Player.PlayerChoice.Shotgun;
        }

        private void anyButton_MouseClick(object sender, MouseEventArgs e)
        {
            game.PlayGame();

            if (game.Human.ShotgunAvailable() && !game.Computer.ShotgunAvailable())
            {
                btnShotgun.Visible = true;
                btnShoot.Enabled = false;
                btnReload.Enabled = false;
                btnBlock.Enabled = false;
            }
            else if (game.Human.ShotgunAvailable() && game.Computer.ShotgunAvailable())
            {
                FastDraw();
            }

            Debug.Print($"----- Human choice: {game.Human.Choice} Computer choice: {game.Computer.Choice} -----");

            if (game.CheckForWinner(game.Human, game.Computer) == game.Human)
            {
                Debug.Print("----- Human WIN");
                lblHumanScore.Text = $"Your score: {game.Human.Score.ToString()}";
                game.ResetGame();
                btnShotgun.Visible = false;
                btnShoot.Enabled = true;
                btnReload.Enabled = true;
                btnBlock.Enabled = true;
            }
            else if (game.CheckForWinner(game.Human, game.Computer) == game.Computer)
            {
                Debug.Print("----- Computer WIN");
                lblComputerScore.Text = $"Computer score: {game.Computer.Score.ToString()}";
                game.ResetGame();
                btnShotgun.Visible = false;
                btnShoot.Enabled = true;
                btnReload.Enabled = true;
                btnBlock.Enabled = true;
            }

            lblPlayerShots.Text = game.Human.Shots.ToString();
            lblComputerShots.Text = game.Computer.Shots.ToString();

            Debug.Print($"----- Human shots: {game.Human.Shots} ///// Computer shots: {game.Computer.Shots}");
        }

        private void FastDraw()
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            game.ExitGame();
        }

        private void anyGameButton_MouseEnter(object sender, EventArgs e)
        {
            ExchangeForeBackColor(sender as Button);
        }

        private void btnShoot_MouseLeave(object sender, EventArgs e)
        {
            ExchangeForeBackColor(sender as Button);
        }

        private void ExchangeForeBackColor(Control control)
        {
            var initialBackColor = control.BackColor;
            var initialForeColor = control.ForeColor;
            control.BackColor = initialForeColor;
            control.ForeColor = initialBackColor;

        }
    }
}
