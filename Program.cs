using System.Diagnostics;
using Microsoft.VisualBasic;

namespace CSharp_Linq
{
    class Program
    {
        private static List<Despesa> despesas = new List<Despesa>
       {
           // Criando uma lista de objetos em memória
           new Despesa { Descricao = "Internet", Valor = 100, Vencimento = new DateTime(2021, 10, 1) },
           new Despesa { Descricao = "Celular", Valor = 80, Vencimento = new DateTime(2021, 10, 20) },
           new Despesa { Descricao = "Aluguel", Valor = 1200, Vencimento = new DateTime(2021, 10, 18) },
           new Despesa { Descricao = "Contabilidade", Valor = 400, Vencimento = new DateTime(2021, 10, 20) },
       };


        static void Main(string[] args)
        {
            var resultado = from d in despesas
                            select d.Descricao;

            var resultadoDois = from d in despesas
                                select new
                                {
                                    d.Descricao,
                                    ValorComDesconto = d.Valor * 0.9m 
                                };

            foreach (var r in resultado)
            {
                Console.WriteLine(r);
            }

            foreach (var r in resultadoDois)
            {
                Console.WriteLine(r);
            }
        }
    }
}