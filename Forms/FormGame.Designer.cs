
namespace Shotgun.Forms
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.btnShoot = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnShotgun = new System.Windows.Forms.Button();
            this.roundTimer = new System.Windows.Forms.Timer(this.components);
            this.btnFaq = new System.Windows.Forms.Button();
            this.lblCpuName = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.picBoxPlayerAmmo = new System.Windows.Forms.PictureBox();
            this.picBoxCpuAmmo = new System.Windows.Forms.PictureBox();
            this.picBoxCpu = new System.Windows.Forms.PictureBox();
            this.picBoxPlayer = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.imgListPlayer = new System.Windows.Forms.ImageList(this.components);
            this.imgListCpu = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerAmmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCpuAmmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShoot
            // 
            this.btnShoot.Location = new System.Drawing.Point(365, 474);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(75, 31);
            this.btnShoot.TabIndex = 1;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Visible = false;
            this.btnShoot.Click += new System.EventHandler(this.Shoot);
            this.btnShoot.MouseHover += new System.EventHandler(this.HoverShoot);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(448, 474);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 31);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Visible = false;
            this.btnReload.Click += new System.EventHandler(this.Reload);
            this.btnReload.MouseHover += new System.EventHandler(this.HoverReload);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(365, 511);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(75, 31);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Visible = false;
            this.btnBlock.Click += new System.EventHandler(this.Block);
            this.btnBlock.MouseHover += new System.EventHandler(this.HoverBlock);
            // 
            // btnShotgun
            // 
            this.btnShotgun.Location = new System.Drawing.Point(448, 511);
            this.btnShotgun.Name = "btnShotgun";
            this.btnShotgun.Size = new System.Drawing.Size(75, 31);
            this.btnShotgun.TabIndex = 4;
            this.btnShotgun.Text = "Shotgun";
            this.btnShotgun.UseVisualStyleBackColor = true;
            this.btnShotgun.Visible = false;
            this.btnShotgun.Click += new System.EventHandler(this.Shotgun);
            this.btnShotgun.MouseHover += new System.EventHandler(this.HoverShotgun);
            // 
            // roundTimer
            // 
            this.roundTimer.Interval = 1000;
            this.roundTimer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // btnFaq
            // 
            this.btnFaq.Location = new System.Drawing.Point(3, 3);
            this.btnFaq.Name = "btnFaq";
            this.btnFaq.Size = new System.Drawing.Size(25, 25);
            this.btnFaq.TabIndex = 6;
            this.btnFaq.Text = "?";
            this.btnFaq.UseVisualStyleBackColor = true;
            this.btnFaq.Click += new System.EventHandler(this.FaqMessage);
            this.btnFaq.MouseHover += new System.EventHandler(this.HoverFaq);
            // 
            // lblCpuName
            // 
            this.lblCpuName.AutoSize = true;
            this.lblCpuName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(173)))), ((int)(((byte)(96)))));
            this.lblCpuName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuName.Location = new System.Drawing.Point(265, 213);
            this.lblCpuName.Name = "lblCpuName";
            this.lblCpuName.Size = new System.Drawing.Size(43, 18);
            this.lblCpuName.TabIndex = 7;
            this.lblCpuName.Text = "CPU";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(181)))), ((int)(((byte)(132)))));
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(125, 480);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(0, 20);
            this.lblPlayerName.TabIndex = 8;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(181)))), ((int)(((byte)(132)))));
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(272, 378);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 25);
            this.lblTimer.TabIndex = 9;
            // 
            // picBoxPlayerAmmo
            // 
            this.picBoxPlayerAmmo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPlayerAmmo.Image")));
            this.picBoxPlayerAmmo.InitialImage = null;
            this.picBoxPlayerAmmo.Location = new System.Drawing.Point(125, 507);
            this.picBoxPlayerAmmo.Name = "picBoxPlayerAmmo";
            this.picBoxPlayerAmmo.Size = new System.Drawing.Size(75, 35);
            this.picBoxPlayerAmmo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayerAmmo.TabIndex = 11;
            this.picBoxPlayerAmmo.TabStop = false;
            // 
            // picBoxCpuAmmo
            // 
            this.picBoxCpuAmmo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCpuAmmo.Image")));
            this.picBoxCpuAmmo.InitialImage = null;
            this.picBoxCpuAmmo.Location = new System.Drawing.Point(396, 237);
            this.picBoxCpuAmmo.Name = "picBoxCpuAmmo";
            this.picBoxCpuAmmo.Size = new System.Drawing.Size(75, 35);
            this.picBoxCpuAmmo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCpuAmmo.TabIndex = 10;
            this.picBoxCpuAmmo.TabStop = false;
            // 
            // picBoxCpu
            // 
            this.picBoxCpu.BackColor = System.Drawing.SystemColors.Window;
            this.picBoxCpu.Image = ((System.Drawing.Image)(resources.GetObject("picBoxCpu.Image")));
            this.picBoxCpu.InitialImage = null;
            this.picBoxCpu.Location = new System.Drawing.Point(240, 235);
            this.picBoxCpu.Name = "picBoxCpu";
            this.picBoxCpu.Size = new System.Drawing.Size(89, 122);
            this.picBoxCpu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCpu.TabIndex = 5;
            this.picBoxCpu.TabStop = false;
            // 
            // picBoxPlayer
            // 
            this.picBoxPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxPlayer.BackgroundImage")));
            this.picBoxPlayer.InitialImage = null;
            this.picBoxPlayer.Location = new System.Drawing.Point(219, 417);
            this.picBoxPlayer.Name = "picBoxPlayer";
            this.picBoxPlayer.Size = new System.Drawing.Size(130, 130);
            this.picBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPlayer.TabIndex = 12;
            this.picBoxPlayer.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(247, 374);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 31);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "Start round";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.StartGame);
            this.btnStart.MouseHover += new System.EventHandler(this.HoverStart);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(91)))), ((int)(((byte)(67)))));
            this.lblMessage.Location = new System.Drawing.Point(382, 387);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 14;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(194)))), ((int)(((byte)(180)))));
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(8, 28);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(270, 30);
            this.txtMessage.TabIndex = 9999;
            this.txtMessage.TabStop = false;
            // 
            // imgListPlayer
            // 
            this.imgListPlayer.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListPlayer.ImageStream")));
            this.imgListPlayer.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListPlayer.Images.SetKeyName(0, "PlayerNeutral.jpg");
            this.imgListPlayer.Images.SetKeyName(1, "PlayerShoot.jpg");
            this.imgListPlayer.Images.SetKeyName(2, "PlayerReload.jpg");
            this.imgListPlayer.Images.SetKeyName(3, "PlayerBlock.jpg");
            this.imgListPlayer.Images.SetKeyName(4, "PlayerShotgun.jpg");
            this.imgListPlayer.Images.SetKeyName(5, "Player0Shell.jpg");
            this.imgListPlayer.Images.SetKeyName(6, "Player1Shell.jpg");
            this.imgListPlayer.Images.SetKeyName(7, "Player2Shell.jpg");
            this.imgListPlayer.Images.SetKeyName(8, "Player3Shell.jpg");
            this.imgListPlayer.Images.SetKeyName(9, "Player+Shell.jpg");
            // 
            // imgListCpu
            // 
            this.imgListCpu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListCpu.ImageStream")));
            this.imgListCpu.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListCpu.Images.SetKeyName(0, "CpuNeutral.jpg");
            this.imgListCpu.Images.SetKeyName(1, "CpuShoot.jpg");
            this.imgListCpu.Images.SetKeyName(2, "CpuReload.jpg");
            this.imgListCpu.Images.SetKeyName(3, "CpuBlock.jpg");
            this.imgListCpu.Images.SetKeyName(4, "CpuShotgun.jpg");
            this.imgListCpu.Images.SetKeyName(5, "Cpu0Shell.jpg");
            this.imgListCpu.Images.SetKeyName(6, "Cpu1Shell.jpg");
            this.imgListCpu.Images.SetKeyName(7, "Cpu2Shell.jpg");
            this.imgListCpu.Images.SetKeyName(8, "Cpu3Shell.jpg");
            this.imgListCpu.Images.SetKeyName(9, "Cpu+Shell.jpg");
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(531, 548);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picBoxPlayer);
            this.Controls.Add(this.picBoxPlayerAmmo);
            this.Controls.Add(this.picBoxCpuAmmo);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblCpuName);
            this.Controls.Add(this.btnFaq);
            this.Controls.Add(this.picBoxCpu);
            this.Controls.Add(this.btnShotgun);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnShoot);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(547, 587);
            this.MinimumSize = new System.Drawing.Size(547, 587);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shotgun - Game";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayerAmmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCpuAmmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnShotgun;
        private System.Windows.Forms.PictureBox picBoxCpu;
        private System.Windows.Forms.Timer roundTimer;
        private System.Windows.Forms.Button btnFaq;
        private System.Windows.Forms.Label lblCpuName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox picBoxCpuAmmo;
        private System.Windows.Forms.PictureBox picBoxPlayerAmmo;
        private System.Windows.Forms.PictureBox picBoxPlayer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ImageList imgListPlayer;
        private System.Windows.Forms.ImageList imgListCpu;
    }
}