using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientRemainder
    {
        public void QuotientRem()
        {
            Console.WriteLine("Enter the Divident, Divisor to find Quotient and Remainder");
            int divident = Convert.ToInt32(Console.ReadLine());
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient = (divident / divisor);
            int remainder = (divident % divisor);
            Console.WriteLine("Quotient:" + quotient);
            Console.WriteLine("Remainder:" + remainder);
        }
    }
}
