using System;

namespace ai_chatbot
{
    public class prompt_user
    {
        // Store user name
        private string name = string.Empty;

        // Display welcome banner
        public void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==============================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("        Welcome to BeastBug Chatbot");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==============================================");
            Console.ResetColor();
        }

        // Ask user for name
        public void asking_name()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("ChatBot: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Please enter your name...");
            Console.ResetColor();

            do
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("User: ");
                Console.ForegroundColor = ConsoleColor.Gray;

                name = Console.ReadLine();

                Console.ResetColor();

            } while (!check_name());
        }

        // This method handles chatbot responses
        // Validate name input
        private Boolean check_name()
        {
            if (name == "")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ChatBot: Please enter a valid name.");
                Console.ResetColor();
                return false;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("ChatBot: Hey " + name + ", how can I help you?");
                Console.ResetColor();
                return true;
            }
        }

        // Return user name
        public string return_name()
        {
            return name;
        }
    }
}