using clasesenlinea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace clasesenlinea.Controllers
{
    public class HomeController : Controller
    {
        private context db = new context();
        public HomeController()
        {
           

        }
        public ActionResult Index()
        {
           // Session["usuarioEmail"] = "javierhr_0321@hotmail.com";
            if (Session["usuarioEmail"] == null)
            {
                return RedirectToAction("login", "Home");
            }
            return View();
        }
        public ActionResult subirArchivo(int id)

        {
            Usuario usuarioactual = new Usuario();
            usuarioactual.usuarioId = 1;
            usuario_material _usuario_material = db.usuario_materiales.Where(x => x.usuarioId == usuarioactual.usuarioId).
                Where(x => x.TareaId == id).FirstOrDefault();
            if (_usuario_material == null) { ViewBag.estatus = "Pendiente"; } else { ViewBag.estatus = "Entregado"; }
            
            ///var _usuario_material = new usuario_material();
            return View(_usuario_material);
        }

        [HttpPost]
        public ActionResult subirArchivo(usuario_material o)
        {
            string ruta = Server.MapPath("/evidencias/");
            string archivo = ( o.usuarioId.ToString() + "_" + o.TareaId.ToString() +"_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_"+ o.ArchivoFisico.FileName ).ToLower();
            o.ArchivoFisico.SaveAs(ruta + archivo);

            return View("Index");
        }

        public ActionResult login()
        { return View(); }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult login(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var O= db.usuarios.Where(x => x.username == usuario.username).FirstOrDefault();
                if (O == null)
                {
                    ViewBag.mensaje = "El usuario no existe";
                    return View();
                }
                else if (O.password != usuario.password)
                {
                    ViewBag.mensaje = "Contraseña incorrecta";
                    return View();
                }
                else
                {
                    Session["usuarioEmail"] = O.username;
                    return View("Index");
                }
                                                
            }

            return View(usuario);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}