
namespace Shotgun
{
    partial class FormStartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartMenu));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnFaq = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(110, 73);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(165, 35);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.LaunchGame);
            this.btnPlay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownPlay);
            this.btnPlay.MouseHover += new System.EventHandler(this.HoverPlay);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(110, 124);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(165, 35);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.QuitGame);
            this.btnQuit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownQuit);
            this.btnQuit.MouseHover += new System.EventHandler(this.HoverQuit);
            // 
            // btnFaq
            // 
            this.btnFaq.Location = new System.Drawing.Point(5, 5);
            this.btnFaq.Name = "btnFaq";
            this.btnFaq.Size = new System.Drawing.Size(25, 25);
            this.btnFaq.TabIndex = 3;
            this.btnFaq.Text = "?";
            this.btnFaq.UseVisualStyleBackColor = true;
            this.btnFaq.Click += new System.EventHandler(this.FaqMessage);
            this.btnFaq.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownFaq);
            this.btnFaq.MouseHover += new System.EventHandler(this.HoverFaq);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(76, 176);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 13);
            this.lblInfo.TabIndex = 4;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(110, 37);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(165, 20);
            this.txtPlayerName.TabIndex = 5;
            this.txtPlayerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownName);
            this.txtPlayerName.MouseHover += new System.EventHandler(this.HoverName);
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(107, 21);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(68, 13);
            this.lblPlayerName.TabIndex = 6;
            this.lblPlayerName.Text = "Player name:";
            // 
            // FormStartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnFaq);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 250);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "FormStartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shotgun - Menu";
            this.MouseHover += new System.EventHandler(this.HoverForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnFaq;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
    }
}

