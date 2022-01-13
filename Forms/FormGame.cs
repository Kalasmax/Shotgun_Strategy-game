using Shotgun.Classes;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Shotgun.Forms
{
    public partial class FormGame : Form
    {
        Thread thread;
        Game game;
        Player player;
        Cpu cpu;

        int secondsPerRound = 6;       

        public FormGame()
        {
            InitializeComponent();

            game = new Game();
            player = new Player(0);
            cpu = new Cpu(0);
            
            lblPlayerName.Text = Player.Name;
        }

        #region Events

        private void StartGame(object sender, EventArgs e)
        {
            ResourceHandler.AudioGetter("buttonClick");
            
            ControlToggler("start");
            RoundResetter("imagereset");
        }
                                                                                                        
        private void TimerTick(object sender, EventArgs e)
        {
            secondsPerRound--;
            lblTimer.Text = Convert.ToString(secondsPerRound);
            ResourceHandler.AudioGetter("Tick");

            if (secondsPerRound < 1)
            {
                ResourceHandler.AudioGetter(game.PlayerMove);

                string message = game.WinnerResolver();
                txtMessage.Text = ResourceHandler.MessageGetter(message);

                ImageMoveSetter();
                ImageAmmoSetter();   
                             
                if (game.Winner == "Tie" || game.Winner == "Ongoing")                
                    RoundResetter("reset");             
                else
                {
                    RoundResetter("reset");
                    WinnerDisplayer(game.Winner);
                }              
            }
        }
           
        private void Shoot(object sender, EventArgs e)
        {
            if (Player.Ammo >= 1)                                                      
                game.PlayerMove = "Shoot";                                                            
            
            else           
                lblMessage.Text = ResourceHandler.MessageGetter("Ammo_Message");                                  
        }

        private void Reload(object sender, EventArgs e)
        {
            game.PlayerMove = "Reload";          
            lblMessage.Text = string.Empty;          
        }

        private void Block(object sender, EventArgs e)
        {
            game.PlayerMove = "Block";         
            lblMessage.Text = string.Empty;
        }

        private void Shotgun(object sender, EventArgs e)
        {
            if (Player.Ammo >= 3)           
                game.PlayerMove = "Shotgun";                                                                                               
            
            else            
                lblMessage.Text = ResourceHandler.MessageGetter("Ammo_Message");           
        }

        private void FaqMessage(object sender, EventArgs e)
        {
            ResourceHandler.AudioGetter("buttonClick");
            MessageBox.Show(ResourceHandler.MessageGetter("Faq_Game"));
        }

        #endregion

        #region Methods

        public void ImageMoveSetter()
        {
            int playerIndex = ResourceHandler.MoveImageGetter("Player", game.PlayerMove);
            picBoxPlayer.Image = imgListPlayer.Images[playerIndex];

            int cpuIndex = ResourceHandler.MoveImageGetter("Cpu", game.CpuMove);
            picBoxCpu.Image = imgListCpu.Images[cpuIndex];
        }

        public void ImageAmmoSetter()
        {
            int playerIndex = ResourceHandler.AmmoImageGetter("Player", Player.Ammo);
            picBoxPlayerAmmo.Image = imgListPlayer.Images[playerIndex];

            int cpuIndex = ResourceHandler.AmmoImageGetter("Cpu", Cpu.Ammo);
            picBoxCpuAmmo.Image = imgListCpu.Images[cpuIndex];
        }

        private void RoundResetter(string choice)
        {
            secondsPerRound = 6;

            if (choice == "imagereset")
            {
                picBoxPlayer.Image = imgListPlayer.Images[0];

                picBoxCpu.Image = imgListCpu.Images[0];
            }
            else if(choice == "start" || choice == "reset")           
                ControlToggler(choice);                   
        }

        private void ControlToggler(string choice)
        {
            if (choice == "start")
            {
                btnStart.Visible = false; roundTimer.Enabled = true; lblTimer.Visible = true;

                btnShoot.Visible = true; btnReload.Visible = true;
                btnBlock.Visible = true; btnShotgun.Visible = true;

                txtMessage.Text = string.Empty;
            }
            else if (choice == "reset")
            {
                roundTimer.Enabled = false; lblTimer.Visible = false; btnStart.Visible = true;

                btnShoot.Visible = false; btnReload.Visible = false;
                btnBlock.Visible = false; btnShotgun.Visible = false;

                lblMessage.Text = string.Empty;
            }
        }

        public void WinnerDisplayer(string gameWinner)
        {
            if (gameWinner == "Player")
            {
                ResourceHandler.AudioGetter("win");
                gameWinner = Player.Name;
            }
            else if (gameWinner == "Cpu")
            {
                ResourceHandler.AudioGetter("lose");
            }

            string title = "Shotgun - End";
            string message = $"{gameWinner} won! Play again?";

            var answer = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
            {
                ResourceHandler.AudioGetter("launchGame");

                this.Close();
                thread = new Thread(OpenGameForm);
                thread.Start();
            }
            else
            {
                ResourceHandler.AudioGetter("buttonClick");
                Application.Exit();
            }
        }

        #endregion

        #region New form
        private void OpenGameForm()
        {
            Application.Run(new FormGame());
        }

        #endregion

        #region Interface

        private void HoverStart(object sender, EventArgs e)
        {
            ResourceHandler.AudioGetter("MouseHover");
        }

        private void HoverShoot(object sender, EventArgs e)
        {
            ResourceHandler.AudioGetter("MouseHover");          
        }
  
        private void HoverReload(object sender, EventArgs e)
        {
            ResourceHandler.AudioGetter("MouseHover");
        }

        private void HoverBlock(object sender, EventArgs e)
        {
            ResourceHandler.AudioGetter("MouseHover");
        }

        private void HoverShotgun(object sender, EventArgs e)
        {
            ResourceHandler.AudioGetter("MouseHover");
        }

        private void HoverFaq(object sender, EventArgs e)
        {
            ResourceHandler.AudioGetter("MouseHover");
        }

        #endregion
       
    }
}
