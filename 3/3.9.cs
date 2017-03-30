using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.9.
            Napisz program, którego efektem dzia³ania bêd¹ nastêpuj¹ce „figury” utworzone ze
            znaku gwiazdki (*). Liczbê wyœwietlanych wierszy podaje u¿ytkownik. 

            a)      b)      c)      d)
            *       ****       *    ****
            **      ***       **    *  *
            ***     **       ***    *  *
            ****    *       ****    ****
        */

        static void Main(string[] args) {

            int n;
            Console.Write("Podaj liczbê wierszy: ");
            int.TryParse(Console.ReadLine(), out n);
            
            // a)
            for (int i = 0; i < n; i++) {
                for (int j = 0; j <= i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // b)
            for (int i = n - 1; i >= 0; i--) {
                for (int j = 0; j <= i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // c)
            for (int i = 1; i <= n; i++) {
                for(int j = n - i; j > 0; j--) {
                   Console.Write(" ");
                }

                for (int j = 1; j <= i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // d)
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if(i == 0 || i == n - 1 || j == 0 || j == n - 1) {
                        Console.Write("*");
                    }
                    else {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}