using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.3.
            Napisz program pobieraj�cy od u�ytkownika 3 liczby. Program ma wy�wietli� warto��
            najwi�kszej z nich.
        */

        static void Main(string[] args) {

            int num1, num2, num3;
            Console.Write("Wprowad� pierwsz� liczb�: ");
            int.TryParse(Console.ReadLine(), out num1);
            Console.Write("Wprowad� drug� liczb�: ");
            int.TryParse(Console.ReadLine(), out num2);
            Console.Write("Wprowad� trzeci� liczb�: ");
            int.TryParse(Console.ReadLine(), out num3);

            if (num1 > num2 && num1 > num3) {
                Console.WriteLine("Warto�� najwi�kszej liczby to: {0}", num1);
            }
            else if (num2 > num1 && num2 > num3) {
                Console.WriteLine("Warto�� najwi�kszej liczby to: {0}", num2);
            }
            else {
                Console.WriteLine("Warto�� najwi�kszej liczby to: {0}", num3);
            }

            Console.ReadKey();
        }
    }
}
