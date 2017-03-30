using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.4.
            Napisz program � prosty kalkulator, kt�ry wczytuje od u�ytkownika warto�ci dw�ch
            zmiennych typu double oraz znak operacji (+ lub � lub * lub /), a nast�pnie wy�wietla wynik
            operacji dla podanych warto�ci. Przyk�adowo u�ytkownik wprowadzi� znak �+� i liczby 1,5
            oraz 2,5, program powinien wy�wietli� sum� obu liczb, czyli 4,0.
        */

        static void Main(string[] args) {

            char expression;
            double num1, num2;
            Console.WriteLine("Podaj znak operacji [dozwolone znaki: +-*/]: ");
            char.TryParse(Console.ReadLine(), out expression);

            Console.Write("Wprowad� pierwsz� liczb�: ");
            double.TryParse(Console.ReadLine(), out num1);
            Console.Write("Wprowad� drug� liczb�: ");
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
                    Console.WriteLine("Nieprawid�owa operacja! ({0})", expression);
                    return;
            }

            Console.WriteLine("Wynik dzia�ania: {0} {1} {2} = {3}", num1, expression, num2, result);

            Console.ReadKey();
        }
    }
}
