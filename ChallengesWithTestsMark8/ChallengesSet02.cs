using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return (vals.Length % 2 == 0);
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null || numbers.Count() == 0) return 0;

            var minValue = numbers.Min();
            var maxValue = numbers.Max();

            return minValue + maxValue;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null) return 0;

            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null) return 0;

            var sumEvens = 0;
            foreach (int i in numbers)
            {
                if(i % 2 == 0)
                {
                    sumEvens += i;
                }
                
            }

            return sumEvens;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null) return false;

            var sum = 0;
            foreach(var number in numbers)
            {
                sum += number;
            }

            return (sum % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var positiveOddNumbers = new List<long>();
            for(var i = 0; i < number; i++)
            {
                if(i % 2 == 1)
                {
                    positiveOddNumbers.Add(i);
                }
            }

            return positiveOddNumbers.Count;
        }
    }
}
