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
            Console.WriteLine("1. FlipCoin \n2. LeapYear \n3. PowerOf2 \n4. PowerOfTwo \n5. HarmonicNumber \n6. PrimeFactors \n7. QuotientRemainder \n8. SwapNumbers \n9. EvenOdd");
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
                case 5:
                    HarmonicNumber nb = new HarmonicNumber();
                    nb.HarmonicValue();
                    break;
                case 6:
                    PrimeFactors pf = new PrimeFactors();   
                    pf.PrimeFactor();
                    break;
                case 7:
                    QuotientRemainder qr = new QuotientRemainder();
                    qr.QuotientRem();
                    break;
                case 8:
                    SwapNumbers sw = new SwapNumbers();
                    sw.SwapNum();
                    break;
                case 9:
                    EvenOdd eo = new EvenOdd();
                    eo.EvenOrOdd();
                    break;
                default:
                    Console.WriteLine("Please choose the correct option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
