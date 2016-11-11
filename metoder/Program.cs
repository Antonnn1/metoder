using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övn 1
            Console.Write("Mata in en temperatur i celsius: ");
            double inmatat = double.Parse(Console.ReadLine());
            CeslsiusTillFarenheit(inmatat);
        }
        static void CeslsiusTillFarenheit(double Celsius)
        {
            Console.WriteLine((Celsius / 5.0) * 9 + 32);
        }
    }
}
