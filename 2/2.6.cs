using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 2.6.
            Jak� warto�� b�dzie mia�a zmienna x po wykonaniu poni�szych instrukcji? Najpierw
            oblicz warto�ci zmiennych, a dopiero p�niej sprawd� wynik uruchamiaj�c program.
            int x, y = 4;
            x = (y -= 2);
            x = y++;
            x = y--; 

            Odpowied�: 3
        */

        static void Main(string[] args) {

            int x, y = 4;
            x = (y -= 2);
            x = y++;
            x = y--;

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
