using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            Task2();
        }

        private static void Task2()
        {
            int average;
            int sum = 0;
            var numbers = new List<int> { 1, 6, 9, 7, 15, 46, 12, 43 };
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                sum += numbers[i];
            }
            average = sum / numbers.Count;
            Console.WriteLine("Среднея арефмитическое = " + average);
            for(int i = numbers.Count - 1; i >= 0; i--)
            {
                if(average < numbers[i])
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.ReadLine();
        }

        private static void Task1()
        {
            ArrayList numbers = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 9, 9, 9, 9, 9 };
            for (int i = 0; i < numbers.Count; i++)
            {
                if ((int)numbers[i] % 2 == 1)
                {
                    numbers.RemoveAt(i);
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
