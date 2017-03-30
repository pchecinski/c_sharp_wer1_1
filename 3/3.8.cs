using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.8.
            Pobierz od u¿ytkownika wartoœæ œredniej ocen. Program ma wyœwietlaæ informacje o
            wysokoœci przys³uguj¹cego stypendium zgodnie z poni¿sz¹ tabel¹:

            Od   Do   Kwota
            2,00 3,99 0,00 z³
            4,00 4,79 350,00 z³
            4,80 5,00 550,00 z³
        */

        static void Main(string[] args) {

            double avg;
            Console.Write("Podaj œredni¹ ocen: ");
            double.TryParse(Console.ReadLine(), out avg);

            Console.WriteLine("Przys³uguje stypendium w kwocie: {0} z³",  avg < 4 ? "0,00" : avg < 4.8 ? "350,00" : "550,00");
            Console.ReadKey();
        }
    }
}