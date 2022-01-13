using Shotgun.Classes;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Shotgun.Forms
{
    public partial class FormQuitGame : Form
    {
        Thread thread;       

        public FormQuitGame()
        {
            InitializeComponent();
        }

        #region Events

        private void QuitGame(object sender, EventArgs e)
        {
            ResourceHandler.AudioGetter("buttonClick");
            
            Application.Exit();
        }

        private void BackToMenu(object sender, EventArgs e)
        {
            ResourceHandler.AudioGetter("buttonClick");

            this.Close();
            thread = new Thread(StartMenuFormOpen);
            thread.Start();
        }

        #endregion

        #region New form

        private void StartMenuFormOpen()
        {
            Application.Run(new FormStartMenu());
        }

        #endregion

        #region Interface

        private void YesHover(object sender, EventArgs e)
        {
            ResourceHandler.AudioGetter("MouseHover");
        }

        private void NoHover(object sender, EventArgs e)
        {
            ResourceHandler.AudioGetter("MouseHover");
        }

        #endregion

        #region Key commands

        private void KeyDownYes(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)            
                btnYes.PerformClick();          
        }

        private void KeyDownNo(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)          
                btnNo.PerformClick();            
        }

        #endregion
    }
}
