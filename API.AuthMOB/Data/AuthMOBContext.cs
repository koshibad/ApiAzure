using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API.AuthMOB.Data
{
    public class AuthMOBContext : DbContext
    {
        public AuthMOBContext() : base("name=DefaultConnection") { }

        public System.Data.Entity.DbSet<API.AuthMOB.Models.Usuario> Usuarios { get; set; }
    }
}