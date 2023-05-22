using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SECTION_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());


            HUMAN human = new HUMAN("John", " Doe", 18, "brown")
            {
                width = width,
                length = length

            };
            Console.WriteLine($"Area is {human.Area}");

            // Calling the method
            human.Introduce();

            Console.ReadKey();
        }
    }
}
