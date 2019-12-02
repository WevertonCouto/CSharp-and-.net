using System;
using System.Collections.Generic;
using System.Text;
using ByteBank;

namespace ByteBank
{
    class ContaCorrente
    {
        public int agencia { get; set; };
        public int numero;
        private double saldo;
        public Cliente titular { get; set; }


        public ContaCorrente(int agencia, int numero)
        {
            this.agencia = agencia;
            this.numero = numero;
        }


        public double ObterSaldo() => this.saldo;

        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }
            else this.saldo = saldo;
        }

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente conta)
        {
            if(this.saldo < valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                conta.saldo += valor;
                return true;
            }
        }
    }
}
