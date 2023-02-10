using System;

namespace DigitalRoot
{
    internal class Program
    {
        static int DigitalRoot(long n)
        {
            while (n > 9)
            {
                long sum = 0;

                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }

                n = sum;
            }

            string a = n.ToString();
            int b = Int32.Parse(a);

            return b;
        }
        static void Main(string[] args)
        {
            DigitalRoot(999999999999); // 9
        }
    }
}
