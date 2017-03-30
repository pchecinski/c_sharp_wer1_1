using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.7.
            Wykonaj program z przyk³adu 3.8 (poni¿ej kodu) z u¿yciem instrukcji switch..case (zamiast if..else). 
        */

        static void Main(string[] args) {

            Console.WriteLine("Wpisz nr dnia tygodnia");
            string numer = Console.ReadLine();

            switch(numer) {
                case "1": Console.WriteLine("Poniedzia³ek"); break;
                case "2": Console.WriteLine("Wtorek"); break;
                case "3": Console.WriteLine("Œroda"); break;
                case "4": Console.WriteLine("Czwartek"); break;
                case "5": Console.WriteLine("Pi¹tek"); break;
                case "6": Console.WriteLine("Sobota"); break;
                case "7": Console.WriteLine("Niedziela"); break;
                default: Console.WriteLine("Nie ma takiego dnia tygodnia"); break;
            }


            Console.ReadKey();
        }
    }
}

/*
    Przyk³ad 3.8.
    static void Main(string[] args)
    {
     Console.WriteLine("Wpisz nr dnia tygodnia");
     string numer = Console.ReadLine();
     if (numer == "1")
     Console.WriteLine("Poniedzia³ek");
     else if (numer == "2")
     Console.WriteLine("Wtorek");
     else if (numer == "3")
     Console.WriteLine("Œroda");
     else if (numer == "4")
     Console.WriteLine("Czwartek");
     else if (numer == "5")
     Console.WriteLine("Pi¹tek");
     else if (numer == "6")
     Console.WriteLine("Sobota");
     else if (numer == "7")
     Console.WriteLine("Niedziela");
     else
     Console.WriteLine("Nie ma takiego dnia tygodnia");
     Console.ReadKey();
    }
*/
