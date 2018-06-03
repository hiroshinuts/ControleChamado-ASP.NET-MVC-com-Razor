using ControleChamados.DAO;
using ControleChamados.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleChamados.Controllers
{
    public class ChamadoController : Controller
    {
        private ChamadoDAO chamadoDAO;
        private UsuarioDAO usuarioDAO;

        public ChamadoController(ChamadoDAO chamadoDAO, UsuarioDAO usuarioDAO)
        {
            this.chamadoDAO = chamadoDAO;
            this.usuarioDAO = usuarioDAO;
        }
        // GET: Chamado
        public ActionResult Form()
        {
            ViewBag.Usuarios = usuarioDAO.Lista();
            return View();
        }

        public ActionResult Adiciona(Chamado chamado)
        {
            if (ModelState.IsValid)
            {
                chamadoDAO.Adicona(chamado);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Usuarios = usuarioDAO.Lista();
                return View("Form", chamado);
            }
        }

        public ActionResult Index()
        {
            IList<Chamado> chamado = chamadoDAO.Lista();
            return View(chamado);
        }
    }
}