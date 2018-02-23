public void CheckPrime(int i)
        {
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
                MessageBox.Show(i + " is a prime number");

            }
            else { MessageBox.Show(i + " is not a prime number"); }
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

            if (isNextPrimeNumberFound) { MessageBox.Show(i + " is the next prime number"); }
        } 