using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 2.5.
            Po wykonaniu poni¿szych linii programu:
             int x = 2, y = 3;
             x *= y * 2;
            a) zmienna x=6
            b) zmienna x=18
            c) zmienna x=24 
        ->  d) zmienna x=12.
        */

        static void Main(string[] args) {

            int x = 2, y = 3;
            x *= y * 2;

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
