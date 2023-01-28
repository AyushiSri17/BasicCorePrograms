using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class FlipCoin
    {
        public void HeadTailPercentage()
        {
            int tailCount = 0, headCount = 0;
            Console.WriteLine("Enter the number of times want to flip coin");
            int n = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                //NextDouble method range is from 0 to 1
                double toss = random.NextDouble();
                Console.WriteLine("Random output is: " + toss);
                if (toss < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
            }
            Console.WriteLine("Tail Count: {0} Head Count: {1} ", tailCount, headCount);
            double tailPercent = (double)(tailCount * 100) / n;
            Console.WriteLine("Tail Percent: {0}%",tailPercent);
            double headPercent = (double)(headCount * 100) / n;
            Console.WriteLine("Head Percent: {0}%",headPercent);
        }
    }
}
