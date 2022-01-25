
using System;

namespace Kreis_Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Kreis Rechener";

            Console.WriteLine(" Fläche [1] \n Durchmesser[2] \n Radius [3] \n Umfang [4]");
            string _input = Console.ReadLine();
            int input = int.Parse(_input);
            #region Fläche
            if (input == 1)
            {
                Console.WriteLine("Haben Sie r oder d gegeben? ");
                string _ra = Console.ReadLine();
               
                if (_ra == "d")
                {
                    Console.WriteLine("Was ist d?");
                    string d = Console.ReadLine();
                    double dd = double.Parse(d);
                    KFA(dd);
                }
                else if (_ra == "r")
                {
                    Console.WriteLine("Was ist r?");
                    string r = Console.ReadLine();
                    double rr = double.Parse(r);
                    KFA2(rr);

                }

                else
                {
                    Console.WriteLine("Eingabe war unkorrekt!");
                }
               
            }
            #endregion
            #region Durchmesser
            if (input == 2)
            {

                Console.WriteLine("Wollen Sie den Durchmesser mit U oder mit A ausrechnen?");
                string ua = Console.ReadLine();
                if (ua == "A")
                {
                    Console.WriteLine("Was ist A?");
                    string A = Console.ReadLine();
                    double AA = double.Parse(A);
                    KFD(AA);
                }

                else if (ua == "U")
                {
                    Console.WriteLine("Was ist U?");
                    string U = Console.ReadLine();
                    double UU = double.Parse(U);
                    KFD2(UU);
                }
                else
                {
                    Console.WriteLine("Eingabe war unkorrekt!");
                }
            }
            #endregion
            #region Radius
            if (input == 3)
            {
                Console.WriteLine("Wollen Sie den Radius mit A oder mit U ausrechnen?");
                string au = Console.ReadLine();

                if (au == "A")
                {

                    Console.WriteLine("Was ist A?");
                    string A = Console.ReadLine();
                    double AA = double.Parse(A);

                    KFR(AA);
                }

                else if (au == "U")
                {
                    Console.WriteLine("Was ist U?");
                    string U = Console.ReadLine();
                    double UU = double.Parse(U);

                    KFR2(UU);
                }
                else
                {
                    Console.WriteLine("Eingabe war unkorrekt!");
                }

            }
            #endregion
            #region Umfang
            if (input == 4)
                Console.WriteLine("Wollen Sie den Umfang mit r oder mit d ausrechnen?");
            string rd = Console.ReadLine();

                if (rd == "r")
                {
                    Console.WriteLine("Was ist r?");
                    string r = Console.ReadLine();
                    double rr = double.Parse(r);

                    KFU(rr);
                }

            else if  (rd == "d")
            {
                Console.WriteLine("Was ist d?");
                string d = Console.ReadLine();
                int dd = int.Parse(d);

                KFU2(dd);
            }
            else
            {
                Console.WriteLine("Eingabe war unkorrekt!");
            }
            #endregion
            
            if (input >= 5)
            {
                Console.WriteLine("Diese Eingabe exestiert nicht!");
            }




            static double KFA(double d)
            {
              
                double A = Math.PI * Math.Pow(d, 2) / 4;
                Console.WriteLine("Die Fläche ist: {0}" , A);

                return A;
            }

            static double KFA2(double r)
            {
                double A = Math.PI * Math.Pow(r, 2);
                Console.WriteLine("Die Fläche ist: {0}", A);

                return A;
            }

            static double KFD(double A)
            {

                double d = Math.Sqrt(A * 4 / Math.PI);
                Console.WriteLine("Der Durchmesser ist: {0}", d);
                return d;
            }

            static double KFD2(double U)
            {
                double d = U * Math.PI;
                Console.WriteLine("Der Durchmesser ist: {0}", d);
                return d;
            }

            static double KFR(double A)
            {
                double r = Math.Sqrt(A/Math.PI);
                Console.WriteLine("Der Radius ist: {0}", r);
                return r;
            }

            static double KFR2(double U)
            {
                double r = U / 2 * Math.PI;
                Console.WriteLine("Der Radius ist: {0}" , r);
                return r;
            }

            static double KFU(double r)
            {
                double u = 2 * Math.PI * r;
                Console.WriteLine("Der Umfaing ist: {0}", u);
                return u;
            }

            static double KFU2(double d)
            {
                double u = (22 / 7) * d;
                double uu = Math.Round(u);
                Console.WriteLine("Der Umfang ist: {0}", uu);

                return uu;
            }

            Console.ReadKey();
        }
    }
}
