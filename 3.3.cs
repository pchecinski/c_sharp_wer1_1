using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.3.
            Napisz program pobieraj¹cy od u¿ytkownika 3 liczby. Program ma wyœwietliæ wartoœæ
            najwiêkszej z nich.
        */

        static void Main(string[] args) {

            int num1, num2, num3;
            Console.Write("WprowadŸ pierwsz¹ liczbê: ");
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("WprowadŸ drug¹ liczbê: ");
            int.TryParse(Console.ReadLine(), out num2);
            Console.Write("WprowadŸ trzeci¹ liczbê: ");
            int.TryParse(Console.ReadLine(), out num3);

            if (num1 > num2 && num1 > num3) {
                Console.WriteLine("Wartoœæ najwiêkszej liczby to: {0}", num1);
            }
            else if (num2 > num1 && num2 > num3) {
                Console.WriteLine("Wartoœæ najwiêkszej liczby to: {0}", num2);
            }
            else {
                Console.WriteLine("Wartoœæ najwiêkszej liczby to: {0}", num3);
            }

            Console.ReadKey();
        }
    }
}
