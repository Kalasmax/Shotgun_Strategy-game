using System;

namespace Shotgun.Classes
{
    public class Player 
    {
        public static int Ammo { get; set; }
        public static string Name { get; set; }

        public Player(int ammo)
        {
            Ammo = ammo;
        }

        public Player(string name)
        {
            Name = name;
        }
      
        #region Method

        public static string RandomMove()
        {
            Random random = new();
            Moves playerMove = (Moves)random.Next(1, 5);

            switch (playerMove)
            {
                case Moves.Shoot:
                    if (Ammo > 0)
                    {
                        playerMove = Moves.Shoot;
                        break;
                    }
                    else
                        goto case Moves.Reload;

                case Moves.Reload:
                    if (Ammo <= 3)
                    {
                        playerMove = Moves.Reload;
                        break;
                    }
                    else
                        goto case Moves.Shotgun;

                case Moves.Block:
                    playerMove = Moves.Block;
                    break;

                case Moves.Shotgun:
                    if (Ammo >= 3)
                    {
                        playerMove = Moves.Shotgun;
                        break;
                    }
                    else
                        goto case Moves.Shoot;

                default:
                    break;
            }

            return playerMove.ToString();
        }

        #endregion
    }
}
