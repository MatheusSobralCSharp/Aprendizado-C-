using System;
using System.Globalization;

namespace Curso{
        class Programa{
            static void Main(string[] args) {
                //float x = 4.5f;

                //double y = x;

                //Console.WriteLine(y);

                double a;
                int b;

                a = 5.1;
                b = (int)a;

                double resultado = (double) a / b;
                Console.WriteLine(resultado);
            }
        }
}

