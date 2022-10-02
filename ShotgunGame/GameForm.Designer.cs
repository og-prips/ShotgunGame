namespace ShotgunGame
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.btnReload = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.lblPlayerShots = new System.Windows.Forms.Label();
            this.lblComputerShots = new System.Windows.Forms.Label();
            this.lblHumanScore = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHumanAction = new System.Windows.Forms.Label();
            this.lblShotsMessage = new System.Windows.Forms.Label();
            this.lblGameResult = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgHumanWeapon = new System.Windows.Forms.PictureBox();
            this.imgComputerWeapon = new System.Windows.Forms.PictureBox();
            this.imgHumanFragments = new System.Windows.Forms.PictureBox();
            this.imgComputerFragments = new System.Windows.Forms.PictureBox();
            this.lblComputerAction = new System.Windows.Forms.Label();
            this.chkForceReload = new System.Windows.Forms.CheckBox();
            this.timerQuickDraw = new System.Windows.Forms.Timer(this.components);
            this.lblQuickDraw = new System.Windows.Forms.Label();
            this.imgHumanShots1 = new System.Windows.Forms.PictureBox();
            this.imgHumanShots2 = new System.Windows.Forms.PictureBox();
            this.imgHumanShots3 = new System.Windows.Forms.PictureBox();
            this.imgComputerShots1 = new System.Windows.Forms.PictureBox();
            this.imgComputerShots2 = new System.Windows.Forms.PictureBox();
            this.imgComputerShots3 = new System.Windows.Forms.PictureBox();
            this.imgHumanShotsEmpty3 = new System.Windows.Forms.PictureBox();
            this.imgHumanShotsEmpty2 = new System.Windows.Forms.PictureBox();
            this.imgHumanShotsEmpty1 = new System.Windows.Forms.PictureBox();
            this.imgComputerShotsEmpty1 = new System.Windows.Forms.PictureBox();
            this.imgComputerShotsEmpty2 = new System.Windows.Forms.PictureBox();
            this.imgComputerShotsEmpty3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanFragments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerFragments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanShots1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanShots2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanShots3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerShots1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerShots2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerShots3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanShotsEmpty3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanShotsEmpty2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanShotsEmpty1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerShotsEmpty1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerShotsEmpty2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerShotsEmpty3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReload.ForeColor = System.Drawing.Color.Yellow;
            this.btnReload.Location = new System.Drawing.Point(492, 82);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(202, 64);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            this.btnReload.MouseClick += new System.Windows.Forms.MouseEventHandler(this.anyGameButton_MouseClick);
            this.btnReload.MouseEnter += new System.EventHandler(this.anyButton_MouseEnter);
            this.btnReload.MouseLeave += new System.EventHandler(this.anyButton_MouseLeave);
            // 
            // btnBlock
            // 
            this.btnBlock.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBlock.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBlock.ForeColor = System.Drawing.Color.Cyan;
            this.btnBlock.Location = new System.Drawing.Point(492, 156);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(202, 64);
            this.btnBlock.TabIndex = 1;
            this.btnBlock.Text = "BLOCK";
            this.btnBlock.UseVisualStyleBackColor = false;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            this.btnBlock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.anyGameButton_MouseClick);
            this.btnBlock.MouseEnter += new System.EventHandler(this.anyButton_MouseEnter);
            this.btnBlock.MouseLeave += new System.EventHandler(this.anyButton_MouseLeave);
            // 
            // btnShoot
            // 
            this.btnShoot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShoot.Enabled = false;
            this.btnShoot.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnShoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShoot.ForeColor = System.Drawing.Color.Red;
            this.btnShoot.Location = new System.Drawing.Point(492, 12);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(202, 64);
            this.btnShoot.TabIndex = 2;
            this.btnShoot.Text = "SHOOT";
            this.btnShoot.UseVisualStyleBackColor = false;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            this.btnShoot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.anyGameButton_MouseClick);
            this.btnShoot.MouseEnter += new System.EventHandler(this.anyButton_MouseEnter);
            this.btnShoot.MouseLeave += new System.EventHandler(this.anyButton_MouseLeave);
            // 
            // btnShotgun
            // 
            this.btnShotgun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShotgun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShotgun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShotgun.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShotgun.ForeColor = System.Drawing.Color.Black;
            this.btnShotgun.Location = new System.Drawing.Point(492, 83);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(202, 63);
            this.btnShotgun.TabIndex = 3;
            this.btnShotgun.Text = "SHOTGUN";
            this.btnShotgun.UseVisualStyleBackColor = false;
            this.btnShotgun.Visible = false;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            this.btnShotgun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.anyGameButton_MouseClick);
            this.btnShotgun.MouseEnter += new System.EventHandler(this.anyButton_MouseEnter);
            this.btnShotgun.MouseLeave += new System.EventHandler(this.anyButton_MouseLeave);
            // 
            // lblPlayerShots
            // 
            this.lblPlayerShots.AutoSize = true;
            this.lblPlayerShots.Font = new System.Drawing.Font("Microsoft Sans Serif", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerShots.ForeColor = System.Drawing.Color.White;
            this.lblPlayerShots.Location = new System.Drawing.Point(317, 82);
            this.lblPlayerShots.Name = "lblPlayerShots";
            this.lblPlayerShots.Size = new System.Drawing.Size(98, 108);
            this.lblPlayerShots.TabIndex = 4;
            this.lblPlayerShots.Text = "0";
            // 
            // lblComputerShots
            // 
            this.lblComputerShots.AutoSize = true;
            this.lblComputerShots.Font = new System.Drawing.Font("Microsoft Sans Serif", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComputerShots.ForeColor = System.Drawing.Color.White;
            this.lblComputerShots.Location = new System.Drawing.Point(763, 82);
            this.lblComputerShots.Name = "lblComputerShots";
            this.lblComputerShots.Size = new System.Drawing.Size(98, 108);
            this.lblComputerShots.TabIndex = 5;
            this.lblComputerShots.Text = "0";
            // 
            // lblHumanScore
            // 
            this.lblHumanScore.AutoSize = true;
            this.lblHumanScore.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHumanScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHumanScore.Location = new System.Drawing.Point(10, 12);
            this.lblHumanScore.Name = "lblHumanScore";
            this.lblHumanScore.Size = new System.Drawing.Size(140, 22);
            this.lblHumanScore.TabIndex = 6;
            this.lblHumanScore.Text = "Your score: 0";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComputerScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblComputerScore.Location = new System.Drawing.Point(975, 12);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(180, 22);
            this.lblComputerScore.TabIndex = 7;
            this.lblComputerScore.Text = "Computer score: 0";
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(552, 442);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 45);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.anyButton_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.anyButton_MouseLeave);
            // 
            // lblHumanAction
            // 
            this.lblHumanAction.AutoSize = true;
            this.lblHumanAction.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHumanAction.ForeColor = System.Drawing.Color.White;
            this.lblHumanAction.Location = new System.Drawing.Point(415, 306);
            this.lblHumanAction.Name = "lblHumanAction";
            this.lblHumanAction.Size = new System.Drawing.Size(0, 28);
            this.lblHumanAction.TabIndex = 9;
            this.lblHumanAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShotsMessage
            // 
            this.lblShotsMessage.AutoSize = true;
            this.lblShotsMessage.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShotsMessage.ForeColor = System.Drawing.Color.LightGray;
            this.lblShotsMessage.Location = new System.Drawing.Point(392, 375);
            this.lblShotsMessage.Name = "lblShotsMessage";
            this.lblShotsMessage.Size = new System.Drawing.Size(0, 22);
            this.lblShotsMessage.TabIndex = 10;
            this.lblShotsMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGameResult
            // 
            this.lblGameResult.AutoSize = true;
            this.lblGameResult.BackColor = System.Drawing.Color.Transparent;
            this.lblGameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGameResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblGameResult.Location = new System.Drawing.Point(366, 183);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(466, 108);
            this.lblGameResult.TabIndex = 12;
            this.lblGameResult.Text = "YOU WIN";
            this.lblGameResult.Visible = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlayAgain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnPlayAgain.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlayAgain.Location = new System.Drawing.Point(504, 81);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(179, 67);
            this.btnPlayAgain.TabIndex = 13;
            this.btnPlayAgain.Text = "Play Again?";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            this.btnPlayAgain.MouseEnter += new System.EventHandler(this.anyButton_MouseEnter);
            this.btnPlayAgain.MouseLeave += new System.EventHandler(this.anyButton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShotgunGame.Properties.Resources.bullets1;
            this.pictureBox1.Location = new System.Drawing.Point(305, 476);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 204);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ShotgunGame.Properties.Resources.bullets1;
            this.pictureBox2.Location = new System.Drawing.Point(674, 476);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 204);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // imgHumanWeapon
            // 
            this.imgHumanWeapon.Location = new System.Drawing.Point(10, 262);
            this.imgHumanWeapon.Name = "imgHumanWeapon";
            this.imgHumanWeapon.Size = new System.Drawing.Size(202, 204);
            this.imgHumanWeapon.TabIndex = 16;
            this.imgHumanWeapon.TabStop = false;
            // 
            // imgComputerWeapon
            // 
            this.imgComputerWeapon.Location = new System.Drawing.Point(953, 262);
            this.imgComputerWeapon.Name = "imgComputerWeapon";
            this.imgComputerWeapon.Size = new System.Drawing.Size(202, 204);
            this.imgComputerWeapon.TabIndex = 17;
            this.imgComputerWeapon.TabStop = false;
            // 
            // imgHumanFragments
            // 
            this.imgHumanFragments.Location = new System.Drawing.Point(218, 306);
            this.imgHumanFragments.Name = "imgHumanFragments";
            this.imgHumanFragments.Size = new System.Drawing.Size(108, 97);
            this.imgHumanFragments.TabIndex = 18;
            this.imgHumanFragments.TabStop = false;
            // 
            // imgComputerFragments
            // 
            this.imgComputerFragments.Location = new System.Drawing.Point(839, 306);
            this.imgComputerFragments.Name = "imgComputerFragments";
            this.imgComputerFragments.Size = new System.Drawing.Size(108, 97);
            this.imgComputerFragments.TabIndex = 19;
            this.imgComputerFragments.TabStop = false;
            // 
            // lblComputerAction
            // 
            this.lblComputerAction.AutoSize = true;
            this.lblComputerAction.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComputerAction.ForeColor = System.Drawing.Color.White;
            this.lblComputerAction.Location = new System.Drawing.Point(644, 306);
            this.lblComputerAction.Name = "lblComputerAction";
            this.lblComputerAction.Size = new System.Drawing.Size(0, 28);
            this.lblComputerAction.TabIndex = 20;
            this.lblComputerAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkForceReload
            // 
            this.chkForceReload.AutoSize = true;
            this.chkForceReload.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkForceReload.Location = new System.Drawing.Point(819, 447);
            this.chkForceReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkForceReload.Name = "chkForceReload";
            this.chkForceReload.Size = new System.Drawing.Size(128, 19);
            this.chkForceReload.TabIndex = 21;
            this.chkForceReload.Text = "Force comp. reload";
            this.chkForceReload.UseVisualStyleBackColor = true;
            // 
            // timerQuickDraw
            // 
            this.timerQuickDraw.Interval = 1;
            this.timerQuickDraw.Tick += new System.EventHandler(this.timerQuickDraw_Tick);
            // 
            // lblQuickDraw
            // 
            this.lblQuickDraw.AutoSize = true;
            this.lblQuickDraw.BackColor = System.Drawing.Color.Transparent;
            this.lblQuickDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuickDraw.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuickDraw.ForeColor = System.Drawing.Color.Snow;
            this.lblQuickDraw.Location = new System.Drawing.Point(427, 309);
            this.lblQuickDraw.Name = "lblQuickDraw";
            this.lblQuickDraw.Size = new System.Drawing.Size(339, 64);
            this.lblQuickDraw.TabIndex = 22;
            this.lblQuickDraw.Text = "QUICKDRAW!!!\r\nClick anywhere on the red box";
            this.lblQuickDraw.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblQuickDraw.Visible = false;
            // 
            // imgHumanShots1
            // 
            this.imgHumanShots1.Image = ((System.Drawing.Image)(resources.GetObject("imgHumanShots1.Image")));
            this.imgHumanShots1.Location = new System.Drawing.Point(12, 37);
            this.imgHumanShots1.Name = "imgHumanShots1";
            this.imgHumanShots1.Size = new System.Drawing.Size(100, 202);
            this.imgHumanShots1.TabIndex = 23;
            this.imgHumanShots1.TabStop = false;
            this.imgHumanShots1.Visible = false;
            // 
            // imgHumanShots2
            // 
            this.imgHumanShots2.Image = ((System.Drawing.Image)(resources.GetObject("imgHumanShots2.Image")));
            this.imgHumanShots2.Location = new System.Drawing.Point(112, 37);
            this.imgHumanShots2.Name = "imgHumanShots2";
            this.imgHumanShots2.Size = new System.Drawing.Size(100, 202);
            this.imgHumanShots2.TabIndex = 24;
            this.imgHumanShots2.TabStop = false;
            this.imgHumanShots2.Visible = false;
            // 
            // imgHumanShots3
            // 
            this.imgHumanShots3.Image = ((System.Drawing.Image)(resources.GetObject("imgHumanShots3.Image")));
            this.imgHumanShots3.Location = new System.Drawing.Point(211, 37);
            this.imgHumanShots3.Name = "imgHumanShots3";
            this.imgHumanShots3.Size = new System.Drawing.Size(100, 202);
            this.imgHumanShots3.TabIndex = 25;
            this.imgHumanShots3.TabStop = false;
            this.imgHumanShots3.Visible = false;
            // 
            // imgComputerShots1
            // 
            this.imgComputerShots1.Image = ((System.Drawing.Image)(resources.GetObject("imgComputerShots1.Image")));
            this.imgComputerShots1.Location = new System.Drawing.Point(1055, 37);
            this.imgComputerShots1.Name = "imgComputerShots1";
            this.imgComputerShots1.Size = new System.Drawing.Size(100, 202);
            this.imgComputerShots1.TabIndex = 26;
            this.imgComputerShots1.TabStop = false;
            // 
            // imgComputerShots2
            // 
            this.imgComputerShots2.Image = ((System.Drawing.Image)(resources.GetObject("imgComputerShots2.Image")));
            this.imgComputerShots2.Location = new System.Drawing.Point(956, 37);
            this.imgComputerShots2.Name = "imgComputerShots2";
            this.imgComputerShots2.Size = new System.Drawing.Size(100, 202);
            this.imgComputerShots2.TabIndex = 27;
            this.imgComputerShots2.TabStop = false;
            // 
            // imgComputerShots3
            // 
            this.imgComputerShots3.Image = global::ShotgunGame.Properties.Resources.one_bullet;
            this.imgComputerShots3.Location = new System.Drawing.Point(861, 37);
            this.imgComputerShots3.Name = "imgComputerShots3";
            this.imgComputerShots3.Size = new System.Drawing.Size(100, 202);
            this.imgComputerShots3.TabIndex = 28;
            this.imgComputerShots3.TabStop = false;
            // 
            // imgHumanShotsEmpty3
            // 
            this.imgHumanShotsEmpty3.Image = ((System.Drawing.Image)(resources.GetObject("imgHumanShotsEmpty3.Image")));
            this.imgHumanShotsEmpty3.Location = new System.Drawing.Point(211, 37);
            this.imgHumanShotsEmpty3.Name = "imgHumanShotsEmpty3";
            this.imgHumanShotsEmpty3.Size = new System.Drawing.Size(100, 202);
            this.imgHumanShotsEmpty3.TabIndex = 31;
            this.imgHumanShotsEmpty3.TabStop = false;
            // 
            // imgHumanShotsEmpty2
            // 
            this.imgHumanShotsEmpty2.Image = ((System.Drawing.Image)(resources.GetObject("imgHumanShotsEmpty2.Image")));
            this.imgHumanShotsEmpty2.Location = new System.Drawing.Point(112, 37);
            this.imgHumanShotsEmpty2.Name = "imgHumanShotsEmpty2";
            this.imgHumanShotsEmpty2.Size = new System.Drawing.Size(100, 202);
            this.imgHumanShotsEmpty2.TabIndex = 30;
            this.imgHumanShotsEmpty2.TabStop = false;
            // 
            // imgHumanShotsEmpty1
            // 
            this.imgHumanShotsEmpty1.Image = global::ShotgunGame.Properties.Resources.one_bullet_bw;
            this.imgHumanShotsEmpty1.Location = new System.Drawing.Point(12, 37);
            this.imgHumanShotsEmpty1.Name = "imgHumanShotsEmpty1";
            this.imgHumanShotsEmpty1.Size = new System.Drawing.Size(100, 202);
            this.imgHumanShotsEmpty1.TabIndex = 29;
            this.imgHumanShotsEmpty1.TabStop = false;
            // 
            // imgComputerShotsEmpty1
            // 
            this.imgComputerShotsEmpty1.Image = ((System.Drawing.Image)(resources.GetObject("imgComputerShotsEmpty1.Image")));
            this.imgComputerShotsEmpty1.Location = new System.Drawing.Point(1055, 37);
            this.imgComputerShotsEmpty1.Name = "imgComputerShotsEmpty1";
            this.imgComputerShotsEmpty1.Size = new System.Drawing.Size(100, 202);
            this.imgComputerShotsEmpty1.TabIndex = 34;
            this.imgComputerShotsEmpty1.TabStop = false;
            // 
            // imgComputerShotsEmpty2
            // 
            this.imgComputerShotsEmpty2.Image = ((System.Drawing.Image)(resources.GetObject("imgComputerShotsEmpty2.Image")));
            this.imgComputerShotsEmpty2.Location = new System.Drawing.Point(956, 37);
            this.imgComputerShotsEmpty2.Name = "imgComputerShotsEmpty2";
            this.imgComputerShotsEmpty2.Size = new System.Drawing.Size(100, 202);
            this.imgComputerShotsEmpty2.TabIndex = 33;
            this.imgComputerShotsEmpty2.TabStop = false;
            // 
            // imgComputerShotsEmpty3
            // 
            this.imgComputerShotsEmpty3.Image = global::ShotgunGame.Properties.Resources.one_bullet_bw;
            this.imgComputerShotsEmpty3.Location = new System.Drawing.Point(856, 37);
            this.imgComputerShotsEmpty3.Name = "imgComputerShotsEmpty3";
            this.imgComputerShotsEmpty3.Size = new System.Drawing.Size(100, 202);
            this.imgComputerShotsEmpty3.TabIndex = 32;
            this.imgComputerShotsEmpty3.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1189, 692);
            this.Controls.Add(this.imgComputerShotsEmpty1);
            this.Controls.Add(this.imgComputerShotsEmpty2);
            this.Controls.Add(this.imgComputerShotsEmpty3);
            this.Controls.Add(this.imgHumanShotsEmpty3);
            this.Controls.Add(this.imgHumanShotsEmpty2);
            this.Controls.Add(this.imgHumanShotsEmpty1);
            this.Controls.Add(this.imgComputerShots3);
            this.Controls.Add(this.imgComputerShots2);
            this.Controls.Add(this.imgComputerShots1);
            this.Controls.Add(this.imgHumanShots3);
            this.Controls.Add(this.imgHumanShots2);
            this.Controls.Add(this.imgHumanShots1);
            this.Controls.Add(this.lblQuickDraw);
            this.Controls.Add(this.chkForceReload);
            this.Controls.Add(this.lblComputerAction);
            this.Controls.Add(this.imgComputerFragments);
            this.Controls.Add(this.imgHumanFragments);
            this.Controls.Add(this.imgComputerWeapon);
            this.Controls.Add(this.imgHumanWeapon);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblGameResult);
            this.Controls.Add(this.lblShotsMessage);
            this.Controls.Add(this.lblHumanAction);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblHumanScore);
            this.Controls.Add(this.lblComputerShots);
            this.Controls.Add(this.lblPlayerShots);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnReload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.Text = "Shotgun";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanFragments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerFragments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanShots1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanShots2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanShots3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerShots1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerShots2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerShots3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanShotsEmpty3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanShotsEmpty2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanShotsEmpty1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerShotsEmpty1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerShotsEmpty2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerShotsEmpty3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnReload;
        private Button btnBlock;
        private Button btnShoot;
        private Button btnShotgun;
        private Label lblPlayerShots;
        private Label lblComputerShots;
        private Label lblHumanScore;
        private Label lblComputerScore;
        private Button btnExit;
        private Label lblHumanAction;
        private Label lblShotsMessage;
        private Label lblGameResult;
        private Button btnPlayAgain;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox imgHumanWeapon;
        private PictureBox imgComputerWeapon;
        private PictureBox imgHumanFragments;
        private PictureBox imgComputerFragments;
        private Label lblComputerAction;
        private CheckBox chkForceReload;
        private System.Windows.Forms.Timer timerQuickDraw;
        private Label lblQuickDraw;
        private PictureBox imgHumanShots1;
        private PictureBox imgHumanShots2;
        private PictureBox imgHumanShots3;
        private PictureBox imgComputerShots1;
        private PictureBox imgComputerShots2;
        private PictureBox imgComputerShots3;
        private PictureBox imgHumanShotsEmpty3;
        private PictureBox imgHumanShotsEmpty2;
        private PictureBox imgHumanShotsEmpty1;
        private PictureBox imgComputerShotsEmpty1;
        private PictureBox imgComputerShotsEmpty2;
        private PictureBox imgComputerShotsEmpty3;
    }
}