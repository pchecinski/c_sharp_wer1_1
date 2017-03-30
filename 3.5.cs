using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.5.
            Napisz program obliczaj¹cy liczbê pierwiastków równania kwadratowego. Program ma
            prosiæ u¿ytkownika o podanie wspó³czynników równania, a nastêpnie ma wyœwietliæ
            stosowny komunikat. 
        */

        static void Main(string[] args) {

            // Kod zadania 2.2
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            double A, B, C;
            Console.Write("Podaj wspó³czynnik A: ");
            Double.TryParse(Console.ReadLine(), out A);

            Console.Write("Podaj wspó³czynnik B: ");
            Double.TryParse(Console.ReadLine(), out B);

            Console.Write("Podaj wspó³czynnik C: ");
            Double.TryParse(Console.ReadLine(), out C);

            double delta = Math.Pow(B, 2) - (4 * A * C);
            Console.WriteLine("? = {0}", delta);

            if (delta > 0) {
                Console.WriteLine("Równanie ma dwa pierwiastki");
            }
            else if (delta == 0) {
                Console.WriteLine("Równanie ma jeden pierwiastek");
            }
            else {
                Console.WriteLine("Równanie nie ma pierwiastków");
            }


            Console.ReadKey();
        }
    }
}
    