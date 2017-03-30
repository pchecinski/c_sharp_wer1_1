using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
		/* Zadanie 2.1.
            Napisz program przeliczaj¹cy temperaturê w stopniach Celsjusza na temperaturê w
            stopniach Fahrenheita. Program ma prosiæ u¿ytkownika o podanie temperatury w stopniach
            Celsjusza.
        */

        static void Main(string[] args) {

            double C;
            Console.Write("Podaj temperaturê w °C: ");
            Double.TryParse(Console.ReadLine(), out C);
            Console.WriteLine("Temperatura w °F: {0}", 32 + (9.0 / 5.0 * C));

            Console.ReadKey();
        }
    }
}
