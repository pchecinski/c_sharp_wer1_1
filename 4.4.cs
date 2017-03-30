using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 4.4.
            Napisz program, kt�ry podaje, ile jest liczb pierwszych w tablicy 100 elementowej typu
            int. Tablic� nale�y wype�ni� losowymi warto�ciami.
        */

        static bool isPrime(int number) {

            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i) {
                if (number % i == 0) return false;
            }

            return true;
        }

        static void Main(string[] args) {

            Random rand = new Random();
            int n = 1000, primes = 0; ;
            int[] array = new int[n];

            for (int i = 0; i < n; i++) {
                array[i] = rand.Next(1, 1000);
            }

            foreach(int i in array) {
                if(isPrime(i)) {
                    Console.WriteLine(i);
                    primes++;
                }
            }

            Console.WriteLine("W tablicy znajduje si� {0} liczb pierwszych", primes);  
            Console.ReadKey();
        }
    }
}