using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.11.
            Napisz program obliczaj�cy ile kolejnych liczb ca�kowitych (rozpoczynaj�c od warto�ci 1) nale�y doda� do siebie, aby suma przekroczy�a warto�� 100.
        */

        static void Main(string[] args) {

            int i = 0, sum = 0;
            while (sum < 100) {
                sum += ++i;
            }
            
            Console.WriteLine("Nale�y doda� {0} liczb ca�owitych", i);
            Console.ReadKey();
        }
    }
}