using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class EvenOdd
    {
        public void EvenOrOdd()
        {
            Console.WriteLine("Please enter a Number to check Even or Odd");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("{0} is an Even number", num);
            else
                Console.WriteLine("{0} is a Odd number", num);
        }
    }
}
