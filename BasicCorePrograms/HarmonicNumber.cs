using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicNumber
    {
        public void HarmonicValue()
        {
            float sum = 0;
            
            Console.WriteLine("Enter the number of terms: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 1; i <= n; i++)
            {
                //Printing without array
                Console.Write("1/{0} + ", i);
                arr[i - 1] = i;
                sum +=(1/(float)i);
            }
            Console.WriteLine("\nPrinting values with array");
            for (int j = 0; j < arr.Length; j++)
            {
                //For printing value in single line we use Write method
                Console.Write("1/{0} + ",arr[j]); 
            }
            Console.WriteLine("\nNth Narmonic Value: " + sum);
        }
    }
}
