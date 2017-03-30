using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.6.
            Napisz program, kt�ry oblicza wska�nik masy cia�a bmi. Program ma prosi�
            u�ytkownika o podanie wagi w kg oraz wzrostu w metrach. 

            a) Po obliczeniu wska�nika bmi program powinien wy�wietla� stosown� informacj� w
            zale�no�ci od warto�ci wska�nika:
            < 18,5 � niedowaga,
            18,5�24,99 � warto�� prawid�owa,
            ? 25,0 � nadwaga.

            b) Korzystaj�c z Wikipedii rozszerz program, tak aby wy�wietla� komentarz wed�ug
            poszerzonej klasyfikacji zakres�w wska�nika bmi
        */

        static void Main(string[] args) {

            double weight, height;
            Console.Write("Podaj  wag� [kg]: ");
            Double.TryParse(Console.ReadLine(), out weight);

            Console.Write("Podaj wzrost [m]: ");
            Double.TryParse(Console.ReadLine(), out height);

            double bmi = weight / Math.Pow(height, 2);
            

            string info;

            // a)
            // info = (bmi >= 25.0) ? "nadwaga" : (bmi < 18.5) ? "niedowaga" : "warto�� prawid�owa";

            /* b) https://pl.wikipedia.org/wiki/Wska%C5%BAnik_masy_cia%C5%82a
            < 16,0 � wyg�odzenie
            16,0�16,99 � wychudzenie(spowodowane cz�sto przez ci�k� chorob� lub anoreksj�)
            17,0�18,49 � niedowag�
            18,5�24,99 � warto�� prawid�ow�
            25,0�29,99 � nadwag�
            30,0�34,99 � I stopie� oty�o�ci
            35,0�39,99 � II stopie� oty�o�ci(oty�o�� kliniczna)
            ? 40,0 � III stopie� oty�o�ci(oty�o�� skrajna)
            */

            if(bmi < 16.0) {
                info = "wyg�odzenie";
            }
            else if(bmi < 17.0) {
                info = "wychudzenie";
            }
            else if (bmi < 19.0) {
                info = "niedowaga";
            }
            else if (bmi < 25.0) {
                info = "warto�� prawid�owa";
            }
            else if (bmi < 30.0) {
                info = "I stopie� oty�o�ci";
            }
            else if (bmi < 35.0) {
                info = "II stopie� oty�o�ci (oty�o�� kliniczna)";
            }
            else if (bmi < 40.0) {
                info = "II stopie� oty�o�ci (oty�o�� kliniczna)";
            }
            else {
                info = "III stopie� oty�o�ci (oty�o�� skrajna)";
            }


            Console.WriteLine("BMI = {0}\nKomentarz: {1}", bmi, info);

            Console.ReadKey();
        }
    }
}
