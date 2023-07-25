using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        //[Fact]
        [InlineData("fire", false)] // ← you will need to put some test data and expected result here.  
        [InlineData("123454321", true)]
        [InlineData("racecar", true)]
        [InlineData("rock", false)]
        public void PalindromeTest(string word, bool expected)
        {
            //var CalculatorTest = new Calculator();
            var WordSmithTest = new WordSmith();

            var actual = WordSmithTest.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
