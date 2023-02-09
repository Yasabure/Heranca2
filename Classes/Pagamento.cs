namespace TreinoHeranca.Classes
{
    public class Pagamento
    {
        public Pagamento(double valor, string dataPagamento)
        {
            this.Valor = valor;
            this.DataPagamento = dataPagamento;
        }
        public double Valor {get ;  set;}
        public string DataPagamento {get ; set;}
        public  virtual void CalcularTaxa()
        {
            Console.WriteLine($"{Valor}");
        }
    }
}