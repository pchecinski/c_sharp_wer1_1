using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 2.4.
            Po wykonaniu poni�szych linii programu:
             int x = 100;
             Console.WriteLine(++x * 2);
        ->  a) wy�wietli si� liczba 202 
            b) wy�wietli si� liczba 200
            c) b�dzie b��d 
            d) wy�wietli si� liczba 201.
        */

        static void Main(string[] args) {

            int x = 100;
            Console.WriteLine(++x * 2);

            Console.ReadKey();
        }
    }
}
