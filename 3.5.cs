using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.5.
            Napisz program obliczaj�cy liczb� pierwiastk�w r�wnania kwadratowego. Program ma
            prosi� u�ytkownika o podanie wsp�czynnik�w r�wnania, a nast�pnie ma wy�wietli�
            stosowny komunikat. 
        */

        static void Main(string[] args) {

            // Kod zadania 2.2
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            double A, B, C;
            Console.Write("Podaj wsp�czynnik A: ");
            Double.TryParse(Console.ReadLine(), out A);

            Console.Write("Podaj wsp�czynnik B: ");
            Double.TryParse(Console.ReadLine(), out B);

            Console.Write("Podaj wsp�czynnik C: ");
            Double.TryParse(Console.ReadLine(), out C);

            double delta = Math.Pow(B, 2) - (4 * A * C);
            Console.WriteLine("? = {0}", delta);

            if (delta > 0) {
                Console.WriteLine("R�wnanie ma dwa pierwiastki");
            }
            else if (delta == 0) {
                Console.WriteLine("R�wnanie ma jeden pierwiastek");
            }
            else {
                Console.WriteLine("R�wnanie nie ma pierwiastk�w");
            }


            Console.ReadKey();
        }
    }
}
    