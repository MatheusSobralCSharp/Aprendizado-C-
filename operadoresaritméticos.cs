using System;
using System.Globalization;

namespace Curso{
        class Programa{
            static void Main(string[] args) {
                int n1 = 3 + 4 * 2;
                int n2 = (3 + 4) * 2;
                int n3 = 17 % 3;
                double n4 = /*(double)*/ 10.0 / 8.0;

                double a = 1.0, b = -3.0, c = -4.0;

                double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

                double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine(n1);
            }
        }
}

