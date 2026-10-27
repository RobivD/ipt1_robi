using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mensa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            decimal price;
            decimal amount;
            decimal discountPercentage;



            Console.WriteLine("Produktname eingeben: ");
            name = Console.ReadLine();


            Console.WriteLine("Preis eingeben: ");
            price = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Menge eingeben: ");
            amount = Convert.ToDecimal(Console.ReadLine());

            if (amount < 1)
            {

                // Console.WriteLine("Error: Ungültige Menge");
                return;

            }
            else if (amount < 3) {

                discountPercentage = 0;

            }
            else if (amount < 5) {

                discountPercentage = 10;

            }
            else {

                discountPercentage = 20;

            }




            Console.ReadLine();
            Console.WriteLine("github_test0");
            Console.WriteLine("github_test1");
        }
    }
}
