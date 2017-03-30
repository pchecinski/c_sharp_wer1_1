using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.1.
            Napisz program, kt�ry sprawdza, czy podany rok jest rokiem przest�pnym. Rok
            przest�pny dzieli si� bez reszty przez 4, nie dzieli si� przez 100 (za wyj�tkiem lat podzielnych
            przez 400).
        */

        static void Main(string[] args) {

            int year;
            Console.Write("Wprowad� rok: ");
            int.TryParse(Console.ReadLine(), out year);

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0) {
                Console.WriteLine("Rok {0} jest rokiem przest�pnym", year);
            }
            else {
                Console.WriteLine("Rok {0} nie jest rokiem przest�pnym", year);
            }

            Console.ReadKey();
        }
    }
}
