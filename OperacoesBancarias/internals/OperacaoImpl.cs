using OperacoesBancarias.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesBancarias.internals
{
    class OperacaoImpl : Operacao
    {
        string Operacao.OperacaoDeposito(Conta destino, double valor)
        {
            throw new NotImplementedException();
        }

        string Operacao.OperacaoExtrato(Conta conta)
        {
            throw new NotImplementedException();
        }

        string Operacao.OperacaoSaque(Conta destino, double valor)
        {
            throw new NotImplementedException();
        }

        string Operacao.OperacaoTransferencia(Conta origem, Conta destino, double valor)
        {
            throw new NotImplementedException();
        }

        public Boolean VerificaSeHaSaldo(double valor, Conta origem)
        {
            if (origem.Saldo >= valor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
