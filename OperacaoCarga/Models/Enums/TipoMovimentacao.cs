using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperacaoCarga.Models.Enums
{
    public enum TipoMovimentacao : int
    {
        Embarque = 1,
        Descarga = 2,
        GateIn = 3,
        GateOut = 4,
        PosicionamentoPilha = 5,
        Pesagem = 6,
        Scanner = 7

    }
}
