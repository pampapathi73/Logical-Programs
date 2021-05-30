using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumbercs
    {
        public int Number;
        public int var_j;
        public int Result;

        public void CheckPerfectNumber()
        {
            Console.Write("Input the  number : ");  //Input Number
            Number = Convert.ToInt32(Console.ReadLine());//Read Number
            Result = 0;//By Default Result is 0
            Console.Write("The positive divisor  : ");
            for (var_j = 1; var_j < Number; var_j++) ////loop starts from 1 and Check if 1 < Given Number and den it will increment by1
            {
                if (Number % var_j == 0) //check Given ip Number % var_j == 0 (28 % 1 == 0 )
                {
                    Result = Result + var_j;  // Result = 0+1
                    Console.WriteLine("{0}  ", var_j); //{0} Format string  
                }
            }
            Console.Write("\nThe sum of the divisor is : {0}", Result);  //print sum of divisor
            //Check Number is Perfect Or not
            if (Result == Number)
                Console.Write("\nSo, the number is perfect.");
            else
                Console.Write("\nSo, the number is not perfect.");
        }
    }
}