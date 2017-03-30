using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.8.
            Pobierz od u�ytkownika warto�� �redniej ocen. Program ma wy�wietla� informacje o
            wysoko�ci przys�uguj�cego stypendium zgodnie z poni�sz� tabel�:

            Od   Do   Kwota
            2,00 3,99 0,00 z�
            4,00 4,79 350,00 z�
            4,80 5,00 550,00 z�
        */

        static void Main(string[] args) {

            double avg;
            Console.Write("Podaj �redni� ocen: ");
            double.TryParse(Console.ReadLine(), out avg);

            Console.WriteLine("Przys�uguje stypendium w kwocie: {0} z�",  avg < 4 ? "0,00" : avg < 4.8 ? "350,00" : "550,00");
            Console.ReadKey();
        }
    }
}