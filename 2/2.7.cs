using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 2.7.
            Co wy�wietli si� na ekranie po wykonaniu poni�szych instrukcji. Najpierw oblicz
            warto�ci zmiennych, a dopiero p�niej sprawd� wynik uruchamiaj�c program.
            int x, y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
            Console.WriteLine(++y); 

            Odpowied�: 7
        */

        static void Main(string[] args) {

            int x, y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
            Console.WriteLine(++y);

            Console.ReadKey();
        }
    }
}
