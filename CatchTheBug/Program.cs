using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatchTheBug
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fahrzeugtyp (1=Motorrad, 2=Auto, 3=Lieferwagen): ");
            int fahrzeug = Convert.ToInt32(Console.ReadLine());
            Console.Write("Parkdauer in Stunden: ");
            int stunden = Convert.ToInt32(Console.ReadLine());
            Console.Write("Mitglied (1=Ja, 2=Nein): ");
            int mitglied = Convert.ToInt32(Console.ReadLine());
            double stundenpreis = 0;
            switch (fahrzeug)
            {
                case 1:
                    stundenpreis = 2.00;
                    break;
                case 2:
                    stundenpreis = 5.00;
                    break;
                case 3:
                    stundenpreis = 3.50;
                    break;
            }
            double gebuehr = stundenpreis + stunden;
            if (stunden > 5)
            {
                gebuehr = gebuehr * 0.90;
            }
            if (mitglied == 2)
            {
                gebuehr = gebuehr * 0.80;
            }
            Console.WriteLine("Parkgebühr: CHF " + gebuehr);
            // Das Konsolenfenster bleibt geöffnet bis die Enter-Taste gedrückt wird
            Console.ReadLine();
        }
    }
}
