using OperacoesBancarias.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesBancarias.internals
{
    interface Operacao
    {
        string OperacaoTransferencia(Conta origem, Conta destino, double valor);

        string OperacaoDeposito(Conta destino, double valor);

        string OperacaoSaque(Conta destino, double valor);

        string OperacaoExtrato(Conta conta);
    }
}
