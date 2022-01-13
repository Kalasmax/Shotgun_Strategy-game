using Shotgun.Classes;
using Shotgun.Forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Shotgun
{
    public partial class FormStartMenu : Form
    {
        Thread thread;

        public FormStartMenu()
        {
            InitializeComponent();
        }

        #region Events

        private void LaunchGame(object sender, EventArgs e)
        {
            if (txtPlayerName.Text == "")           
                lblInfo.Text = ResourceHandler.MessageGetter("Error_NoInput");     
            else if (txtPlayerName.Text.Length >= 10)
            {
                lblInfo.Text = ResourceHandler.MessageGetter("Error_NameLength");
                txtPlayerName.SelectAll();
                txtPlayerName.Focus();
            }
            else
            {
                ResourceHandler.AudioGetter("launchGame");

                Player player = new Player(txtPlayerName.Text);

                this.Close();
                thread = new Thread(OpenGameForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }            
        }
        
        private void QuitGame(object sender, EventArgs e)
        {
            ResourceHandler.AudioGetter("buttonClick");         

            this.Close();
            thread = new Thread(QuitGameFormOpen);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();          
        }

        private void FaqMessage(object sender, EventArgs e)
        {
            ResourceHandler.AudioGetter("buttonClick");
            
            MessageBox.Show(ResourceHandler.MessageGetter("Faq_Game"));
        }      

        #endregion

        #region New form

        private void OpenGameForm()
        {
            Application.Run(new FormGame());
        }

        private void QuitGameFormOpen()
        {
            Application.Run(new FormQuitGame());
        }

        #endregion

        #region Interface     

        private void HoverName(object sender, EventArgs e)
        {
            lblInfo.Text = "                          Enter your name";

            ResourceHandler.AudioGetter("MouseHover");
        }

        private void HoverPlay(object sender, EventArgs e)
        {
            lblInfo.Text = "                      Enter shooting range";

            ResourceHandler.AudioGetter("MouseHover");
        }

        private void HoverQuit(object sender, EventArgs e)
        {
            lblInfo.Text = "                            Exit Shotgun";

            ResourceHandler.AudioGetter("MouseHover");
        }

        private void HoverFaq(object sender, EventArgs e)
        {
            lblInfo.Text = "                              Game faq";

            ResourceHandler.AudioGetter("MouseHover");
        }

        private void HoverForm(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }

        #endregion

        #region Key commands

        private void KeyDownName(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)           
                btnPlay.PerformClick();           
        }

        private void KeyDownPlay(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)            
                btnPlay.PerformClick();          
        }

        private void KeyDownQuit(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)           
                btnQuit.PerformClick();          
        }
        private void KeyDownFaq(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)          
                btnFaq.PerformClick();        
        }

        #endregion       
    }
}
