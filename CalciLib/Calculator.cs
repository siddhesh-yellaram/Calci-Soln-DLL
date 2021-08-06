using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalciLib
{
    public class Calculator
    { 
        public bool CheckEven(int num)
        {
            if (num % 2 == 0)
                return true;
            return false;
        }

        public bool CheckPrime(int num)
        {
            // Check if num is less than or equal to 1
            if (num <= 1)
                return false;

            // Check if num is 2
            else if (num == 2)
                return true;

            // Check if num is a multiple of 2
            else if (num % 2 == 0)
                return false;

            //Check for odd nums
            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
