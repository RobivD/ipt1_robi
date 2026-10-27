using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int regal = 0;
            for (int i = 9; i >= 0; i--)
            {
                Console.WriteLine(i--);
            }
        }
    }
}
