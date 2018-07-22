using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Multithreading
{
    public class GCDComputer
    {
        public static long FindMin(long a, long b)
        {
            return a > b ? b : a;
        }

        public static long FirstGCD(long a, long b)
        {
            long nod = 1L;

            for (long i = a; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    nod = i;
                    break;
                }
            }
            return nod;
        }

        public static long SecondGCD(long a, long b)
        {
            long nod = 1L;

            for (long i = FindMin(a, b); i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {
                    nod = i;
                    break;
                }
            }
            return nod;
        }

        public static long ThirdGCD(long a, long b)
        {

            long nod = 1L;

            if (a > b)
            {
                long tmp = a;
                a = b;
                b = tmp;
            }

            while (a > 1L && b > 1L)
            {
                for (long i = 2; i <= a; i++)
                {
                    if (a % i == 0 && b % i == 0)
                    {
                        nod *= i;
                        a /= i;
                        b /= i;
                        break;
                    }

                    if (a % i == 0)
                    {
                        a /= i;
                        break;
                    }

                    if (b % i == 0)
                    {
                        b /= i;
                        break;
                    }
                }
            }
            return nod;
        }

        public static long EuqlidGCDRec(long a, long b)
        {
            if (a == b)
            {
                return a;
            }

            if (a > b)
            {
                long tmp = a;
                a = b;
                b = tmp;
            }
            return EuqlidGCDRec(a, b - a);
        }
    }
}
