using OperacaoCarga.Models.Enums;
using System;


namespace OperacaoCarga.Models
{
    public class Movimentacao
    {
        public int ID { get; set; }
        public TipoMovimentacao TipoMovimentacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
       
        public Conteiner Conteiner { get; set; }
    }
}
