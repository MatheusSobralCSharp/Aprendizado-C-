using System;
using System.Globalization;

namespace Curso{
        class Programa{
            static void Main(string[] args) {
               //Parse converte número para inteiro
               int n1 = int.Parse(Console.ReadLine());
               char ch = char.Parse(Console.ReadLine());
               double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

               string[] vet = Console.ReadLine().Split(' ');
               string nome = vet[0];
               char sexo = char.Parse(vet[1]);
               int idade = int.Parse(vet[2]);
               double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

               Console.WriteLine("Você digitou: ");
               Console.WriteLine(n1);
               Console.WriteLine(ch);
               Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
               Console.WriteLine(nome);
               Console.WriteLine(idade);
               Console.WriteLine(sexo);
               Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
}

