using TreinoHeranca.Classes;

internal class Program
{
    private static void Main(String[] args)
    {
        var pagamento = new PagamentoCredito
        (
            valor: 150
            ,dataPagamento: "09/02/2023"
        );
        pagamento.CalcularTaxa();
    }
}