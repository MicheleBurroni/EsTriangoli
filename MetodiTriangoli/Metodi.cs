using System;

namespace LibreriaTriangoli
{
    public class MetodiTriangoli
    {
        public static double MisuraLato()
        {
            Console.WriteLine("Inserire lunghezza lato");
            double l = Convert.ToDouble(Console.ReadLine());
            return l;
        }
        public static string RiconosciTriangoli(double l1, double l2, double l3)
        {
            string risultato = "";
            if (l1 > 0 && l2 > 0 && l3 > 0)
            {
                if (l1 == l2 && l1 == l3)
                {
                    risultato = "Triangolo Equilatero!";
                }
                else if (l1 != l2 && l2 != l3 && l3 != l1)
                {
                    risultato = "Triangolo Scaleno!";
                }
                else
                {
                    risultato = "Triangolo Isoscele!";
                }
            }
            else
                risultato = "IMPOSSIBILE!";
            return risultato;
        }
        public static double Perimetro(double a, double b, double c)
        {
            return a + b + c;
        }
    }
}

