using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 3, 4, 8, 13, 18, 19, 23 };
            int[] arr2 = { 2, 1, 12, 15, 6, 18, 16, 4, 3, 21, 11 };
            int[] arr3 = { 1, 13, 19, 25, 23, 2 };


            Console.WriteLine("Please enter the begin of set and then choose the numbers between 1-25, press ENTER after each number. ");
            int aa = int.Parse(Console.ReadLine());
            Console.WriteLine("All Input:" + aa);
            var newArray = new int[aa];
            for (var i = 0; i <= newArray.Length - 1; i++)
            {
                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("You may only enter numbers!");
                }

                newArray[i] = Convert.ToInt32(number);
            }

            if (newArray.Length == 7)
            {
                if (arr1.SequenceEqual(newArray) == true)
                {
                    Console.WriteLine("Bingo");
                }
                else
                {
                    Console.WriteLine("Not Bingo");
                }
            }
            else if (newArray.Length == 11)
            {
                if (arr2.SequenceEqual(newArray) == true)
                {
                    Console.WriteLine("Bingo");
                }
                else
                {
                    Console.WriteLine("Not Bingo");
                }
            }
            else if (newArray.Length == 6)
            {
                if (arr3.SequenceEqual(newArray) == true)
                {
                    Console.WriteLine("Not Bingo");
                }
            }
            else
            {
                Console.WriteLine("Not Bingo");
            }

            Console.ReadKey();

        }
    }
}
