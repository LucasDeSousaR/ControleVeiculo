using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ControleVeiculo.Models
{
    public class VeiculosContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }
    }

}