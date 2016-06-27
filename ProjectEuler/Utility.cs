using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    static class Utility
    {
        //Find difference between sum of the squares and square of the sums 
        //Project Euler problem 6
        public static int DifferenceBetweenSqueares(int minValue,int maxValue)
        {
            int sumOfSqueares=0;
            int squareOfSums=0;
            for(int i = minValue; i <= maxValue; i++)
            {
                squareOfSums += i;
            }
            squareOfSums = squareOfSums * squareOfSums;

            for(int i = minValue; i <= maxValue; i++)
            {
                sumOfSqueares = sumOfSqueares + i * i;
            }
            return Math.Abs(squareOfSums-sumOfSqueares);
        }
    }
}
