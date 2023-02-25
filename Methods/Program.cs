using System;
namespace Practical_1
{
    class Program
    {
        static void Main()
        {
            int[] array = new int[] { 4, 5, 8, 10 };
            findWithIndex(array, 2);
        }

        static void findWithIndex(int[] array, int index)
        {
            Console.WriteLine($"Number at index {index} is {array[index]}.");
        }
    }
}