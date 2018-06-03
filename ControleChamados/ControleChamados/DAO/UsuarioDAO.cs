using ControleChamados.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleChamados.DAO
{
    public class UsuarioDAO
    {
        private ChamadoContext context;


        //Passo o contexto no construtor, para não precisar ficar instanciando , via Injecao de dependencia
        //Ninject
        public UsuarioDAO(ChamadoContext context)
        {
            this.context = context;
        }

        public void Adiciona(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public IList<Usuario> Lista()
        {
            return context.Usuarios.ToList();
        }
               
    }
}