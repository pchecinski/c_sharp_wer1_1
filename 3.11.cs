using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.11.
            Napisz program obliczaj¹cy ile kolejnych liczb ca³kowitych (rozpoczynaj¹c od wartoœci 1) nale¿y dodaæ do siebie, aby suma przekroczy³a wartoœæ 100.
        */

        static void Main(string[] args) {

            int i = 0, sum = 0;
            while (sum < 100) {
                sum += ++i;
            }
            
            Console.WriteLine("Nale¿y dodaæ {0} liczb ca³owitych", i);
            Console.ReadKey();
        }
    }
}