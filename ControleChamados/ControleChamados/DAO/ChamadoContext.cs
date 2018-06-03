using ControleChamados.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ControleChamados.DAO
{
    public class ChamadoContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Chamado> Chamados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chamado>().HasRequired(c => c.Usuario);
        }
    }
}