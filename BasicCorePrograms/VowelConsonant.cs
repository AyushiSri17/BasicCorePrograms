using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class VowelConsonant
    {
        public void VowelOrConsonant()
        {
            Console.WriteLine("Please Enter a Alphabet to Check Whether it is Vowel or Consonant");
            char alphabet = Convert.ToChar(Console.ReadLine().ToLower());
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u')            
                Console.WriteLine("It is a Vowel");           
            else           
                Console.WriteLine("It is a Consonant");           
        }
    }
}
