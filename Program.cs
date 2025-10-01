using System;

namespace max
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter n : ");
            int n=Convert.ToInt32(Console.ReadLine());
            int max = 0;
            for (int i = 0; i < n ; i++)
            {
                Console.WriteLine("enter your numbers: ");
                int numbers = Convert.ToInt32(Console.ReadLine());
                if (numbers > max)
                    max = numbers;
            }
            Console.Write("maximum is: {0} ",max);
            
        }
    }
}
