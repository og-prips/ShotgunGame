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
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReload.ForeColor = System.Drawing.Color.Yellow;
            this.btnReload.Location = new System.Drawing.Point(610, 87);
            this.btnReload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(133, 55);
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
            this.btnBlock.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBlock.ForeColor = System.Drawing.Color.Cyan;
            this.btnBlock.Location = new System.Drawing.Point(610, 157);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(133, 55);
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
            this.btnShoot.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShoot.ForeColor = System.Drawing.Color.Red;
            this.btnShoot.Location = new System.Drawing.Point(610, 16);
            this.btnShoot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(133, 55);
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
            this.btnShotgun.Location = new System.Drawing.Point(577, 259);
            this.btnShotgun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(205, 89);
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
            this.lblPlayerShots.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayerShots.ForeColor = System.Drawing.Color.White;
            this.lblPlayerShots.Location = new System.Drawing.Point(231, 95);
            this.lblPlayerShots.Name = "lblPlayerShots";
            this.lblPlayerShots.Size = new System.Drawing.Size(0, 32);
            this.lblPlayerShots.TabIndex = 4;
            // 
            // lblComputerShots
            // 
            this.lblComputerShots.AutoSize = true;
            this.lblComputerShots.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComputerShots.ForeColor = System.Drawing.Color.White;
            this.lblComputerShots.Location = new System.Drawing.Point(1016, 108);
            this.lblComputerShots.Name = "lblComputerShots";
            this.lblComputerShots.Size = new System.Drawing.Size(0, 32);
            this.lblComputerShots.TabIndex = 5;
            // 
            // lblHumanScore
            // 
            this.lblHumanScore.AutoSize = true;
            this.lblHumanScore.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHumanScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHumanScore.Location = new System.Drawing.Point(12, 16);
            this.lblHumanScore.Name = "lblHumanScore";
            this.lblHumanScore.Size = new System.Drawing.Size(181, 28);
            this.lblHumanScore.TabIndex = 6;
            this.lblHumanScore.Text = "Your score: 0";
            // 
            // lblComputerScore
            // 
            this.lblComputerScore.AutoSize = true;
            this.lblComputerScore.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComputerScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblComputerScore.Location = new System.Drawing.Point(1114, 16);
            this.lblComputerScore.Name = "lblComputerScore";
            this.lblComputerScore.Size = new System.Drawing.Size(233, 28);
            this.lblComputerScore.TabIndex = 7;
            this.lblComputerScore.Text = "Computer score: 0";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(645, 790);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 31);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblActionsMessage
            // 
            this.lblActionsMessage.AutoSize = true;
            this.lblActionsMessage.ForeColor = System.Drawing.Color.White;
            this.lblActionsMessage.Location = new System.Drawing.Point(520, 403);
            this.lblActionsMessage.Name = "lblActionsMessage";
            this.lblActionsMessage.Size = new System.Drawing.Size(0, 20);
            this.lblActionsMessage.TabIndex = 9;
            this.lblActionsMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShotsMessage
            // 
            this.lblShotsMessage.AutoSize = true;
            this.lblShotsMessage.ForeColor = System.Drawing.Color.White;
            this.lblShotsMessage.Location = new System.Drawing.Point(498, 498);
            this.lblShotsMessage.Name = "lblShotsMessage";
            this.lblShotsMessage.Size = new System.Drawing.Size(50, 20);
            this.lblShotsMessage.TabIndex = 10;
            this.lblShotsMessage.Text = "label1";
            this.lblShotsMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(256, 614);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(125, 29);
            this.progressBar1.TabIndex = 11;
            // 
            // lblGameResult
            // 
            this.lblGameResult.AutoSize = true;
            this.lblGameResult.BackColor = System.Drawing.Color.Transparent;
            this.lblGameResult.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGameResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblGameResult.Location = new System.Drawing.Point(480, 259);
            this.lblGameResult.Name = "lblGameResult";
            this.lblGameResult.Size = new System.Drawing.Size(392, 98);
            this.lblGameResult.TabIndex = 12;
            this.lblGameResult.Text = "YOU WIN";
            this.lblGameResult.Visible = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1359, 871);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
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
    }
}