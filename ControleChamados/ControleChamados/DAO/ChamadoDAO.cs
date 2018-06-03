using ControleChamados.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleChamados.DAO
{
    public class ChamadoDAO
    {
        private ChamadoContext context;

        public ChamadoDAO(ChamadoContext context)
        {
            this.context = context;
        }

        public void Adicona(Chamado chamado)
        {
            context.Chamados.Add(chamado);
            context.SaveChanges();
        }

        public IList<Chamado> Lista()
        {
            return context.Chamados.ToList();
        }
    }
}