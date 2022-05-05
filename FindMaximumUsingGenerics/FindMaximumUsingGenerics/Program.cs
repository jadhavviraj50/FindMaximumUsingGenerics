using System;
using FindMaximumNumber;

namespace TestMaximum
{
    class program
    {
        public static void Main(string[] args)
        {
            FindMaximum test = new FindMaximum();
            
            Console.WriteLine("Max number of 3 variables i.e. 1, 2, 3 ");
            test.FindMaxInteger(1, 2, 3);

            Console.WriteLine("Max number of 3 variables i.e. 1, 2, 3 ");
            test.FindMaxInteger(3, 1, 2);

            Console.WriteLine("Max number of 3 variables i.e. 1, 3, 2 ");
            test.FindMaxInteger(1, 3, 2);



        }

    }
}