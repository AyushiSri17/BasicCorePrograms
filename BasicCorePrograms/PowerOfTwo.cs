using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOfTwo
    {
        public void PowerOfTwoUsingMethod()
        {
            int i;
            Console.WriteLine("Enter the power value of 2");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("N = " + n);
            Console.WriteLine("Table of 2 to the power " + n);
            for (i = 1; i <= n; i++)
            {
                double power= Math.Pow(2,i);
                Console.WriteLine("2^{0} = {1} ", i, power);
            }
        }
    }
}
