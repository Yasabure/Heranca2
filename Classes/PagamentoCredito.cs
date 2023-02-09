namespace TreinoHeranca.Classes
{
    public class PagamentoCredito : Pagamento
    {
        public PagamentoCredito
        (
            double valor
            ,string dataPagamento
        )
        :
        base
        (
            valor, dataPagamento
        )
        {     
        }
        public override void CalcularTaxa()
        {
            Console.WriteLine($"O valor é {this.Valor+ (this.Valor /100 * 4)}");
        }
    }
}