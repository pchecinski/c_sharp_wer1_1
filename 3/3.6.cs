using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_wer1_1 {
    class Program {
        /* Zadanie 3.6.
            Napisz program, który oblicza wskaŸnik masy cia³a bmi. Program ma prosiæ
            u¿ytkownika o podanie wagi w kg oraz wzrostu w metrach. 

            a) Po obliczeniu wskaŸnika bmi program powinien wyœwietlaæ stosown¹ informacjê w
            zale¿noœci od wartoœci wskaŸnika:
            < 18,5 – niedowaga,
            18,5–24,99 – wartoœæ prawid³owa,
            ? 25,0 – nadwaga.

            b) Korzystaj¹c z Wikipedii rozszerz program, tak aby wyœwietla³ komentarz wed³ug
            poszerzonej klasyfikacji zakresów wskaŸnika bmi
        */

        static void Main(string[] args) {

            double weight, height;
            Console.Write("Podaj  wagê [kg]: ");
            Double.TryParse(Console.ReadLine(), out weight);

            Console.Write("Podaj wzrost [m]: ");
            Double.TryParse(Console.ReadLine(), out height);

            double bmi = weight / Math.Pow(height, 2);
            

            string info;

            // a)
            // info = (bmi >= 25.0) ? "nadwaga" : (bmi < 18.5) ? "niedowaga" : "wartoœæ prawid³owa";

            /* b) https://pl.wikipedia.org/wiki/Wska%C5%BAnik_masy_cia%C5%82a
            < 16,0 – wyg³odzenie
            16,0–16,99 – wychudzenie(spowodowane czêsto przez ciê¿k¹ chorobê lub anoreksjê)
            17,0–18,49 – niedowagê
            18,5–24,99 – wartoœæ prawid³ow¹
            25,0–29,99 – nadwagê
            30,0–34,99 – I stopieñ oty³oœci
            35,0–39,99 – II stopieñ oty³oœci(oty³oœæ kliniczna)
            ? 40,0 – III stopieñ oty³oœci(oty³oœæ skrajna)
            */

            if(bmi < 16.0) {
                info = "wyg³odzenie";
            }
            else if(bmi < 17.0) {
                info = "wychudzenie";
            }
            else if (bmi < 19.0) {
                info = "niedowaga";
            }
            else if (bmi < 25.0) {
                info = "wartoœæ prawid³owa";
            }
            else if (bmi < 30.0) {
                info = "I stopieñ oty³oœci";
            }
            else if (bmi < 35.0) {
                info = "II stopieñ oty³oœci (oty³oœæ kliniczna)";
            }
            else if (bmi < 40.0) {
                info = "II stopieñ oty³oœci (oty³oœæ kliniczna)";
            }
            else {
                info = "III stopieñ oty³oœci (oty³oœæ skrajna)";
            }


            Console.WriteLine("BMI = {0}\nKomentarz: {1}", bmi, info);

            Console.ReadKey();
        }
    }
}
