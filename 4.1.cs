using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 4.1.
            Napisz program, który pozwoli zape³niæ n–elementow¹ tablicê jednowymiarow¹ liczb
            ca³kowitych wartoœciami podanymi przez u¿ytkownika. Na pocz¹tku dzia³ania programu
            u¿ytkownik podaje liczbê elementów tablicy, a nastêpnie poszczególne wartoœci jej
            elementów. Po wype³nieniu ca³ej tablicy program powinien wypisaæ je w oknie konsoli.
        */

        static void Main(string[] args) {

            int n;
            Console.Write("Podaj rozmiar tablicy: ");
            int.TryParse(Console.ReadLine(), out n);

            int[] array = new int[n];

            for(int i = 0; i < n; i++) {
                Console.Write("Podaj wartoœæ [{0}/{1}]: ", i + 1, n);
                int.TryParse(Console.ReadLine(), out array[i]);
            }

            Console.WriteLine("Zawartoœæ utworzonej tablicy: " + string.Join(", ", array));
            Console.ReadKey();
        }
    }
}