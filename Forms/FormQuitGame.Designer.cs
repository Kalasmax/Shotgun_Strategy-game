
namespace Shotgun.Forms
{
    partial class FormQuitGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuitGame));
            this.lblQuit = new System.Windows.Forms.Label();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuit
            // 
            this.lblQuit.AutoSize = true;
            this.lblQuit.Location = new System.Drawing.Point(51, 22);
            this.lblQuit.Name = "lblQuit";
            this.lblQuit.Size = new System.Drawing.Size(150, 13);
            this.lblQuit.TabIndex = 0;
            this.lblQuit.Text = "Are you sure you want to quit?";
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(54, 53);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(63, 35);
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.QuitGame);
            this.btnYes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownYes);
            this.btnYes.MouseHover += new System.EventHandler(this.YesHover);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(138, 53);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(63, 35);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.BackToMenu);
            this.btnNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDownNo);
            this.btnNo.MouseHover += new System.EventHandler(this.NoHover);
            // 
            // FormQuitGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 116);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.lblQuit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(275, 155);
            this.MinimumSize = new System.Drawing.Size(275, 155);
            this.Name = "FormQuitGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shotgun - Exit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuit;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}