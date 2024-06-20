using System;
using System.Globalization;

namespace Curso {
    class Produto {
        
           public string Nome;

           public double Valor;

           public int Quantidade;

           public Produto(){
          }
          
           public Produto(string nome, double valor, int quantidade){
             Nome = nome;
             Valor = valor;
             Quantidade = quantidade;
           }
            public string GetNome(){
             return nome;
           }

            public void SetNome(string nome){
             if (nome != null && nome.Length > 1) {
                Nome = nome;
             }
            }

            public Produto(string nome, double valor){
              Nome = nome;
              Valor = valor;
              Quantidade = 0;
            }
           public double ValorTotalEmEstoque(){
             return Valor * Quantidade;
           }
           public void AdicionarProdutos(int quantidade) {
             Quantidade = Quantidade += quantidade;
           }

            public void RemoverProdutos(int quantidade) {
             Quantidade = Quantidade -= quantidade;
           }

           public override string ToString(){
            return Nome + ", $ " 
            + Valor.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

           }

        }
}