using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------Checking Prime or Not --------------------//
            //CheckingPrime checkingPrime = new CheckingPrime();
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (checkingPrime.isPrime(num))
            //    Console.WriteLine($"{num} is prime");
            //else
            //    Console.WriteLine($"{num} is not prime");

            //----------------Checking Two Strings are Anagram or Not --------------------//
            //AnagramStrings anagramStrings = new AnagramStrings();
            //string str1 = Console.ReadLine();
            //string str2 = Console.ReadLine();
            //if (anagramStrings.isAnagram(str1, str2))
            //    Console.WriteLine($"{str1} and {str2} is Anagram");
            //else
            //    Console.WriteLine($"{str1} and {str2} is not Anagram");

            //---------------- Sum of One to N numbers --------------------//
            //SumOfNNumbers sumOfNNumbers = new SumOfNNumbers();
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(sumOfNNumbers.getSumOnetoN(num));

            //---------------- Factorial of Number --------------------//
            //FactorialOfNumber factorialOfNumber = new FactorialOfNumber();
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(factorialOfNumber.getFactorialOfNumber(num));

            //---------------- Two Sum Problem --------------------//
            //TwoSumProblem twoSumProblem = new TwoSumProblem();
            //int[] nums = { 5, 8, 3, 4, 5, 4 };
            //int k = 9;
            //if (twoSumProblem.isTargetSumAvailable(nums, k))
            //    Console.WriteLine($"target sum {k} is available in nums! :)");
            //else
            //    Console.WriteLine($"target sum {k} is not available in nums! :)");

            //---------------- string reverse --------------------//
            StringReverse stringReverse = new StringReverse();
            string str = Console.ReadLine();
            Console.WriteLine(stringReverse.getReversedString(str));

        }
    }
}
