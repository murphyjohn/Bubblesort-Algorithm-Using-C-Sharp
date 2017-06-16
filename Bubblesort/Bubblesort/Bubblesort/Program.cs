using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] myarray = { 2, 6, 8, 56, 11, 4, 23, 1 };
            Console.Write("Before sorting");
            for (int i = 0; i < myarray.Length; i++)
            {
                Console.Write(" " + myarray[i]);
            }
            int[] second_array = new int[8];
            second_array = Tester.BubbleSort(myarray);

            Console.Write("\nAfter sorting");
            for (int i = 0; i < second_array.Length; i++)
            {
                Console.Write(" " + second_array[i]);
            }
            Console.Write("\nCompleted\n");
        }
    }
    class Tester
    {

        public static int[] BubbleSort(int[] numbers)
        {
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        //swap
                        int temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
            return numbers;
        }
    }

}