using System;
using System.Globalization;

namespace Curso{
        class Programa{
            static void Main(string[] args) {

                char genero = 'F';
                int idade = 30;
                double saldo = 10.323923;
                string nome = "Jonas";

                Console.WriteLine("{0} tem {1} e tem saldo igual a {2} reais", nome, idade, saldo);
                Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
                Console.WriteLine(nome + "tem" + idade + "anos" + saldo.ToString("F2"));
            }
        }
}

