using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ai_chatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create and run voice + logo
            new voice_logo_logo();

            // Create object to handle user input
            prompt_user collect_name = new prompt_user();

            // Display welcome message
            collect_name.DisplayWelcomeMessage();

            // Ask for user name
            collect_name.asking_name();

            // Create chatbot object
            chats chatting = new chats();

            // Get user name
            string name = collect_name.return_name();

            // Start chatting
            chatting.ai_chats(name);
        }
    }
}