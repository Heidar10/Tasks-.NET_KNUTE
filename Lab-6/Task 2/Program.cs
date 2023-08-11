using System;

namespace Task_2
{
    class Program

    {

        static void Main(string[] args)

        {

            Console.Write("Введите радиус R= ");

            Konus.R = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту H= ");

            Konus.H = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите малый радиус усеченного конуса r= ");

            Konus.r = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите высоту усеченного конуса h= ");

            Konus.h = Convert.ToDouble(Console.ReadLine());

            Konus.PloshOsn(Konus.R);

            Konus.Objem(Konus.H, Konus.R);

            Srezkonus.ObjemSrezKon(Konus.h, Konus.R, Konus.r);

            Console.ReadLine();

        }

    }

    class Konus

    {

        public static double R;

        public static double H;

        public static double r;

        public static double h;

        public static void PloshOsn(double R)

        {

            double S = Math.PI * R * R;

            Console.WriteLine("Площадь основания конуса = {0}", S);

        }

        public static void Objem(double H, double R)

        {

            double V = (Math.PI * R * R * H) / 3;

            Console.WriteLine("Объём конуса = {0}", V);

        }

    }
    class Srezkonus : Konus
    {
        public static void ObjemSrezKon(double h, double R, double r)
        {
            double V_SrezanKon = (Math.PI * h * (R * R + R * r + r * r)) / 3;
            Console.WriteLine("Объём усеченного конуса = {0}", V_SrezanKon);
        }
    }
}
