using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 2.9.
            Jak¹ wartoœæ przyjm¹ zmienne u¿yte w programie po wykonaniu poni¿szych instrukcji?
            Najpierw ustal wartoœci zmiennych, a dopiero póŸniej sprawdŸ wynik uruchamiaj¹c program.

            a) wynik=False x=2 y=4 z=2
            b) wynik=False x=2 y=5 z=2
            c) wynik=False x=2 y=5 z=1
            d) wynik=True x=1 y=3 z=4
            e) wynik=True x=1 y=4 z=4
            f) wynik=True x=1 y=4 z=5
        */

        static void Main(string[] args) {

            { // a)
                int x = 1, y = 4, z = 2;
                bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
                Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            }
            { // b)
                int x = 1, y = 4, z = 2;
                bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
                Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            }
            { // c)
                int x = 1, y = 4, z = 2;
                bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
                Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            }
            { // d)
                int x = 1, y = 3, z = 4;
                bool wynik = (x == 1 || y++ > 2 || ++z > 0);
                Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            }
            { // e)
                int x = 1, y = 3, z = 4;
                bool wynik = (x == 1 | y++ > 2 || ++z > 0);
                Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            }
            { // f)
                int x = 1, y = 3, z = 4;
                bool wynik = (x == 1 | y++ > 2 | ++z > 0);
                Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            }

            Console.ReadKey();
        }
    }
}
