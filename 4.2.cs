using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 4.2.
            Napisz program kopiuj�cy z danej tablicy liczb ca�kowitych tab1 do nowej tablicy tab2
            wy��cznie warto�ci dodatnie. Obie tablice maj� by� jednowymiarowe o rozmiarze r�wnym 10
            (czyli 10-elemetowe). Elementy pierwszej tablicy (tab1) nale�y wpisa� w trakcie deklaracji
            tej tablicy. 
        */

        static void Main(string[] args) {

            Random rand = new Random();
            int n = 10;
            int[] tab1 = new int[n], tab2 = new int[n];

            // Deklaracja 
            for(int i = 0; i < n; i++) {
                tab1[i] = rand.Next(-100, 100);
            }

            // Zadanie
            for (int i = 0, j = 0; i < n; i++) {
                if(tab1[i] > 0) {
                    tab2[j++] = tab1[i];
                } 
            }

            Console.WriteLine("Zawarto�� tab1 tablicy: " + string.Join(", ", tab1));
            Console.WriteLine("Zawarto�� tab2 tablicy: " + string.Join(", ", tab2));
            Console.ReadKey();
        }
    }
}