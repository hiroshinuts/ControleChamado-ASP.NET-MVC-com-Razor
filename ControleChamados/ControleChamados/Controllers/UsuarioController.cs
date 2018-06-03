using ControleChamados.DAO;
using ControleChamados.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleChamados.Controllers
{
    public class UsuarioController : Controller
    {
        private UsuarioDAO usuarioDAO;

        //Intancia Usuario DAO via Ninject
        public UsuarioController(UsuarioDAO usuarioDAO)
        {
            this.usuarioDAO = usuarioDAO;
        }
        // GET: Usuario
        public ActionResult Form()
        {

            return View();
        }

        public ActionResult Adiciona(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuarioDAO.Adiciona(usuario);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Form", usuario);
            }
        }

        public ActionResult Index()
        {
            IList<Usuario> usuarios = usuarioDAO.Lista();
            return View(usuarios);
        }
    }
}