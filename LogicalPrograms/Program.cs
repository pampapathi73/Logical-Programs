using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to logical programs");
            Console.WriteLine("Enter your choice ");
            Console.WriteLine(".............................................");
            Console.WriteLine("1 For: Fibonacci Series ");
            Console.WriteLine("2 For: Perfect Number ");
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    //Fibonacco Series
                    fibonacciSeries FlibSeries = new fibonacciSeries();
                    FlibSeries.CheckFibonacciSeries();
                    break;
                case 2:
                    //Perfect Number
                    PerfectNumbercs PerfectNum = new PerfectNumbercs();
                    PerfectNum.CheckPerfectNumber();
                    break;
                default:
                    Console.WriteLine("Invalid Selection. Select in b/w  1 to 4");
                    break;
            }
            Console.ReadLine();
        }
    }
}
