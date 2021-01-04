using System;

namespace PalindromeDomain
{
    public class PalindromeChecker
    {

        public PalindromeChecker()
        {

        }

        public bool CheckPalindrome(string input)
        {
            string BackwardsString = "";

            for(int i = input.Length - 1; i >= 0; i --)
            {
               BackwardsString += input.Substring(i, 1);
            }

            if(String.Equals(BackwardsString.ToLower(), input.ToLower()))
            {
                return true;
            }
            return false; 
        }

        public string WhiteSpaceRemover(string input)
        {
            return input.Replace(" ", String.Empty);
        }
    }
}