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


            //Part 2 - Life Stew Begins to Brew

            //Variables
            int RetirementAge;
            string vacationHome;
            string colorHelp;
            int birthdayMonth;

            //Age Even or Odd           
            if (userAge % 2 != 0)
            {
                // Console.WriteLine("Since your age is an odd number, you will retire in 99 years.\nSorry about your luck!");
                 RetirementAge = 99;
            }
            else
            {
                //Console.WriteLine("You have a bit of luck!  Retirement in 2 years.");
                    RetirementAge = 4;
            }


            //Determining Vacation Home
            if (userSiblings == 0)
            {
                vacationHome = "Taha'a French Polynesia";
            }
            else if(userSiblings == 1)
            {
                vacationHome = "The Cook Islands";
            }
            else if (userSiblings == 2)
            {
                vacationHome = "Napa Valley";
            }
            else if (userSiblings == 3)
            {
                vacationHome = "Negan's Compound";
            }
            else
            {
                vacationHome = "You'll be livning in a van, down by the river";
            }
            
            



        }
    }
}
