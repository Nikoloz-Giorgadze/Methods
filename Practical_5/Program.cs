using System;


namespace Practical_5
{
    class Program
    {
        static void Main()
        {
            int[] array = Array();
            Factorial(array, 5);
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
        static void Factorial(int[] array, int number)
        {
            bool check = false;
            int factorial = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    check = true;
                    for (int j = 1; j <= number; j++)
                    {
                        factorial *= j;
                    }
                    Console.WriteLine($"Factorial of {number} is {factorial}");
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine($"{number} is not in the array!");
            }
        }
    }
}