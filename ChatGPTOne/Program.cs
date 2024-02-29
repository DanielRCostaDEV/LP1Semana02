using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Variables
            string question, response;

            // Ask user a question
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            //Questions and responses
            switch (question)
            {
                case "Do you like git bash?":
                    response = "What do you think?";
                    break;
                
                case "Will I get a good grade on this assignment?":
                    response = "Lmao you wish";
                    break;
                
                case "Should I drop out of the course?":
                    response = "Maybe, but first find out who Gualter is.";
                    break;
                
                case "Who is Gualter?":
                    response = "@DiogoDeAndrade";
                    break;

                case "EXIT":
                    resposta = "Goodbye";
                    break;  
                

            }

            // respond
            Console.WriteLine(response);
        }
    }
}
