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
            string userFirst = Console.ReadLine().Trim();

            Console.WriteLine("\nPlease enter your Last Name:");
            string userLast = Console.ReadLine().Trim();

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
            int retirementAge;
            string vacationHome;
            string bankAccount;
            //string dreamMachine;
            string dreamMachine;

            //Age Even or Odd           
            if (userAge % 2 != 0)
            {
                // Console.WriteLine("Since your age is an odd number, you will retire in 99 years.\nSorry about your luck!");
                 retirementAge = 19;
            }
            else
            {
                //Console.WriteLine("You have a bit of luck!  Retirement in 2 years.");
                    retirementAge = 4;
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

            //Color Selection

            if (favoriteColor == "Help")
            {
                Console.WriteLine("Choose between Red, Orange, Yellow, Green, Blue, Indigo, or Violet");
                favoriteColor = Console.ReadLine().Trim().ToLower();
            }

            if (favoriteColor == "red")
            {
                dreamMachine = "Iron Man Suit";
            }
            else if (favoriteColor == "orange")
            {
                dreamMachine = "Batman's Toumbler";
            }
            else if (favoriteColor == "yellow")
            {
                dreamMachine = "Matt Foley's Van with a water view";
            }
            else if (favoriteColor == "green")
            {
                dreamMachine = "Jesse James Chopper";
            }
            else if (favoriteColor == "blue")
            {
                dreamMachine = "Doc Brown's DeLorean";
            }
            else if (favoriteColor == "indigo")
            {
                dreamMachine = "You have to train a wild elephant to ride, good luck";
            }
            else if (favoriteColor == "violet")
            {
                dreamMachine = "The Wicked Witch's Broom";
            }
           else
            {
              Console.WriteLine("Choose between Red, Orange, Yellow, Green, Blue, Indigo, or Violet");
              favoriteColor = Console.ReadLine().Trim().ToLower();
            }

            //
            //
            //

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                bankAccount = "$2,000,000";
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                bankAccount = "1 Billion Dollars";
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                bankAccount = "Do not pass and do not collect $200";
            }
            else
            {
                bankAccount = "$0.00, Zero Point Zero";
            }

            //Part 3

            Console.WriteLine("Your Fortune Awaits: ");
            Console.WriteLine(userFirst + " " + userLast + " will retire in " + retirementAge + " with " + bankAccount + " in the bank, a vacation home in " + vacationHome + " and a " + ".");

            



        }
    }
}
