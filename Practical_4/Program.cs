using System;
namespace practical_4
{
    class Program
    {
        static void Main()
        {
            int[] array = Array();
            Average(array);

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
        static void Average(int[] array)
        {
            int average;
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum+=array[i];
            }
            average=sum/array.Length;
            Console.WriteLine($"Arithmetic average of array is {average}");
        }
    }
}