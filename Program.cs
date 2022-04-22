using System;

namespace MyApplication
{
    public class Sumofdigits
    {
        public static void Main(string[] args)
        {
            int i, sum = 0, j;
            Console.WriteLine("Enter the number");
            i = int.Parse(Console.ReadLine());
            while(i>0)
            {
                j = i % 10;
                sum = sum + j;
                i = i / 10;
            }
            Console.WriteLine("Sum is =" + sum);
        }
    }
}