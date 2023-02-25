using System;

namespace Practical_2
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 1, 32, 5123, 124 };
            sumOfDigits(array, 3);
        }
        static void sumOfDigits(int[] array, int index)
        {
            int sum = 0;
            while (array[index] > 0)
            {
                int temp = array[index] % 10;
                sum += temp;
                array[index] /= 10;

            }
            Console.WriteLine($"The number of digits at index {index} is {sum} ");
        }
    }
}