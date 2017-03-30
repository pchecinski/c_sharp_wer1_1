using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 4.3.
            Napisz program wy�wietlaj�cy informacje o wype�nionej przez u�ytkownika tablicy nelementowej:
            > warto�� i pozycja najwi�kszego elementu,
            > warto�� i pozycja najmniejszego elementu,
            > �rednia warto�ci wszystkich element�w tablicy,
            > liczba warto�ci dodatnich w tablicy.
        */

        static void Main(string[] args) {

            int n;
            Console.Write("Podaj rozmiar tablicy: ");
            int.TryParse(Console.ReadLine(), out n);

            int[] array = new int[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Podaj warto�� [{0}/{1}]: ", i + 1, n);
                int.TryParse(Console.ReadLine(), out array[i]);
            }

            Console.WriteLine("Zawarto�� utworzonej tablicy: " + string.Join(", ", array));
            Console.WriteLine();


            int maxIndex = -1, maxValue = int.MinValue, minIndex = -1, minValue = int.MaxValue, sum = 0, positiveCount = 0;
            for (int i = 0; i < n; i++) {
                // Max
                if (array[i] > maxValue) {
                    maxValue = array[i];
                    maxIndex = i;
                }

                // Min
                if (array[i] < minValue) {
                    minValue = array[i];
                    minIndex = i;
                }

                // Avg
                sum += array[i];

                // Positive
                if (array[i] > 0) {
                    positiveCount++;
                }
            }

            Console.WriteLine("Warto�� i pozycja najwi�kszego elementu: array[{0}] = {1}", maxIndex, maxValue);
            Console.WriteLine("Warto�� i pozycja najmniejszego elementu: array[{0}] = {1}", minIndex, minValue);
            Console.WriteLine("�rednia warto�ci wszystkich element�w tablicy: {0}", (double) sum / n);
            Console.WriteLine("Liczba warto�ci dodatnich w tablicy: {0}", positiveCount);
            Console.ReadKey();
        }
    }
}