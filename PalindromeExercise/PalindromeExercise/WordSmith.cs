using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string word)
        {
            char[] reverseStringCharArray = word.ToCharArray();
                
            Array.Reverse(reverseStringCharArray);

            //var reverseString = reverseStringCharArray.ToString();
            string reverseString = "";

            for (int i = 0; i < reverseStringCharArray.Length; i++)
            {
                reverseString += reverseStringCharArray[i];
            }
            

            if (reverseString == word)
            {
                return true;
            }

            return false;
        }
    }
}
