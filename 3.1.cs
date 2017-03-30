using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.1.
            Napisz program, który sprawdza, czy podany rok jest rokiem przestêpnym. Rok
            przestêpny dzieli siê bez reszty przez 4, nie dzieli siê przez 100 (za wyj¹tkiem lat podzielnych
            przez 400).
        */

        static void Main(string[] args) {

            int year;
            Console.Write("WprowadŸ rok: ");
            int.TryParse(Console.ReadLine(), out year);

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) {
                Console.WriteLine("Rok {0} jest rokiem przestêpnym", year);
            }
            else {
                Console.WriteLine("Rok {0} nie jest rokiem przestêpnym", year);
            }

            Console.ReadKey();
        }
    }
}
