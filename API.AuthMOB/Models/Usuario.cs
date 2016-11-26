using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.AuthMOB.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nickname { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }
    }
}