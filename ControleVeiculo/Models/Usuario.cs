using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleVeiculo.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
    }

}