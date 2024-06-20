using System;
using System.Globalization;

namespace Curso{
        class Programa{
            static void Main(string[] args) {

                char genero = 'F';
                int idade = 30;
                double saldo = 10.323923;
                string nome = "Jonas";

                Console.WriteLine("Bom Dia");
                Console.WriteLine("Boa tarde");
                Console.WriteLine("Boa noite!");
                Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture));
                
            }
        }
}

