using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.13.
            Napisz program obliczaj¹cy sumê szeregu W(n)=1 – 2 + 3 – 4 + ...± n, gdzie n jest
            dowoln¹ liczb¹ naturaln¹, któr¹ program ma wczytaæ.
        */

        static void Main(string[] args) {

            int n, sum = 0;
            int.TryParse(Console.ReadLine(), out n);


            for (int i = 1; i <= n; i++) {

                sum += i * (i % 2 == 0 ? -1 : 1);

            }

            Console.WriteLine("Suma szeregu {0} liczb wynosi {1}", n, sum);
            Console.ReadKey();
        }
    }
}