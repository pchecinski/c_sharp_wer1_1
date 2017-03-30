using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 4.1.
            Napisz program, kt�ry pozwoli zape�ni� n�elementow� tablic� jednowymiarow� liczb
            ca�kowitych warto�ciami podanymi przez u�ytkownika. Na pocz�tku dzia�ania programu
            u�ytkownik podaje liczb� element�w tablicy, a nast�pnie poszczeg�lne warto�ci jej
            element�w. Po wype�nieniu ca�ej tablicy program powinien wypisa� je w oknie konsoli.
        */

        static void Main(string[] args) {

            int n;
            Console.Write("Podaj rozmiar tablicy: ");
            int.TryParse(Console.ReadLine(), out n);

            int[] array = new int[n];

            for(int i = 0; i < n; i++) {
                Console.Write("Podaj warto�� [{0}/{1}]: ", i + 1, n);
                int.TryParse(Console.ReadLine(), out array[i]);
            }

            Console.WriteLine("Zawarto�� utworzonej tablicy: " + string.Join(", ", array));
            Console.ReadKey();
        }
    }
}