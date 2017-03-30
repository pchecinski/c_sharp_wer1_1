using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 2.2.
            Napisz program, który oblicza deltę dla równania kwadratowego ax2 + bx + c = 0
            Program ma prosić użytkownika o podanie współczynników równania a, b oraz c.
        */

        static void Main(string[] args) {

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            double A, B, C;
            Console.Write("Podaj współczynnik A: ");
            Double.TryParse(Console.ReadLine(), out A);

            Console.Write("Podaj współczynnik B: ");
            Double.TryParse(Console.ReadLine(), out B);

            Console.Write("Podaj współczynnik C: ");
            Double.TryParse(Console.ReadLine(), out C);

            Console.WriteLine("Δ = {0}", Math.Pow(B, 2) - (4 * A * C));

            Console.ReadKey();
        }
    }
}
