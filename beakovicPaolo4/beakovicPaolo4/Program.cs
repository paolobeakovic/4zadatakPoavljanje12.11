using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beakovicPaolo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite cijenu bez PDV-a : ");
            double bezPDV = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Unesite cijenu sa PDV-om : ");
            double saPDV = Convert.ToDouble(Console.ReadLine());

            double PDV = ((saPDV / bezPDV) - 1) * 100;

            Console.WriteLine("PDV izađe : " + PDV + "%");
            Console.ReadKey();

        }
    }
}
