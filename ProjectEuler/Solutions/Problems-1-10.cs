using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectEuler;

namespace ProjectEuler.Solutions
{
    static class Solutions1_10
    {
        /// <summary>
        /// Solution 1
        /// Calculate sum of all multiples of 3 and 5 below limit parameter
        /// </summary>
        /// <param name="limit">Natural number what you want calculate</param>
        /// <returns>int</returns>
        public static int Multiples(int limit)
        {
            int sum=0;
            for(int i=0;i<limit;i++)
            {
                if (i%3==0||i%5==0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
        /// <summary>
        /// Solutin 6
        /// Method calculate different between two parameters
        /// </summary>
        /// <param name="minValue">Start value</param>
        /// <param name="maxValue">End value</param>
        /// <returns>int32</returns>
        public static int DifferenceBetweenSqueares(int minValue, int maxValue)
        {
            int sumOfSqueares = 0;
            int squareOfSums = 0;
            for (int i = minValue; i <= maxValue; i++)
            {
                squareOfSums += i;
            }
            squareOfSums = squareOfSums * squareOfSums;

            for (int i = minValue; i <= maxValue; i++)
            {
                sumOfSqueares += i * i;
            }
            return Math.Abs(squareOfSums - sumOfSqueares);
        }

        /// <summary>
        /// Problem 2
        /// Find sum of even numbers in fibonacci sequence whose values do not exceed limit parameter 
        /// </summary>
        /// <param name="limit">Sequence limit</param>
        /// <returns>int</returns>
        public static int Fibonacci(int limit)
        {
            int start = 1;
            int sum = 0;
            for (int i = 2; i < limit; i = i + start, start = i - start)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            return sum;
        }
        /// <summary>
        /// This method find largest palindrome
        /// </summary>
        /// <returns></returns>
        public static int PalindromFinder()
        {
            int x = 999;
            while (x!=1)
            {
                int y = x;
                for(int j = 0;j<100;j++)
                {
                    if ((y * x).ToString() == new string(Convert.ToString(y*x).Reverse().ToArray()))
                        return y * x;
                    y--;
                }
                x--;
            }
            return x;           
        }

        /// <summary>
        /// This function return smallest number that is be evenly divisible from 1 to 20
        /// </summary>
        /// <returns>int</returns>
        public static int GetSmallestMultiple()
        {
            //TODO: Explore algorithm and re-write this method.
            int result = 20;
            while(true)
            {
                int i = 2;
                while (i<=20)
                {
                    if (result % i != 0)
                        break;
                    else if (i == 20)
                        return result;
                    i++;
                }
                result++;
            }

            return 0;
        }

        /// <summary>
        /// Return prime factor of parameter
        /// </summary>
        /// <param name="number">Int64 number</param>
        /// <returns>int</returns>
        public static int LargestPrimeFactor(Int64 number)
        {
            Int64 maxFactor = 2;
            while (number != 1)
            {
                if (number % maxFactor == 0)
                {
                    number /= maxFactor;
                }
                else if (number < maxFactor * maxFactor)
                    maxFactor = number;
                else
                    maxFactor++;
            }

            return (int)maxFactor;
        }

        /// <summary>
        /// Solution 8
        /// Calculate largest product of 13 digits in 1000 digits number
        /// </summary>
        /// <returns></returns>
        public static Int64 LargestProduct()
        {
            /*When learn some regular expression re-write this*/
            string veryBigNumber = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            Int64 result = 0;

            for (int i = 12; i < veryBigNumber.Length; i++)
            {
                int count = 1;
                Int64 tempMaxProduct = Int32.Parse(veryBigNumber[i].ToString());
                while (count <= 12)
                {
                    tempMaxProduct = tempMaxProduct * Int32.Parse(veryBigNumber[i - count].ToString());
                    count++;
                }
                if (tempMaxProduct > result)
                    result = tempMaxProduct;
            }
            
            return result;
        }
    }
}
