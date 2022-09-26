using System.Diagnostics;
using System.Drawing.Design;
using System.Drawing.Text;

namespace ShotgunGame
{
    public partial class GameForm : Form
    {
        Game game = new Game();
        private static string _shotsMessage = string.Empty;

        public GameForm()
        {
            InitializeComponent();
            game.Human = new Player();
            game.Computer = new Player();
        }

        private void ExchangeForeBackColor(Control control)
        {
            var initialBackColor = control.BackColor;
            var initialForeColor = control.ForeColor;
            control.BackColor = initialForeColor;
            control.ForeColor = initialBackColor;
        }

        private void GameOver(Player winner)
        {
            winner.Score += 1;

            if (winner == game.Human)
            {
                SetLabel(lblGameResult, "YOU WIN", true, Color.LightGreen);
            }
            else
            {
                SetLabel(lblGameResult, "YOU LOSE", true, Color.Red);
            }

            btnPlayAgain.Visible = true;

            btnShotgun.Visible = false;
            btnShoot.Visible = false;
            btnReload.Visible = false;
            btnBlock.Visible = false;

            game.ResetShots();
        }

        private void QuickDraw()
        {

        }

        private void ResetForm()
        {
            btnShotgun.Visible = false;
            btnShoot.Visible = true;
            btnReload.Visible = true;
            btnBlock.Visible = true;
            lblActionsMessage.Text = String.Empty;
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
            game.Human.Choice = Player.PlayerChoice.Shoot;
            imgHumanWeapon.Image = Properties.Resources.shotgun;
            imgHumanFragments.Image = Properties.Resources.ammunition;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            game.Human.Choice = Player.PlayerChoice.Reload;
            imgHumanWeapon.Image = Properties.Resources.reload;
            imgHumanFragments.Image = null;
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            game.Human.Choice = Player.PlayerChoice.Block;
            imgHumanWeapon.Image = Properties.Resources.shield;
            imgHumanFragments.Image = null;
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            game.Human.Choice = Player.PlayerChoice.Shotgun;
        }

        private async void anyButton_MouseClick(object sender, MouseEventArgs e)
        {
            var previousHumanShots = game.Human.Shots;
            var previousComputerShots = game.Computer.Shots;
            lblGameResult.Visible = false;

            game.PlayGame();

            lblActionsMessage.Text = $"You choose: {game.Human.Choice.ToString().ToUpper()}   ";

            btnShoot.Enabled = false;
            btnReload.Enabled = false;
            btnBlock.Enabled = false;

            await Task.Delay(750);

            btnShoot.Enabled = true;
            btnReload.Enabled = true;
            btnBlock.Enabled = true;

            lblActionsMessage.Text += $"Computer chooses: {game.Computer.Choice.ToString().ToUpper()}";
            lblShotsMessage.Text = _shotsMessage;

            if (game.Human.ShotgunAvailable() && !game.Computer.ShotgunAvailable())
            {
                btnShotgun.Visible = true;
                btnShoot.Visible = false;
                btnReload.Visible = false;
                btnBlock.Visible = false;
            }
            else if (game.Human.ShotgunAvailable() && game.Computer.ShotgunAvailable())
            {
                QuickDraw();
            }

            Debug.Print($"----- Human choice: {game.Human.Choice} Computer choice: {game.Computer.Choice} -----");

            if (game.CheckForWinner(game.Human, game.Computer) == game.Human)
            {
                Debug.Print("----- Human WIN -----");

                GameOver(game.Human);
            }
            else if (game.CheckForWinner(game.Human, game.Computer) == game.Computer)
            {
                Debug.Print("----- Computer WIN -----");

                GameOver(game.Computer);
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

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            game.ExitGame();
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
