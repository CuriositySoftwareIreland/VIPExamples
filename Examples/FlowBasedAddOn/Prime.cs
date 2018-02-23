using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimeNumberCheck;


namespace PrimeNumberApp
{
    
    //-----------------------------------------------------

    
    class PrimeNumberApp
    {
        public static void Main(string[] args)
        {
            int ctr = 0;
            int InNumber = 0;
            string InNumberC;
            if (args.Length <= 0)
            {
                Console.WriteLine("No Command Line arguments were provided.");
                return;
            }
            else
            {
  /*              for (ctr = 0; ctr < args.Length; ctr++)
                {
                    Console.WriteLine("Argument {0} is {1}", ctr + 1, args[ctr]);
                }
                System.Console.WriteLine("Passed in {0}", args[0]);
  */
                InNumber = int.Parse(args[0]);
                while (InNumber != 0)
                {
                PrimeNumberDetails LocalPrimeNumberDetails = StandardClasses.CheckPrime(InNumber);
                System.Console.WriteLine("Is {0} a prime number? The answer is {1} The next one is {2}", InNumber, LocalPrimeNumberDetails.IsPrime, LocalPrimeNumberDetails.NextPrime);
                Console.WriteLine("Have another go or enter 0");
                InNumberC = System.Console.ReadLine();
                InNumber = Convert.ToInt32(InNumberC);
                }
   //           Console.Read();
            }
        }
    }

}
