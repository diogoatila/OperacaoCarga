using Microsoft.EntityFrameworkCore;
using OperacaoCarga.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperacaoCarga.Data
{
    public class OperacaoCargaContext : DbContext
    {
        public OperacaoCargaContext(DbContextOptions<OperacaoCargaContext> options) : base(options)
        {
            
        }
        public DbSet<Conteiner> Conteineres { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }
    }
}
