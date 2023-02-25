namespace Practical_9
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(ReturnMultiplication(1, 3, 4, 15, 13, 23, 98));
        }

        static int ReturnMultiplication(params int[] numbers)
        {
            int multiplicated = 1;
            foreach (int number in numbers)
            {
                multiplicated *= number;
            }
            return multiplicated;
        }
    }
}