using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.14.
            Liczba N jest doskona�a, gdy jest r�wna sumie swych podzielnik�w mniejszych od niej
            samej np. 6=1+2+3=6 � jest liczb� doskona��. Napisz program znajduj�cy liczby doskona�e w
            przedziale <1,n>, gdzie n podaje u�ytkownik.
        */

        static void Main(string[] args) {

            int n;
            Console.Write("Podaj g�rn� granic� przedzia�u: ");
            int.TryParse(Console.ReadLine(), out n);

            for(int i = 1; i < n; i++) {

                int sum = 0; // suma dzielnik�w
                for(int j = 1; j < i; j++) {
                    if(i % j == 0) {
                        sum += j;
                    }
                }

                if (i == sum) {
                    Console.WriteLine("Liczba {0} jest liczb� doskona��", i);
                }
            }

            Console.ReadKey();
        }
    }
}