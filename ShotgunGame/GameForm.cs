using System.Diagnostics;

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

        private void GameOver(Player winner)
        {

        }

        public static void SetShotsMessage(int humanShotDifference, int computerShotDifference)
        {
            _shotsMessage = $"You get: {humanShotDifference}    Computer gets: {computerShotDifference}";
        }

        private void SetLabel(Label label, string text, bool visible)
        {
            label.Text = text;
            label.Visible = visible;
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
            var previousHumanShots = game.Human.Shots;
            var previousComputerShots = game.Computer.Shots;

            game.PlayGame();
            lblActionsMessage.Text = $"You choose: {game.Human.Choice.ToString().ToUpper()}   Computer chooses: {game.Computer.Choice.ToString().ToUpper()}";

            if (game.Human.ShotgunAvailable() && !game.Computer.ShotgunAvailable())
            {
                btnShotgun.Visible = true;
                btnShoot.Enabled = false;
                btnReload.Enabled = false;
                btnBlock.Enabled = false;
            }
            else if (game.Human.ShotgunAvailable() && game.Computer.ShotgunAvailable())
            {
                QuickDraw();
            }

            Debug.Print($"----- Human choice: {game.Human.Choice} Computer choice: {game.Computer.Choice} -----");

            if (game.CheckForWinner(game.Human, game.Computer) == game.Human)
            {
                Debug.Print("----- Human WIN -----");
                game.Human.Score += 1;
                
                SetLabel(lblGameResult, "YOU WIN", true);

                game.ResetGame();

                btnShotgun.Visible = false;
                btnShoot.Enabled = true;
                btnReload.Enabled = true;
                btnBlock.Enabled = true;
                lblShotsMessage.Text = string.Empty;
            }
            else if (game.CheckForWinner(game.Human, game.Computer) == game.Computer)
            {
                Debug.Print("----- Computer WIN -----");
                game.Computer.Score += 1;
                
                SetLabel(lblGameResult, "YOU LOSE", true, Color.Red);

                game.ResetGame();

                btnShotgun.Visible = false;
                btnShoot.Enabled = true;
                btnReload.Enabled = true;
                btnBlock.Enabled = true;
                lblShotsMessage.Text = string.Empty;
            }
            else
            {
                lblShotsMessage.Text = _shotsMessage;
            }

            lblHumanScore.Text = $"Your score: {game.Human.Score.ToString()}";
            lblComputerScore.Text = $"Computer score: {game.Computer.Score.ToString()}";
            lblPlayerShots.Text = game.Human.Shots.ToString();
            lblComputerShots.Text = game.Computer.Shots.ToString();

            Debug.Print($"----- Human shots: {game.Human.Shots} ///// Computer shots: {game.Computer.Shots} -----");
        }

        private void QuickDraw()
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
