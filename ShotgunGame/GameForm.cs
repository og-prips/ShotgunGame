using System.Runtime.InteropServices;
using ShotgunGame.Players;

namespace ShotgunGame
{
    public partial class GameForm : Form
    {
        //Game game = new Game();
        private static string _shotsMessage = string.Empty;
        public static bool IsQuickDraw = false;
        public static Panel ProgressBar = new Panel();

        public GameForm()
        {
            InitializeComponent();

            ProgressBar.Visible = false;
            ProgressBar.Size = this.Size;
            ProgressBar.BackColor = Color.Red;
            ProgressBar.Location = new Point(0, 0);
            this.Controls.Add(ProgressBar);

            Game.Human = new Human();
            Game.Computer = new Computer();

            //RenderQuickDraw();
            //RenderGameOver(game.Winner);
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
            if (winner == Game.Human)
            {
                SetLabel(lblGameResult, "YOU WIN", true, Color.LightGreen);
                Game.GameOver(Game.Human);
            }
            else
            {
                SetLabel(lblGameResult, "YOU LOSE", true, Color.Red);
                Game.GameOver(Game.Computer);
            }

            btnPlayAgain.Visible = true;
            btnShotgun.Visible = false;
            btnShoot.Visible = false;
            btnReload.Visible = false;
            btnBlock.Visible = false;

            lblHumanScore.Text = $"Your score: {Game.Human.Score.ToString()}";
            lblComputerScore.Text = $"Computer score: {Game.Computer.Score.ToString()}";
        }

        private void RenderQuickDraw()
        {
            //var ProgressBar = new Panel();
            //ProgressBar.Size = this.Size;
            //ProgressBar.BackColor = Color.Red;
            //ProgressBar.Location = new Point(0, 0);
            //ProgressBar.Name = "QuickdrawProgressBar";

            

            //this.Controls.Add(ProgressBar);

            foreach (Control control in this.Controls)
            {
                if (control == ProgressBar) control.Visible = true;
                else control.Visible = false;
            }
        }

        private void ResetForm()
        {
            foreach (Control control in this.Controls)
            {
                if (control.Name == "QuickdrawProgressBar" || 
                    control == btnShotgun || 
                    control == btnPlayAgain || 
                    control == lblGameResult)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }

            imgComputerFragments.Image = null;
            imgComputerWeapon.Image = null;
            imgHumanFragments.Image = null;
            imgHumanWeapon.Image = null;
            
            lblHumanAction.Text = String.Empty;
            lblComputerAction.Text = String.Empty;
            lblShotsMessage.Text = string.Empty;
        }

        public static void SetShotsMessage(int humanShotDifference, int computerShotDifference)
        {
            _shotsMessage = $"You get: {humanShotDifference} shot       Computer gets: {computerShotDifference} shots";
        }

        private void SetLabel(Label label, string text, bool visible, Color foreColor)
        {
            label.Text = text;
            label.Visible = visible;
            label.ForeColor = foreColor;
        }
        
        private void btnShoot_Click(object sender, EventArgs e)
        {
            Game.Human.Choice = Player.Action.Shoot;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Game.Human.Choice = Player.Action.Reload;
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            Game.Human.Choice = Player.Action.Block;
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            if (IsQuickDraw)
            {
                Game.Human.HasShotQuickDraw = true;
            }
            else
            {
                Game.Human.Choice = Player.Action.Shotgun;
            }
        }

        private void anyGameButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (chkForceReload.Checked) Game.Computer.ForceReload = true;
            RenderGame();
        }

        public static async void RenderGame()
        {
            RenderRound();

            Game.PlayGame();

            //if (game.Winner == game.Human)
            //{
            //    await Task.Delay(750);
            //    RenderGameOver(game.Human);
            //}
            //else if (game.Winner == game.Computer)
            //{
            //    await Task.Delay(750);
            //    RenderGameOver(game.Computer);
            //}
            if (Game.Human.ShotgunAvailable() && Game.Computer.ShotgunAvailable())
            {
                await Task.Delay(750);
                IsQuickDraw = true;
                RenderQuickDraw();
                Game.QuickDraw(ProgressBar);
            }

            if (Game.Winner != null)
            {
                await Task.Delay(750);
                RenderGameOver(Game.Winner);
            }
        }

        private static async void RenderRound()
        {
            lblGameResult.Visible = false;
            lblHumanAction.Text = $"You choose:\n{game.Human.Choice.ToString().ToUpper()}   ";
            imgHumanWeapon.Image = game.Human.ImageWeapon;
            imgHumanFragments.Image = game.Human.ImageFragments;

            btnShoot.Enabled = false;
            btnReload.Enabled = false;
            btnBlock.Enabled = false;

            await Task.Delay(750);

            if (game.Human.Shots != 0) btnShoot.Enabled = true;
            btnReload.Enabled = true;
            btnBlock.Enabled = true;

            imgComputerWeapon.Image = game.Computer.ImageWeapon;
            imgComputerFragments.Image = game.Computer.ImageFragments;
            lblComputerAction.Text = $"Computer chooses:\n{game.Computer.Choice.ToString().ToUpper()}";
            lblShotsMessage.Text = _shotsMessage;

            if (game.Human.ShotgunAvailable() && !game.Computer.ShotgunAvailable())
            {
                btnShotgun.Visible = true;
                btnShoot.Visible = false;
                btnReload.Visible = false;
                btnBlock.Visible = false;
            }

            lblPlayerShots.Text = game.Human.Shots.ToString();
            lblComputerShots.Text = game.Computer.Shots.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void anyButton_MouseEnter(object sender, EventArgs e)
        {
            ExchangeForeBackColor((Control)sender);
        }

        private void anyButton_MouseLeave(object sender, EventArgs e)
        {
            ExchangeForeBackColor((Control)sender);
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            btnPlayAgain.Visible = false;

            ResetForm();
        }

        private void GameForm_DoubleClick(object sender, EventArgs e)
        {
            if (IsQuickDraw)
            {
                game.Human.HasShotQuickDraw = true;
            }
        }
    }
}
