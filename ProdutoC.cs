using System;
using System.Globalization;

namespace Curso{
        class Programa{
            static void Main(string[] args) {
                Produto p = new Produto("TV", 500.00, 10);
                
                Console.WriteLine("Entre os dados do produto: ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                string valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade: ");
                string quantidade = int.Parse(Console.ReadLine);

                Produto p = new Produto(quantidade, valor, nome);
                Produto p2 = new Produto ();
                Produto p3 = new Produto {Nome = "TV", Quantidade = "5", Valor = 1300.00};

                Console.WriteLine();
                Console.WriteLine("Dados do produto: " + p);

                Console.WriteLine();
                Console.Write("Digite o número de produtos a ser adicionado: ");
                int qte = int.Parse(Console.ReadLine());
                p.AdicionarProdutos(qte);

                Console.WriteLine();
                Console.WriteLine("Dados atualizados: ");

                Console.WriteLine();
                Console.Write("Digite o número de produtos a ser removido do estoque: ");
                qte = int.Parse(Console.ReadLine());
                p.RemoverProdutos(qte);

                Console.WriteLine();
                Console.WriteLine("Dados atualizados: ");

            }
      }
}
