using System;

namespace parte1 {
    class Programa {
        static void Main(string[] args){
            double x, y, calculo;

            Console.Write("Coloca o primeiro número: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Coloca o segundo número: ");
            y = int.Parse(Console.ReadLine());
            calculo = ( x + y ) / 3.0;
            Console.WriteLine("Resultado = " + calculo);
        }
    }
}