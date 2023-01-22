using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Calculator
    {
        public static int Sum(int[] numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static double Average(int[] numbers)
        {
            var sum = Sum(numbers);
            var average = sum / numbers.Length; 

            return average;
        }
    }
}
