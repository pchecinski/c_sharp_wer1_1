using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.12.
            Napisz program pobieraj¹cy od u¿ytkownika liczby ca³kowite. Program ma pobieraæ te
            liczby do czasu, gdy u¿ytkownik wprowadzi wartoœæ 0 (zero). Wynikiem dzia³ania programu
            ma byæ informacja o sumie wprowadzonych przez u¿ytkownika liczb.
        */

        static void Main(string[] args) {

            int i = 1;
            while (int.Parse(Console.ReadLine()) != 0) {
                i++;

            }
            Console.WriteLine("Wprowadzono {0} liczb", i);
            Console.ReadKey();
        }
    }
}