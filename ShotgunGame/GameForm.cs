using ShotgunGame.Players;

namespace ShotgunGame
{
    public partial class GameForm : Form
    {
        Game game = new Game();

        private static string? shotsMessage;
        private int countdownQuickDraw = 100;
        private int progressBarInitialWidth;
        private bool isQuickDraw = false;
        private Panel progressBar = new Panel();
        private PictureBox[] humanShotsImages;
        private PictureBox[] computerShotsImages;

        public GameForm()
        {
            InitializeComponent();

            this.Controls.Add(progressBar);
            progressBar.Click += new EventHandler(progressBar_Click);

            humanShotsImages = new PictureBox[] { imgHumanShots1, imgHumanShots2, imgHumanShots3 };
            computerShotsImages = new PictureBox[] { imgComputerShots1, imgComputerShots2, imgComputerShots3 };

            imgHumanShots1.BringToFront();
            imgHumanShots2.BringToFront();
            imgHumanShots3.BringToFront();
            imgComputerShots1.BringToFront();
            imgComputerShots2.BringToFront();
            imgComputerShots3.BringToFront();

            game.Human = new Human();
            game.Computer = new Computer();
        }

        #region Methods
        private void ExchangeForeBackColor(Control control)
        {
            var initialBackColor = control.BackColor;
            var initialForeColor = control.ForeColor;
            control.BackColor = initialForeColor;
            control.ForeColor = initialBackColor;
        }

        private void RenderNewRound()
        {
            foreach (Control control in this.Controls)
            {
                if (control == progressBar ||
                    control == btnShotgun ||
                    control == btnPlayAgain ||
                    control == lblGameResult ||
                    control == lblQuickDraw)
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
            lblShotsMessage.Text = String.Empty;
            lblPlayerShots.Text = game.Human.Shots.ToString();
            lblComputerShots.Text = game.Computer.Shots.ToString();

            btnShoot.Enabled = false;
        }

        public async void RenderGame()
        {
            game.PlayGame();
            RenderRound();

            if (game.Human.ShotgunAvailable() && game.Computer.ShotgunAvailable())
            {   
                RenderQuickDraw();
                await Task.Delay(1500);
                timerQuickDraw.Start();
                isQuickDraw = true;
            }
            else
            {
                game.Winner = game.GetWinner();

                if (game.Winner != null)
                {
                    await Task.Delay(750);
                    RenderGameOver(game.Winner);
                }
            }
        }

        private void SetShotsImages(Player player, PictureBox[] pictureBoxes)
        {
            for (int i = pictureBoxes.Length; i < game.Human.Shots; i++)
            {
                humanShotsImages[i].Visible = true;
            }

            switch (player.Shots)
            {
                case 0:
                    imgHumanShots1.Visible = false;
                    imgHumanShots2.Visible = false;
                    imgHumanShots3.Visible = false;
                    break;

                case 1:
                    imgHumanShots1.Visible = true;
                    imgHumanShots1.Visible = false;
                    imgHumanShots1.Visible = false;
                    break;
            }
        }

        private async void RenderRound()
        {
            lblGameResult.Visible = false;
            lblHumanAction.Text = $"You chose:\n{game.Human.Choice.ToString().ToUpper()}   ";
            lblComputerAction.Text = string.Empty;

            imgHumanWeapon.Image = game.Human.ImageWeapon;
            imgHumanFragments.Image = game.Human.ImageFragments;
            imgComputerFragments.Image = null;
            imgComputerWeapon.Image = null;

            btnShoot.Enabled = false;
            btnReload.Enabled = false;
            btnBlock.Enabled = false;

            await Task.Delay(750);

            if (game.Human.Shots != 0) btnShoot.Enabled = true;
            btnReload.Enabled = true;
            btnBlock.Enabled = true;

            imgComputerWeapon.Image = game.Computer.ImageWeapon;
            imgComputerFragments.Image = game.Computer.ImageFragments;
            lblComputerAction.Text = $"Computer chose:\n{game.Computer.Choice.ToString().ToUpper()}";
            lblShotsMessage.Text = shotsMessage;

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

        private void RenderQuickDraw()
        {
            progressBar.Size = this.Size;
            progressBarInitialWidth = progressBar.Width;
            progressBar.Visible = true;
            progressBar.Location = new Point(0, 0);
            progressBar.BackColor = Color.Green;

            foreach (Control control in this.Controls)
            {
                if (control == progressBar || control == lblQuickDraw) control.Visible = true;
                else control.Visible = false;
            }
        }

        private void RenderGameOver(Player winner)
        {
            lblQuickDraw.Visible = false;
            progressBar.Visible = false;

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

            lblHumanScore.Text = $"Your score: {game.Human.Score.ToString()}";
            lblComputerScore.Text = $"Computer score: {game.Computer.Score.ToString()}";
        }

        public static void SetShotsMessage(int humanShotDifference, int computerShotDifference)
        {
            shotsMessage = $"You get: {humanShotDifference} shot       Computer gets: {computerShotDifference} shots";
        }

        private void SetLabel(Label label, string text, bool visible, Color foreColor)
        {
            label.Text = text;
            label.Visible = visible;
            label.ForeColor = foreColor;
        }
        #endregion

        #region Events
        private void progressBar_Click(object sender, EventArgs e)
        {
            if (isQuickDraw)
            {
                timerQuickDraw.Stop();

                countdownQuickDraw = 100;
                isQuickDraw = false;

                RenderGameOver(game.Human);
            }
        }

        private void btnShoot_Click(object sender, EventArgs e)
        {
            game.Human.Choice = Player.Action.Shoot;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            game.Human.Choice = Player.Action.Reload;
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            game.Human.Choice = Player.Action.Block;
        }

        private void btnShotgun_Click(object sender, EventArgs e)
        {
            game.Human.Choice = Player.Action.Shotgun;
        }

        private void anyGameButton_MouseClick(object sender, MouseEventArgs e)
        {
            game.Computer.ForceReload = chkForceReload.Checked;

            RenderGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            RenderNewRound();
        }

        private void anyButton_MouseEnter(object sender, EventArgs e)
        {
            ExchangeForeBackColor((Control)sender);
        }

        private void anyButton_MouseLeave(object sender, EventArgs e)
        {
            ExchangeForeBackColor((Control)sender);
        }

        private void timerQuickDraw_Tick(object sender, EventArgs e)
        {
            countdownQuickDraw--;

            progressBar.BackColor = Color.Red;
            progressBar.Width -= progressBarInitialWidth / 100;

            if (countdownQuickDraw <= 0)
            {
                timerQuickDraw.Stop();

                isQuickDraw = false;
                countdownQuickDraw = 100;
                progressBar.Width = progressBarInitialWidth;
                game.Winner = game.Computer;

                RenderGameOver(game.Computer);
            }
        }
        #endregion

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            this.Close();
            mainMenuForm.Show();
        }
    }
}
