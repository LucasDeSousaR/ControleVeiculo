using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace ControleVeiculo.Models
{
    public class Veiculo
    {
        [Key]
        public int COD { get; set; }
        public string ImagemUrl { get; set; }
        public string MODELO { get; set; }
        public string MARCA { get; set; }
        public int ANO { get; set; }
        public double PRECO { get; set; }
    }
}