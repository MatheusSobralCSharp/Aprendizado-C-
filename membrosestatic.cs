using System;
using System.Globalization;

namespace Curso{
    class Membros{

        static double Pi = 3.14;
        static void Main(String[] args){
            Console.Write("Entre o valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            double circ = Circunferencia(raio);
            double volume = Volume(raio);
            Console.WriteLine("Circunferência:" + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi:" + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        
        static double Circunferencia(double r) {
            return 2.0 * Pi * r;

        }
        
        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * r * r * r;
        }

    }
}