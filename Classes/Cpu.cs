using System;

namespace Shotgun.Classes
{
    public class Cpu
    {
        public static int Ammo { get; set; }              

        public Cpu(int ammo)
        {
            Ammo = ammo;
        }

        #region Method

        public static string RandomMove()
        {
            Random random = new();
            Moves cpuMove = (Moves)random.Next(1, 5);

            switch (cpuMove)
            {
                case Moves.Shoot:
                    if (Ammo > 0)
                    {
                        cpuMove = Moves.Shoot;
                        break;
                    }                                         
                    else                   
                        goto case Moves.Reload;
                   
                case Moves.Reload:
                    if (Ammo <= 3)
                    {
                        cpuMove = Moves.Reload;
                        break;
                    }
                    else                   
                        goto case Moves.Shotgun;
                    
                case Moves.Block:
                    cpuMove = Moves.Block;
                    break;

                case Moves.Shotgun:
                    if (Ammo >= 3)
                    {
                        cpuMove = Moves.Shotgun;
                        break;
                    }
                    else                   
                        goto case Moves.Shoot;
                    
                default:
                    break;
            }           

            return cpuMove.ToString();
        }

        #endregion
    }
}
