using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To C# Basic Core Programs");
            Console.WriteLine("Enter the option of the program you want to perform");
            Console.WriteLine("1. FlipCoin \n2. LeapYear \n3. PowerOf2 \n4. PowerOfTwo");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FlipCoin fp = new FlipCoin();
                    fp.HeadTailPercentage();
                    break;
                case 2:
                    LeapYear lp = new LeapYear();
                    lp.LeapYearOrNot();
                    break;
                case 3:
                    PowerOf2 p2 = new PowerOf2();
                    p2.PowerOfTwo();
                    break;
                case 4:
                    PowerOfTwo p = new PowerOfTwo();
                    p.PowerOfTwoUsingMethod();
                    break;
                default:
                    Console.WriteLine("Please choose the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
