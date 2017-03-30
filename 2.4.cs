using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 2.4.
            Po wykonaniu poni¿szych linii programu:
             int x = 100;
             Console.WriteLine(++x * 2);
        ->  a) wyœwietli siê liczba 202 
            b) wyœwietli siê liczba 200
            c) bêdzie b³¹d 
            d) wyœwietli siê liczba 201.
        */

        static void Main(string[] args) {

            int x = 100;
            Console.WriteLine(++x * 2);

            Console.ReadKey();
        }
    }
}
