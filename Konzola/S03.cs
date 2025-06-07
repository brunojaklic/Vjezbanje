using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konzola
{
    internal class S03
    {
        public static void Izvedi()
        {



            Console.Write("Unesi cijeli broj: ");

            int cijeliBroj = int.Parse(Console.ReadLine());

            if (cijeliBroj == 0)
            {
                Console.WriteLine("Unesena je {0}", cijeliBroj);
            }
            else if (cijeliBroj % 2 == 0)
            {
                Console.WriteLine("Broj {0} je paran", cijeliBroj);
            }
            else
            {
                Console.WriteLine("Broj {0} je neparan", cijeliBroj);
            }



        }
    }
}
