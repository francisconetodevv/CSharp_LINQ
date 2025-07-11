using System.Diagnostics;
using Microsoft.VisualBasic;

namespace CSharp_Linq
{
    class Program
    {
        private static List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Notebook", Preco = 8000, Categoria = "Informática"},
            new Produto { Nome = "Monitor", Preco = 1000, Categoria = "Informática"},
            new Produto { Nome = "Cama", Preco = 2000, Categoria = "Móveis"},
            new Produto { Nome = "Armário", Preco = 3000, Categoria = "Móveis"}
        };

        private static List<Promocao> promocoes = new List<Promocao>
        {
            new Promocao {Categoria = "Informática", Desconto = 10},
            new Promocao {Categoria = "Moveis", Desconto = 20}
        };

        static void Main(string[] args)
        {
            // Join entre tabelas
            var resultado = from produto in produtos
                            join promocao in promocoes on produto.Categoria equals promocao.Categoria
                            select new
                            {
                                produto.Nome,
                                produto.Categoria,
                                precoComDesconto = produto.Preco * (1 - (promocao.Desconto / 100))
                            };

            foreach (var p in resultado)
            {
                Console.WriteLine($"{p.Nome} - {p.Categoria} - {p.precoComDesconto}");
            }
        }
    }
}