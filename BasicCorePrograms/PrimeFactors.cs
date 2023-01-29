using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PrimeFactors
    {
        public void PrimeFactor()
        {
            int fact = 1, counter = 0;
            Console.WriteLine("Enter the number whose factors are to be determined");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int arrIndex = 0;
            int primeIndex = 0;
            int[] primeArray = new int[n];
            Console.WriteLine("Number is: " + n);
            Console.WriteLine("Factors of {0} are", n);
            for (int i = 1; i <= n; i++)
            {
                //for finding factorial of a number
                fact = fact * i;
                //condition for finding factors of a number
                if (n % i == 0)
                {
                    Console.Write(i + ",");
                    arr[arrIndex] = i;
                    arrIndex++;
                }
            }
            Console.WriteLine("\nFactorial of {0} is {1}", n, fact);
            Console.WriteLine("\nArray of all factors of {0} is:",n);
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == 0)
                    break;
                //For printing value in single line we use Write method
                Console.Write(arr[j]+" ");
                //for identifying prime factors
                for (int i = 1; i <= arr[j]; i++)
                {
                    if (arr[j] % i == 0)
                        counter++;
                }
                if (counter == 2)
                {
                    primeArray[primeIndex] = arr[j];
                    primeIndex++;
                }
                counter = 0;
            }
            Console.WriteLine("\nArray of Prime factors of {0} is: ", n);
            for (int j = 0; j < primeArray.Length; j++)
            {
                if (primeArray[j] == 0)
                    break;
                Console.Write(primeArray[j]+" ");

            }
        }
    }
}
