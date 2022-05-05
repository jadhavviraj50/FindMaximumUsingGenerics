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

            Console.WriteLine("Max number of 3 float i.e. 1.2f, 3.6f, 6.7f ");
            test.FindMaxFloat(1.2f, 3.6f, 6.7f);

            Console.WriteLine("Max number of 3 float i.e. 6.7f, 1.2f, 3.6f ");
            test.FindMaxFloat(6.7f, 1.2f, 3.6f);

            Console.WriteLine("Max number of 3 float i.e. 1.2f, 6.7f, 3.6f ");
            test.FindMaxFloat(1.2f, 6.7f, 3.6f);

            Console.WriteLine("Max number of 3 string i.e. Apple, Peach, Banana");
            test.FindMaxString("Apple", "Peach", "Banana");

            Console.WriteLine("Max number of 3 string i.e. Banana, Apple, Peach");
            test.FindMaxString("Banana", "Apple", "Peach");

            Console.WriteLine("Max number of 3 string i.e. Apple, Banana, Peach");
            test.FindMaxString("Apple", "Banana", "Peach");



        }

    }
}