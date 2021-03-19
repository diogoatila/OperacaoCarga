using OperacaoCarga.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OperacaoCarga.Models
{
    public class Conteiner
    {
        public int ID { get; set; }

        [StringLength (45)]
        public string Cliente { get; set; }

        [StringLength (11)]
        public string NumeroConteiner { get; set; }

        public TipoConteiner TipoConteiner { get; set; }
        public StatusConteiner StatusConteiner { get; set; }
        public CategoriaConteiner CategoriaConteiner { get; set; }

        public virtual List<Movimentacao> Movimentacoes { get; set; }
    }
}
