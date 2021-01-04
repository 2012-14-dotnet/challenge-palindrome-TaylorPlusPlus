using System;
using PalindromeDomain;

namespace PalindromeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool UserHasNotExited = true;
            string UserInput = "";
            PalindromeChecker Logic = new PalindromeChecker();

            while(UserHasNotExited)
            {
                 Console.WriteLine("Enter a string to see if it is a palindrome or enter 1 to exit: ");
                 UserInput = Console.ReadLine();
                 
                if(String.Equals(UserInput, "1"))
                {
                    UserHasNotExited = false;
                }else
                {
                    if(Logic.CheckPalindrome(Logic.WhiteSpaceRemover(UserInput)))
                    {
                        Console.WriteLine("The String you have entered IS a palindrome");
                    }else
                    {
                        Console.WriteLine("The String you have entered is NOT a palindrome");
                    }
                }
            }
           



            

        }
    }
}
