using System;
using System.Drawing;
using System.Media;

namespace ai_chatbot
{//start of namespace
    internal class voice_logo_logo
    {//start of class

        //Auto get the pat directory of the project
        private string full_path = AppDomain.CurrentDomain.BaseDirectory;
        public voice_logo_logo()
        {//START OF CONSTRUCTER

            //calling sound method 
            greetings();

            //call the logo method
            asci();




        }//end of constructor

        //method to play the sound
        private void greetings()
        {//start of method

            //create an instance of the sound player class
            //check if the path is auto collected

            Console.WriteLine(full_path);

            //then replace the bin or debug
            string corrected_path = full_path.Replace(@"\bin\Debug\", @"\greet.wav");

            //check if audio file is found
            //creating an instance for the sound play claas
            //with an object name greet
            SoundPlayer greet = new SoundPlayer(corrected_path);
            //then play the sound using the play method 
            greet.Play();


        }//end of of method

        //method to turn logoto ascii
        private void asci()
        {
            //path of the logo [ where the logo is ]
            string path = full_path.Replace(@"\bin\Debug\", @"\logo.png");

            Bitmap image = new Bitmap(path);

            // Resize for better console fit
            int width = 75;
            int height = 35; //(image.Height * width) / image.Width;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            // Default color , you can set yours before this line
            string asciiChars = "@#S%?*+;:,. ";

            //start by the height
            for (int y = 0; y < resized.Height; y++)
            {
                //then width
                for (int x = 0; x < resized.Width; x++)
                {
                    //color the pixel on x and y
                    Color pixel = resized.GetPixel(x, y);

                    // Convert to grayscale
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    // Map grayscale to ASCII
                    int index = (gray * (asciiChars.Length - 1)) / 255;

                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();
            }
        }

    }//end of class

}// end of namespase