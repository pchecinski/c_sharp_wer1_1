using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.2.
            Napisz program pobieraj¹cy od u¿ytkownika dwie liczby ca³kowite. Program powinien
            wyœwietlaæ informacjê, czy druga liczba jest dzielnikiem pierwszej.
        */

        static void Main(string[] args) {

            int num1, num2;
            Console.Write("WprowadŸ pierwsz¹ liczbê: ");
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("WprowadŸ drug¹ liczbê: ");
            int.TryParse(Console.ReadLine(), out num2);


            if (num1 % num2 == 0) {
                Console.WriteLine("Liczba {0} jest dzielnikiem liczby {1}", num2, num1);
            }
            else {
                Console.WriteLine("Liczba {0} nie jest dzielnikiem liczby {1}", num2, num1);
            }

            Console.ReadKey();
        }
    }
}
