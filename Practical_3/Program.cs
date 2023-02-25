using System;

namespace Practical_3

{
    class Program
    {
        static void Main()
        {
            
            int[] array = Array();
            ArrayMaxMin(array);
        }

        static int[] Array()
        {
            Console.WriteLine("Enter size of array: ");
            int arrayLength = int.Parse(Console.ReadLine());
            int[] array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter number for index {i}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            return array;
        }
        static void ArrayMaxMin(int[] array)
        {
            int i, maxValue, minValue;
            maxValue = array[0];
            minValue = array[0];
            for (i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            Console.WriteLine($"Max value is: {maxValue}");
            Console.WriteLine($"Min value is: {minValue}");
        }
    }
}