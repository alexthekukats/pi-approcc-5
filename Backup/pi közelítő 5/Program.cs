using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static double pi = 0;
        static int k = 0;

        static double tag1;
        static double tag2;
        static double tag3;
        static double tag4;

        static double szum = 0;


        static void Main(string[] args) // Rámánudzsan-féle sorok // nagyon gyors
        {

            while (true)
            {
                szum1();

                pi = (Math.Sqrt(8) / 9801) * szum;//

                Console.WriteLine(1/pi);

                Console.ReadKey();
            }
        }

        static void szum1()
        {
            for (int i = 0; i < 1; i++)
            {

                tag1 = (k * 4);
                tag4 = Math.Pow(396, tag1);

                tag1 = fakt(Convert.ToInt32(tag1));
                fakt(1);

                tag2 = 1103 + 26390 * k;

                tag3 = Math.Pow(fakt(k), 4);

                szum += (tag1 * tag2) / (tag3 * tag4);
                k++;
                fakt(1);


                //Console.WriteLine(szum);
            }
        }

        static int fakt(int faktszam)
        {
            int _tag = 1;

            for (int i = 1; i <= faktszam; i++)
            {
                _tag = _tag * i;
            }
            return _tag;
        }

        /*static double osztas(double mit, double mivel)
        {
            double osztas;
            string _mit = Convert.ToString(mit);
            string _mivel = Convert.ToString(mivel);

            string atalakito1 = _mit;
            //string atalakito2;
            atalakito1 = atalakito1.Substring(Math.Abs(_mivel - _mit));
            if (Convert.ToInt32(atalakito1 / _mivel) < 1)
            {
                atalakito1 = atalakito1.Substring(Math.Abs((_mivel - _mit) + 1));
            }


            return osztas;
        }*/

    }
}
