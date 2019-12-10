using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class SaldoInsuficienteException : OperacaoFinanceiraException
    {

        public double Saldo { get;}
        public double ValorTentativaSaque { get;}

        public SaldoInsuficienteException(double saldo, double valorTentativaSaque)
            : this($"Tentou sacar {saldo} em um conta que tem apenas {valorTentativaSaque}")
        {
            this.Saldo = saldo;
            this.ValorTentativaSaque = valorTentativaSaque;
        }

        public SaldoInsuficienteException(string message, Exception innerException) : base(message, innerException)
        {

        }

        public SaldoInsuficienteException(string message) : base(message)
        {

        }
    }
}
