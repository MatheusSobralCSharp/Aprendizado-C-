using System;
using System.Globalization;

namespace Curso{
        class Programa{
            static void Main(string[] args) {
                string frase = Console.ReadLine();
                string x = Console.ReadLine();
                string y = Console.ReadLine();
                string z = Console.ReadLine();

                //Split
                //string[] vet = s.Split(' ');
                //string p1 = vet[0];
                //string p2 = vet[1];
                //string p3 = vet[2];

                string s = Console.ReadLine();

                string[] v = s.Split(' ');
                string[] a = v[0];
                string[] b = v[1];
                string[] c = v[2];
 
                Console.WriteLine("Bom dia!" + frase);
            }
        }
}

