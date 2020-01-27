using System;
using System.Text.RegularExpressions;

namespace Lab_2._3_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a name: ");
            string userInput = Console.ReadLine();

            bool isValid = ValidName(userInput);

            if (isValid == true)
            {
                Console.WriteLine("you entered a valid name!");
            }
            else
            {
                Console.WriteLine("Sorry this name is not valid");
            }
            //===============================================================
            Console.WriteLine("Please enter your email");
            string userEmailInput = Console.ReadLine();

            bool validEmail = ValidEmail(userEmailInput);
           
            if (validEmail == true)
            {
                Console.WriteLine("you entered a valid email!");
            }
            else
            {
                Console.WriteLine("Sorry this email is not valid");
            }
            //================================================================

            Console.WriteLine("Please enter you phone number in this format ###-###-####");
            string userPhoneInput = Console.ReadLine();

            bool validPhone = ValidPhoneNumber(userPhoneInput);

            if (validPhone == true)
            {
                Console.WriteLine("you entered a valid phone number!");
            }
            else
            {
                Console.WriteLine("Sorry this phone number is not valid");
            }

            //==============================================================


            Console.WriteLine("Please enter your Birthday in the format ##/##/####");
            string userDateInput = Console.ReadLine();

            bool validDate = ValidDate(userPhoneInput);

            if (validDate == true)
            {
                Console.WriteLine("you entered a valid Date!");
            }
            else
            {
                Console.WriteLine("Sorry this date is not valid");
            }
        }

        static bool ValidName(string input)
        {
            string pattern = @"(\b([A-Z]{1})([A-z]{1,29})\b)+";


            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ValidEmail(string input)
        {
            string pattern = @"((\b([0-9A-z]{5,30})@[a-z]{5,10}.([a-z]{2,3})\b))";


            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
                        
        }

        static bool ValidPhoneNumber(string input)
        {
            string pattern = @"[(]?([\d]{3}\)?-?([\d]{3})-?[\d]{4})";


            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ValidDate(string input)
        {
            string pattern = @"[0-9]{2}[/][0-9]{2}[/][0-9]{4}";


            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
