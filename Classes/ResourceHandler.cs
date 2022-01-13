using System.Media;
using System.Resources;

namespace Shotgun.Classes
{
    public static class ResourceHandler
    {
        static readonly string _filePath = ".\\Resources.resx";
        static readonly ResXResourceSet resource = new(_filePath);    
        static SoundPlayer soundPlayer = new();

        #region Messages

        public static string MessageGetter(string messageKey)
        {          
            return resource.GetString(messageKey);
        }

        #endregion

        #region Audio

        public static void AudioGetter(string audioKey)
        {
            if (audioKey == null)
            {
                soundPlayer = new SoundPlayer("Tick.wav");
                soundPlayer.Play();
            }
            else if (audioKey == "MouseHover")
            {
                soundPlayer = new SoundPlayer(audioKey + ".wav");
                soundPlayer.Play();
            }
            else
            {
                soundPlayer = new SoundPlayer(audioKey + ".wav");
                soundPlayer.PlaySync();
            }
        }

        #endregion

        #region Images

        public static int MoveImageGetter(string type, string imageKey)
        {
            int imageIndex = 0;

            if (type == "Player")
            {
                switch (imageKey)
                {
                    case ("Neutral"):                     
                        imageIndex = 0;                       
                        break;

                    case ("Shoot"):                       
                        imageIndex = 1;
                        break;

                    case ("Reload"):                       
                        imageIndex = 2;                       
                        break;

                    case ("Block"):                       
                        imageIndex = 3;                       
                        break;

                    case ("Shotgun"):                       
                        imageIndex = 4;                        
                        break;

                    default:
                        break;
                }
            }
            else if (type == "Cpu")
            {
                switch (imageKey)
                {
                    case ("Neutral"):                        
                        imageIndex = 0;                        
                        break;

                    case ("Shoot"):                       
                        imageIndex = 1;                       
                        break;

                    case ("Reload"):                       
                        imageIndex = 2;                       
                        break;

                    case ("Block"):                      
                        imageIndex = 3;                      
                        break;

                    case ("Shotgun"):                        
                        imageIndex = 4;                       
                        break;

                    default:
                        break;
                }
            }

            return imageIndex;
        }

        public static int AmmoImageGetter(string type, int pictureKey)
        {
            int pictureIndex = 0;

            if (type == "Player")
            {
                switch (pictureKey)
                {
                    case 0:
                        pictureIndex = 5;
                        break;

                    case 1:
                        pictureIndex = 6;
                        break;

                    case 2:
                        pictureIndex = 7;
                        break;

                    case 3:
                        pictureIndex = 8;
                        break;

                    case >= 4:
                        pictureIndex = 9;
                        break;

                    default:
                        break;
                }
            }
            else if (type == "Cpu")
            {
                switch (pictureKey)
                {
                    case 0:
                        pictureIndex = 5;
                        break;

                    case 1:
                        pictureIndex = 6;
                        break;

                    case 2:
                        pictureIndex = 7;
                        break;

                    case 3:
                        pictureIndex = 8;
                        break;

                    case >= 4:
                        pictureIndex = 9;
                        break;

                    default:
                        break;
                }
            }

            return pictureIndex;
        }

        #endregion
    }
}

