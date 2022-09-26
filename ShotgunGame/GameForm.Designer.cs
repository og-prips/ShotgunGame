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
            this.btnReload = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.lblPlayerShots = new System.Windows.Forms.Label();
            this.lblComputerShots = new System.Windows.Forms.Label();
            this.lblHumanScore = new System.Windows.Forms.Label();
            this.lblComputerScore = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblActionsMessage = new System.Windows.Forms.Label();
            this.lblShotsMessage = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblGameResult = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.imgHumanWeapon = new System.Windows.Forms.PictureBox();
            this.imgComputerWeapon = new System.Windows.Forms.PictureBox();
            this.imgHumanFragments = new System.Windows.Forms.PictureBox();
            this.imgComputerFragments = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanFragments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerFragments)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Black Ops One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReload.ForeColor = System.Drawing.Color.Yellow;
            this.btnReload.Location = new System.Drawing.Point(534, 65);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(116, 41);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            this.btnReload.MouseClick += new System.Windows.Forms.MouseEventHandler(this.anyButton_MouseClick);
            this.btnReload.MouseEnter += new System.EventHandler(this.anyGameButton_MouseEnter);
            this.btnReload.MouseLeave += new System.EventHandler(this.btnShoot_MouseLeave);
            // 
            // btnBlock
            // 
            this.btnBlock.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBlock.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlock.Font = new System.Drawing.Font("Black Ops One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBlock.ForeColor = System.Drawing.Color.Cyan;
            this.btnBlock.Location = new System.Drawing.Point(534, 118);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(116, 41);
            this.btnBlock.TabIndex = 1;
            this.btnBlock.Text = "BLOCK";
            this.btnBlock.UseVisualStyleBackColor = false;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            this.btnBlock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.anyButton_MouseClick);
            this.btnBlock.MouseEnter += new System.EventHandler(this.anyGameButton_MouseEnter);
            this.btnBlock.MouseLeave += new System.EventHandler(this.btnShoot_MouseLeave);
            // 
            // btnShoot
            // 
            this.btnShoot.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShoot.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnShoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoot.Font = new System.Drawing.Font("Black Ops One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShoot.ForeColor = System.Drawing.Color.Red;
            this.btnShoot.Location = new System.Drawing.Point(534, 12);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(116, 41);
            this.btnShoot.TabIndex = 2;
            this.btnShoot.Text = "SHOOT";
            this.btnShoot.UseVisualStyleBackColor = false;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            this.btnShoot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.anyButton_MouseClick);
            this.btnShoot.MouseEnter += new System.EventHandler(this.anyGameButton_MouseEnter);
            this.btnShoot.MouseLeave += new System.EventHandler(this.btnShoot_MouseLeave);
            // 
            // btnShotgun
            // 
            this.btnShotgun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShotgun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShotgun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShotgun.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnShotgun.Location = new System.Drawing.Point(502, 52);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(179, 67);
            this.btnShotgun.TabIndex = 3;
            this.btnShotgun.Text = "SHOTGUN";
            this.btnShotgun.UseVisualStyleBackColor = false;
            this.btnShotgun.Visible = false;
            this.btnShotgun.Click += new System.EventHandler(this.btnShotgun_Click);
            this.btnShotgun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.anyButton_MouseClick);
            this.btnShotgun.MouseEnter += new System.EventHandler(this.anyGameButton_MouseEnter);
            this.btnShotgun.MouseLeave += new System.EventHandler(this.btnShoot_MouseLeave);
            // 
            // lblPlayerShots
            // 
            this.lblPlayerShots.AutoSize = true;
            this.lblPlayerShots.Font = new System.Drawing.Font("Shrikhand", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerShots.ForeColor = System.Drawing.Color.White;
            this.lblPlayerShots.Location = new System.Drawing.Point(218, 81);
            this.lblPlayerShots.Name = "lblPlayerShots";
            this.lblPlayerShots.Size = new System.Drawing.Size(127, 139);
            this.lblPlayerShots.TabIndex = 4;
            this.lblPlayerShots.Text = "0";
            // 
            // lblComputerShots
            // 
            this.lblComputerShots.AutoSize = true;
            this.lblComputerShots.Font = new System.Drawing.Font("Shrikhand", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComputerShots.ForeColor = System.Drawing.Color.White;
            this.lblComputerShots.Location = new System.Drawing.Point(835, 81);
            this.lblComputerShots.Name = "lblComputerShots";
            this.lblComputerShots.Size = new System.Drawing.Size(127, 139);
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
            this.btnExit.Location = new System.Drawing.Point(564, 592);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblActionsMessage
            // 
            this.lblActionsMessage.AutoSize = true;
            this.lblActionsMessage.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActionsMessage.ForeColor = System.Drawing.Color.White;
            this.lblActionsMessage.Location = new System.Drawing.Point(333, 306);
            this.lblActionsMessage.Name = "lblActionsMessage";
            this.lblActionsMessage.Size = new System.Drawing.Size(0, 28);
            this.lblActionsMessage.TabIndex = 9;
            this.lblActionsMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(283, 502);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(109, 22);
            this.progressBar1.TabIndex = 11;
            // 
            // lblGameResult
            // 
            this.lblGameResult.AutoSize = true;
            this.lblGameResult.BackColor = System.Drawing.Color.Transparent;
            this.lblGameResult.Font = new System.Drawing.Font("Black Ops One", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGameResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblGameResult.Location = new System.Drawing.Point(436, 218);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(333, 84);
            this.lblGameResult.TabIndex = 12;
            this.lblGameResult.Text = "YOU WIN";
            this.lblGameResult.Visible = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.White;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Black Ops One", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnPlayAgain.Location = new System.Drawing.Point(502, 52);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(179, 67);
            this.btnPlayAgain.TabIndex = 13;
            this.btnPlayAgain.Text = "Play Again?";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShotgunGame.Properties.Resources.bullets1;
            this.pictureBox1.Location = new System.Drawing.Point(10, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 204);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ShotgunGame.Properties.Resources.bullets1;
            this.pictureBox2.Location = new System.Drawing.Point(953, 52);
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
            this.imgHumanFragments.Location = new System.Drawing.Point(237, 306);
            this.imgHumanFragments.Name = "imgHumanFragments";
            this.imgHumanFragments.Size = new System.Drawing.Size(108, 97);
            this.imgHumanFragments.TabIndex = 18;
            this.imgHumanFragments.TabStop = false;
            // 
            // imgComputerFragments
            // 
            this.imgComputerFragments.Location = new System.Drawing.Point(822, 306);
            this.imgComputerFragments.Name = "imgComputerFragments";
            this.imgComputerFragments.Size = new System.Drawing.Size(108, 97);
            this.imgComputerFragments.TabIndex = 19;
            this.imgComputerFragments.TabStop = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1189, 653);
            this.Controls.Add(this.imgComputerFragments);
            this.Controls.Add(this.imgHumanFragments);
            this.Controls.Add(this.imgComputerWeapon);
            this.Controls.Add(this.imgHumanWeapon);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblGameResult);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblShotsMessage);
            this.Controls.Add(this.lblActionsMessage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblComputerScore);
            this.Controls.Add(this.lblHumanScore);
            this.Controls.Add(this.lblComputerShots);
            this.Controls.Add(this.lblPlayerShots);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.btnShoot);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnReload);
            this.Name = "GameForm";
            this.Text = "0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHumanFragments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgComputerFragments)).EndInit();
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
        private Label lblActionsMessage;
        private Label lblShotsMessage;
        private ProgressBar progressBar1;
        private Label lblGameResult;
        private Button btnPlayAgain;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox imgHumanWeapon;
        private PictureBox imgComputerWeapon;
        private PictureBox imgHumanFragments;
        private PictureBox imgComputerFragments;
    }
}