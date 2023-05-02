using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return Array.Exists(vals, element => element.Equals(false));
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {   
            if(numbers == null)
            {
                return false;
            }
            var odds = numbers.Where(x => x % 2 != 0);
            var sum = odds.Sum();

            return sum % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var hasUpper = password.Any(e => char.IsUpper(e));
            var hasLower = password.Any(e => char.IsLower(e));
            var hasNumber = password.Any(e => int.TryParse($"{e}", out int x));

            return hasUpper && hasLower && hasNumber;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return (divisor == 0) ? 0: dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            var last =  nums[nums.Length - 1];
            var first = nums[0];

            return last - first;
        }

        public int[] GetOddsBelow100()
        {
            var end = 99;
            var start = 0;
            var oddsArray  = Enumerable.Range(start, end - start + 1).Where(x => x % 2 != 0).ToArray();
            return oddsArray;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
