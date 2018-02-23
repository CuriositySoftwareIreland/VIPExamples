using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeNumberCheck
{
    public class PrimeNumberDetails
    {
        public int Number;
        public bool IsPrime;
        public int NextPrime;
    }
    public class StandardClasses
    {
        public static PrimeNumberDetails CheckPrime(int i)
        {
            PrimeNumberDetails ReturnObject = new PrimeNumberDetails();
            ReturnObject.Number = i;

            bool isPrimeNumberFound = true;
            bool isNextPrimeNumberFound = false;

            //Get Square root of number and iterate, start from 2
            int check = (int)Math.Sqrt((double)(i));
            for (int j = 2; j <= check; j++)
            {
                if (i % j == 0)
                {
                    isPrimeNumberFound = false;
                    break;
                }
            }
            if (isPrimeNumberFound)
            {
                ReturnObject.IsPrime = true;

            }
            else { ReturnObject.IsPrime = false; }
            i++;
            isPrimeNumberFound = true;
            // Increment current number to find next prime number
            while (isNextPrimeNumberFound == false)
            {
                check = (int)Math.Sqrt((double)(i));
                for (int j = 2; j <= check; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumberFound = false;
                        break;
                    }
                }
                if (isPrimeNumberFound) { isNextPrimeNumberFound = true; }
                else { i++; isPrimeNumberFound = true; }
            }

            if (isNextPrimeNumberFound) { ReturnObject.NextPrime = i; }
            return ReturnObject;
        }
    }
}
