using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 2.10.
            Po wykonaniu przedstawionego ni¿ej kodu programu zmienna gestoscZaludnienia
            przyjmie wartoœæ 0. Odpowiedz dlaczego i zmieñ program (w linii, gdzie jest obliczana
            zmienna gestoscZaludnienia) tak, aby wartoœæ tej zmiennej wynosi³a 0,1 (czyli 10/100):

            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = osoby/powierzchnia;
            Console.WriteLine(gestoscZaludnienia);
        */

        static void Main(string[] args) {

            int powierzchnia = 100, osoby = 10;
            double gestoscZaludnienia = osoby / powierzchnia;
            Console.WriteLine(gestoscZaludnienia);

            // Rozwi¹zanie:
            gestoscZaludnienia = (double) osoby / powierzchnia;
            Console.WriteLine(gestoscZaludnienia);

            Console.ReadKey();
        }
    }
}
