using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LargestNumber
    {
        public void LargestAmongThreeNumbers()
        {
            Console.WriteLine("Enter any 3 number to find Largest among them");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());

            if (first > second && first > third)
                Console.WriteLine("Largest number is: " + first);
            else if (second > first && second > third)
                Console.WriteLine("largest number: " + second);
            else
                Console.WriteLine("largest number: " + third);
        }
    }
}
