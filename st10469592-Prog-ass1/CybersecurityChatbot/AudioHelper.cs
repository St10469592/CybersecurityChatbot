using System;
using System.Media;

namespace CybersecurityChatbot
{
    public class AudioHelper
    {//start of class

        private string full_path = AppDomain.CurrentDomain.BaseDirectory;

        // method to play the WAV greeting file when the app starts
        public void PlayGreeting()
        {//start of PlayGreeting method

            try
            {//start of try 

                Console.WriteLine(full_path);

                string correct_path = full_path.Replace(@"bin\Debug\", "greet.wav");
                Console.WriteLine(correct_path);

                // create an instance of SoundPlayer
                SoundPlayer greet = new SoundPlayer(correct_path);

                // play the sound 
                greet.PlaySync();

            }//end of try
            catch (Exception ex)
            {//start of catch

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" (Audio Error): " + ex.Message);
                Console.ResetColor();

            }//end of catch

        }//end of PlayGreeting method


    }//end of class

}//end of namespace