using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.4.
            Napisz program – prosty kalkulator, który wczytuje od u¿ytkownika wartoœci dwóch
            zmiennych typu double oraz znak operacji (+ lub – lub * lub /), a nastêpnie wyœwietla wynik
            operacji dla podanych wartoœci. Przyk³adowo u¿ytkownik wprowadzi³ znak „+” i liczby 1,5
            oraz 2,5, program powinien wyœwietliæ sumê obu liczb, czyli 4,0.
        */

        static void Main(string[] args) {

            char expression;
            double num1, num2;
            Console.WriteLine("Podaj znak operacji [dozwolone znaki: +-*/]: ");
            char.TryParse(Console.ReadLine(), out expression);

            Console.Write("WprowadŸ pierwsz¹ liczbê: ");
            double.TryParse(Console.ReadLine(), out num1);
            Console.Write("WprowadŸ drug¹ liczbê: ");
            double.TryParse(Console.ReadLine(), out num2);

            double result;

            switch(expression) {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    result = num1 / num2; // bez walidacji czy num2 != 0
                    break;

                default:
                    Console.WriteLine("Nieprawid³owa operacja! ({0})", expression);
                    return;
            }

            Console.WriteLine("Wynik dzia³ania: {0} {1} {2} = {3}", num1, expression, num2, result);

            Console.ReadKey();
        }
    }
}
