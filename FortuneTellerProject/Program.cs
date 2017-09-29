using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cold Open
            Console.WriteLine("Greetings from The All Knowing.\n\nYou want some insight and I'll need some details.\n***Disclaimer***\nIf unsatisfied upon completion, customer service will instruct you to try again and lie.");

            //Gather Personal Details
            Console.WriteLine("\n\nRather than referring to you as Baba Booey, Please enter your First Name:");
            string userFirst = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("\nPlease enter your Last Name:");
            string userLast = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("\nPlease enter your age:");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPlease enter the number representing your birth month:");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat ROYGBIV is your favorite:\nIf you do not know ROYGBIV, enter \"Help\"");
            string favoriteColor = Console.ReadLine().ToLower().Trim();

            Console.WriteLine("\nPlease enter the number of siblings you have:");
            int userSiblings = int.Parse(Console.ReadLine());




        }
    }
}
