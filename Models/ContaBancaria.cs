namespace SistemaBancario.Models
{
    public abstract class ContaBancaria
    {
        private string _numeroConta;
        private decimal _saldo;

        public string NumeroConta
        {
            get => _numeroConta;
            protected set => _numeroConta = value;
        }
        public decimal saldo
        {
            get => _saldo;
            protected set => _saldo = value < 0 ? 0 : value;
        }

        public string NomeTitular { get; set; }

        public List<string> ExtratoTransacoes { get; set; } = new List<string>();

        //Construtor da classe base
        protected ContaBancaria(string numeroConta, string nomeTitular, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            saldo = saldoInicial;
            ExtratoTransacoes.Add($"Conta criada com saldo incial de: R$ {saldoInicial:F2}");
        }
}
