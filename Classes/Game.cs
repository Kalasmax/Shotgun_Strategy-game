namespace Shotgun.Classes
{
    public enum Moves
    {
        Shoot = 1,
        Reload = 2,
        Block = 3,
        Shotgun = 4
    }

    public class Game 
    {
        public string Winner { get; set; }
        public string PlayerMove { get; set; }
        public string CpuMove { get; set; }     

        #region Method 

        public string WinnerResolver()
        {         
            string message = "";                             
          
            if (PlayerMove == null)
            {
                PlayerMove = Player.RandomMove();
            }

            CpuMove = Cpu.RandomMove();

            switch (PlayerMove, CpuMove)
            {
                case ("Shoot", "Shoot"):
                    Player.Ammo--;
                    Cpu.Ammo--;
                    Winner = "Tie";
                    message = "Tie_Message";
                    break;

                case ("Shoot", "Reload"):
                    Player.Ammo--;
                    Winner = "Player";
                    message = "Win_Message";
                    break;

                case ("Shoot", "Block"):
                    Player.Ammo--;
                    Winner = "Ongoing";
                    message = "CpuBlock_Message";
                    break;

                case ("Shoot", "Shotgun"):
                    Player.Ammo--;
                    Winner = "Tie";
                    message = "Tie_Message";
                    break;

                case ("Reload", "Shoot"):
                    Player.Ammo++;
                    Cpu.Ammo--;
                    Winner = "Cpu";
                    message = "Loss_Message";
                    break;

                case ("Reload", "Reload"):
                    Player.Ammo++;
                    Cpu.Ammo++;
                    Winner = "Ongoing";
                    message = "ReloadReload_Message";
                    break;

                case ("Reload", "Block"):
                    Player.Ammo++;
                    Winner = "Ongoing";
                    message = "ReloadBlock_Message";
                    break; 

                case ("Reload", "Shotgun"):
                    Player.Ammo++;
                    Winner = "Cpu";
                    message = "Loss_Message";
                    break;

                case ("Block", "Shoot"):
                    Cpu.Ammo--;
                    Winner = "Ongoing";
                    message = "PlayerBlock_Message";
                    break;

                case ("Block", "Reload"):
                    Cpu.Ammo++;
                    Winner = "Ongoing";
                    message = "BlockReload_Message";
                    break;

                case ("Block", "Block"):
                    Winner = "Ongoing";
                    message = "BlockBlock_Message";
                    break;

                case ("Block", "Shotgun"):
                    Winner = "Cpu";
                    message = "Loss_Message";
                    break;

                case ("Shotgun", "Shoot"):
                    Cpu.Ammo--;
                    Winner = "Tie";
                    message = "Tie_Message";
                    break;

                case ("Shotgun", "Reload"):
                    Cpu.Ammo++;
                    Winner = "Player";
                    message = "Win_Message";
                    break;

                case ("Shotgun", "Block"):
                    Winner = "Player";
                    message = "Win_Message";
                    break;

                case ("Shotgun", "Shotgun"):
                    Winner = "Tie";
                    message = "Tie_Message";
                    break;

                default:                 
                    break;
            }
            
            return message;
        }

        #endregion
    }
}
