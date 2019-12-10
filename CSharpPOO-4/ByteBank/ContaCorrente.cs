// using _05_ByteBank;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        private int Agencia { get; }
        public int Numero { get; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidos { get; private set; }


        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0 || numero <= 0)
            {
                throw new System.ArgumentException();
            }
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }


        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new System.ArgumentException("Valor inválido para o saque.");
            }
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException("Saldo Insuficiente para o saque.");
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new System.ArgumentException("Valor inválido para a transferência.");
            }

            try
            {
                this.Sacar(valor);
                contaDestino.Depositar(valor);
            }
            catch (SaldoInsuficienteException e)
            {
                // InnerException
                // Hide internal exception
                ContadorTransferenciasNaoPermitidos++;
                throw new OperacaoFinanceiraException("Exception", e);
            }
        }
    }
}
