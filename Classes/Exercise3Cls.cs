using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaibhav_assignment.Classes
{
    public class Exercise3Cls
    {
        public Exercise3Cls()
        {
        }

        public void PrimeNumbers(int n1, int n2)
        {
            bool isPrime = true;

            for (int _cnt = n1; _cnt <= n2; _cnt++)
            {
                for (int _cnt1 = 2; _cnt1 <= n2; _cnt1++)
                {
                    if (_cnt != _cnt1 && _cnt % _cnt1 == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if(isPrime)
                {
                    Console.Write(_cnt + "\t");    
                }
                isPrime = true;
            }
            Console.WriteLine();
        }
    }
}
