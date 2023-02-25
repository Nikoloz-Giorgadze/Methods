using System;
using System.Security.Cryptography.X509Certificates;

namespace Practical_8
{
    class Program
    {
        static void Main()
        {

            Number(EnterNumber());
        }

        static int EnterNumber()
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static void Number(int number)
        {
            int quality;
            string numberStr = "";
            Console.Write(number + " = ");
            while (number > 0)
            {
                numberStr = number.ToString();
                for (int i = 0; i < numberStr.Length; i++)
                {
                    quality = numberStr.Length - 1;
                    Console.Write($" {numberStr[i]} * 10^{quality} + ");
                }
                number /= 10;
            }
        }
    }
}
