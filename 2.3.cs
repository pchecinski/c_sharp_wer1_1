using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 2.3.
            Napisz program, kt�ry oblicza wska�nik masy cia�a BMI. Program ma prosi�
            u�ytkownika o podanie wagi w kilogramach oraz wzrostu w metrach.
        */

        static void Main(string[] args) {

            double weight, height;
            Console.Write("Podaj  wag� [kg]: ");
            Double.TryParse(Console.ReadLine(), out weight);

            Console.Write("Podaj wzrost [m]: ");
            Double.TryParse(Console.ReadLine(), out height);

            Console.WriteLine("BMI = {0}", weight / Math.Pow(height, 2));

            Console.ReadKey();
        }
    }
}
