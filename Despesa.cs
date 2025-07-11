namespace CSharp_Linq
{
    public class Despesa
        {
            public string Descricao { get; set; }
            public decimal Valor { get; set; }
            public DateTime Vencimento { get; set; }
     
            // Sobreescreveu o método ToString
            public override string ToString() => $"{Descricao.PadRight(20, ' ')} - {Vencimento.ToString("dd/MM/yyyy")} - {Valor:C2}";
        }
}