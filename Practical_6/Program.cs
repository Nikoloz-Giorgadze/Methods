using System;
using System.Security.Cryptography;

namespace Practical_6
{
    class Program
    {
        static void Main()
        {
            char[] array = Array();
            Console.WriteLine("Etner element: ");
            char element = char.Parse(Console.ReadLine());
            int number = CharInArray(array, element);
            WriteAnswer(number, element);

        }

        static char[] Array()
        {
            Console.WriteLine("Enter array size: ");
            int arrayLength = int.Parse(Console.ReadLine());
            char[] array = new char[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write($"Enter element for index {i}: ");
                array[i] = char.Parse(Console.ReadLine());
            }
            return array;
        }
        static int CharInArray(char[] array, char element)
        {
            bool check = false;
            int x = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (element == array[i])
                {
                    check = true;
                    x++;
                }
            }
            return x;
        }
        static void WriteAnswer(int number, char element)
        {
            Console.WriteLine($"'{element}' in array was {number} times");
        }

    }
}