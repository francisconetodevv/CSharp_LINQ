using Microsoft.VisualBasic;

namespace CSharp_Linq
{
    class Program
    {
        // Lista de valores do tipo objeto Despesa
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
            var despesasVencidas = from d in despesas
                                   select d;

            imprimir(despesasVencidas);

            Console.WriteLine("-----------------------");

            // Aplicando filtros 
            var despesasVencidasFiltrada = from d in despesas
                                           where d.Valor < 500
                                           select d;

            imprimir(despesasVencidasFiltrada);

            Console.WriteLine("-----------------------");
            var despesasVencidasData = from d in despesas
                                       where d.Valor < 500 && d.Vencimento <= new DateTime(2021, 10, 10)
                                       select d;

            imprimir(despesasVencidasData);

            Console.WriteLine("-----------------------");
            // Ordenando resultado da consulta
            var despesasOrdenadas = from d in despesas
                                    where d.Valor < 500
                                    orderby d.Valor
                                    select d;

            imprimir(despesasOrdenadas);

            Console.WriteLine("-----------------------");
            var despesasOrdenadasData = from d in despesas
                                        where d.Valor < 500
                                        orderby d.Vencimento descending, d.Valor ascending
                                        select d;

            imprimir(despesasOrdenadasData);
        }

        public static void imprimir(IEnumerable<Despesa> listaDespesas)
        {
            foreach (var d in listaDespesas)
            {
                Console.WriteLine(d);
            }
        }
    }
}