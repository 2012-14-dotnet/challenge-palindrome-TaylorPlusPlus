using System;
using Xunit;
using PalindromeDomain;

namespace Palindrome.Testing
{
    public class PalindromeCheckerTests
    {
        [Fact]
        private void TestPalidromeCheckerExists()
        {
            //arrange
            PalindromeChecker Checker = new PalindromeChecker();

            //act 
            PalindromeChecker Actual = Checker;

            //assert
            Assert.IsType<PalindromeChecker>(Actual);
            Assert.NotNull(Actual);
        }
        [Fact]
        private void TestPalidromeCheckerIsPalindrome()
        {
            //arrange
            PalindromeChecker Checker = new PalindromeChecker();
            string Input1 = "CAAC";
            string Input2 = "Dogma I am God";
            string Input3 = "rAceCar";
            bool First = true;
            bool Second = true;
            bool Third = true;

            //act 
            First = Checker.CheckPalindrome(Checker.WhiteSpaceRemover(Input1));
            Second = Checker.CheckPalindrome(Checker.WhiteSpaceRemover(Input2));
            Third = Checker.CheckPalindrome(Checker.WhiteSpaceRemover(Input3));


            //assert
            Assert.True(First);
            Assert.True(Second);
            Assert.True(Third);
        }
        [Fact]
        private void TestPalidromeCheckerIsNOTPalindrome()
        {
            //arrange
            PalindromeChecker Checker = new PalindromeChecker();
            string Input1 = "NOTTRUE";
            string Input2 = "NOT TRUE";
            string Input3 = "BaD Car";
            bool First = true;
            bool Second = true;
            bool Third = true;

            //act 
            First = Checker.CheckPalindrome(Checker.WhiteSpaceRemover(Input1));
            Second = Checker.CheckPalindrome(Checker.WhiteSpaceRemover(Input2));
            Third = Checker.CheckPalindrome(Checker.WhiteSpaceRemover(Input3));


            //assert
            Assert.False(First);
            Assert.False(Second);
            Assert.False(Third);
        }
        
        [Fact]
         private void TestWhiteSpaceRemover()
        {
            //arrange
            PalindromeChecker Checker = new PalindromeChecker();
            string Input1 = "NOTTRUE";
            string Input2 = "NOT TRUE";
            string Input3 = "BaD Car Slow";
            string Input4 = "BaDCarSlow";
  

            //act 
            Input2 = Checker.WhiteSpaceRemover(Input2);
            Input3 = Checker.WhiteSpaceRemover(Input3);

            //assert
            Assert.Equal(Input1, Input2);
            Assert.Equal(Input3, Input4);
        }
    }
}
