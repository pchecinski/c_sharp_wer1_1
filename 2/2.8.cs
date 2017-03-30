using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 2.8.
            Po wykonaniu poni¿szych linii programu:
             bool x;
             int y = 1, z = 1;
             x = (y == 1 && z++ == 1);
            zmienne przyjm¹ wartoœci:
            a) x=true, y=1, z=2 
            b) x=1, y=1, z=2
            c) x=true, y=1, z=1 
        ->  d) x=2, y=1, z=2.
        */

        static void Main(string[] args) {

            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine("x={0}, y={1}, z={2}", x, y, z);

            Console.ReadKey();
        }
    }
}
