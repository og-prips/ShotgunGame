using System.Runtime.InteropServices;
using ShotgunGame.Players;

namespace ShotgunGame
{
    public partial class GameForm : Form
    {
        Game game = new Game();
        private static string _shotsMessage = string.Empty;
        private bool _isQuickDraw = false;

        public GameForm()
        {
            InitializeComponent();

            game.Human = new Human();
            game.Computer = new Computer();
            
            //RenderQuickDraw();
        }

        private void ExchangeForeBackColor(Control control)
        {
            var initialBackColor = control.BackColor;
            var initialForeColor = control.ForeColor;
            control.BackColor = initialForeColor;
            control.ForeColor = initialBackColor;
        }

        private void RenderGameOver(Player winner)
        {
            if (winner == game.Human)
            {
                SetLabel(lblGameResult, "YOU WIN", true, Color.LightGreen);
                game.GameOver(game.Human);
            }
            else
            {
                SetLabel(lblGameResult, "YOU LOSE", true, Color.Red);
                game.GameOver(game.Computer);
            }

            btnPlayAgain.Visible = true;

            btnShotgun.Visible = false;
            btnShoot.Visible = false;
            btnReload.Visible = false;
            btnBlock.Visible = false;
        }

        private void RenderQuickDraw()
        {
            //_isQuickDraw = true;

            //btnShotgun.Visible = true;
            //btnShoot.Visible = false;
            //btnReload.Visible = false;
            //btnBlock.Visible = false;


            btnShotgun.BringToFront();

            foreach (Control control in this.Controls)
            {

                if (control == progressBarQuickDraw || control == btnShotgun)
                {
                    control.Visible = true;
                }
                else
                {
                    control.Visible = false;
                }
            }

            game.QuickDraw(progressBarQuickDraw);
        }

        private void ResetForm()
        {
            btnShotgun.Visible = false;
            btnShoot.Visible = true;
            btnReload.Visible = true;
            btnBlock.Visible = true;
            lblHumanAction.Text = String.Empty;
            lblComputerAction.Text = String.Empty;
            lblShotsMessage.Text = string.Empty;
        }

        public static void SetShotsMessage(int humanShotDifference, int computerShotDifference)
        {
            _shotsMessage = $"You get: {humanShotDifference} shot   Computer gets: {computerShotDifference} shot";
        }

        private void SetLabel(Label label, string text, bool visible, Color foreColor)
        {
            label.Text = text;
            label.Visible = visible;
            label.ForeColor = foreColor;
        }
        
        private void btnShoot_Click(object sender, EventArgs e)
        {
            game.Human.Choice = Player.Action.Shoot;
            imgHumanWeapon.Image = Properties.Resources.shotgun;
            imgHumanFragments.Image = Properties.Resources.ammunition;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            game.Human.Choice = Player.Action.Reload;
            imgHumanWeapon.Image = Properties.Resources.reload;
            imgHumanFragments.Image = null;
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            game.Human.Choice = Player.Action.Block;
            imgHumanWeapon.Image = Properties.Resources.shield;
            imgHumanFragments.Image = null;
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            if (_isQuickDraw)
            {
                game.Human.HasShotQuickDraw = true;
            }
            else
            {
                game.Human.Choice = Player.Action.Shotgun;
            }
        }

        private void anyButton_MouseClick(object sender, MouseEventArgs e)
        {
            RenderGame();
        }

        private async void RenderGame()
        {
            RenderRound();

            game.PlayGame();

            if (game.Winner == game.Human)
            {
                await Task.Delay(750);
                RenderGameOver(game.Human);
            }
            else if (game.Winner == game.Computer)
            {
                await Task.Delay(750);
                RenderGameOver(game.Computer);
            }
            else if (game.Human.ShotgunAvailable() && game.Computer.ShotgunAvailable())
            {
                RenderQuickDraw();
            }
        }

        private async void RenderRound()
        {
            lblGameResult.Visible = false;
            lblHumanAction.Text = $"You choose:\n{game.Human.Choice.ToString().ToUpper()}   ";

            btnShoot.Enabled = false;
            btnReload.Enabled = false;
            btnBlock.Enabled = false;

            await Task.Delay(750);

            if (game.Human.Shots != 0)
            {
                btnShoot.Enabled = true;
            }
            btnReload.Enabled = true;
            btnBlock.Enabled = true;

            lblComputerAction.Text = $"Computer chooses:\n{game.Computer.Choice.ToString().ToUpper()}";
            lblShotsMessage.Text = _shotsMessage;

            if (game.Human.ShotgunAvailable() && !game.Computer.ShotgunAvailable())
            {
                btnShotgun.Visible = true;
                btnShoot.Visible = false;
                btnReload.Visible = false;
                btnBlock.Visible = false;
            }

            lblHumanScore.Text = $"Your score: {game.Human.Score.ToString()}";
            lblComputerScore.Text = $"Computer score: {game.Computer.Score.ToString()}";
            lblPlayerShots.Text = game.Human.Shots.ToString();
            lblComputerShots.Text = game.Computer.Shots.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void anyGameButton_MouseEnter(object sender, EventArgs e)
        {
            ExchangeForeBackColor((Control)sender);
        }

        private void btnShoot_MouseLeave(object sender, EventArgs e)
        {
            ExchangeForeBackColor((Control)sender);
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            btnPlayAgain.Visible = false;

            ResetForm();
        }
    }
}
