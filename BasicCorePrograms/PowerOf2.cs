using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOf2
    {
        public void PowerOfTwo()
        {
            int i, power = 1;
            Console.WriteLine("Enter the power value of 2");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("N = "+n);
            Console.WriteLine("Table of 2 to the power "+n);
            for(i=1; i<=n; i++)
            {
                power = power * 2;
                Console.WriteLine("2^{0} = {1} ",i,power);
            }
        }
    }
}
