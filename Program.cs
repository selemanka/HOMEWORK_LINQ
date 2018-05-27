using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        private static void Output(IEnumerable<int> array, IEnumerable<int> result)
        {
            if (result == null) throw new ArgumentNullException(nameof(result));
            Console.Write("Array : ");
            foreach (var number in array)
            {
                Console.Write($" {number}");
            }
            Console.Write("\nResult: ");
            foreach (var number in result)
            {
                Console.Write($" {number}");
            }
            Console.Write("\n");
        }
        private static void Output(string[] array, IOrderedEnumerable<string> result)
        {
            if (result == null) throw new ArgumentNullException(nameof(result));
            Console.Write("Array : ");
            foreach (var word in array)
            {
                Console.Write($" {word}");
            }
            Console.Write("\nResult: ");
            foreach (var word in result)
            {
                Console.Write($" {word}");
            }
            Console.Write("\n");
        }

        private static void Task16()
        {
            int[] array = { 9, -4, 78, -567, 99 };
            var result = array.Where(number => number > 0);
            Output(array, result);
        }

        private static void Task17()
        {
            int[] array = { 67, 67, -87, 90, 1, -34, -24, 82, 82, 82, 1 };
            var result = array.Where(number => number % 2 == 1).Distinct();
            Output(array, result);
        }
        private static void Task18()
        {
            int[] array = { 1, 98, 45, -65, 46, 896, -7 };
            var result = array.Where(number => number > 9 && number < 100).OrderBy(number => number);
            Output(array, result);
        }

        private static void Task19()
        {
            string[] array = { "aajxkutdc", "dhf", "hcdykhctlugjckfhydfksutej", "q", "qyf", "oihihiu" };
            var result = array.OrderBy(word => word.Length).ThenByDescending(word => word);
            Output(array, result);
        }

        private static void Task20()
        {
            int D = 9;
            int[] A = { 3, 2, 4, 10, 11, 34, 22 };
            var result = A.SkipWhile(number => number < D).Where(number => number > 0 && number % 2 == 1).Reverse();
            Output(A, result);
        }


        private static void Task44()
        {
            const int k1 = 4, k2 = 3;
            int[] A = { 56, 32, 777, 65, 1, 21, 34, 90, 33 };
            int[] B = { 1, 5, 45, 32, 2, 77, 98, 32, 23, 1000, 4 };

            var resultA = A.Where(numberA => numberA > k1);
            var resultB = B.Where(numberB => numberB < k2);

            var result = resultA.Concat(resultB).OrderBy(number => number);
            Output(A, result);
        }

        private static void Task45()
        {
            const int L1 = 2, L2 = 5;

            string[] array1 = { "ds", "aaaaa", "hskw", "ew" };
            string[] array2 = { "kjs", "hjhjh", "ss", "ccccc" };

            var result = array1.Where(i => i.Length == L1).Union(array2.Where(i => i.Length == L2)).OrderByDescending(i => i);
            Output(array1, result);
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("\n*Task 16: * ");
            Task16();
            Console.WriteLine("\n*Task 17: * ");
            Task17();
            Console.WriteLine("\n*Task 18: * ");
            Task18();
            Console.WriteLine("\n*Task 19: *  ");
            Task19();
            Console.WriteLine("\n*Task 20: *  ");
            Task20();
            Console.WriteLine("\n*Task 44: *  ");
            Task44();
            Console.WriteLine("\n*Task 45: *  ");
            Task45();
        }
    }
}
