using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.10.
            Napisz program obliczaj¹cy n! (n silnia), gdzie n jest podane przez u¿ytkownika.
        */

        static void Main(string[] args) {

            int n, result = 1;
            Console.Write("Podaj n: ");
            int.TryParse(Console.ReadLine(), out n);


            for (int i = n; i > 0; i--) {
                result *= i;
            }

            Console.WriteLine("{0}! = {1}", n, result);
            Console.ReadKey();
        }
    }
}