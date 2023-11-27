using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class CarroController : Controller
    {
        // GET: Carro
        [HttpGet]
        public ActionResult GetCarro()
        {
            ML.Carro carro = new ML.Carro();
            ML.Result result = BL.Carro.GetAll();
            carro.Carros = result.Objects;
            
            return View(carro);
        }
        [HttpGet]
        public ActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Eliminar(int  idCarro) {
            ML.Result result = BL.Carro.Delete(idCarro);
            if (result.Correct)
            {
                ViewBag.Mensaje = "Se elimino correctamente el carro";
            }
            else
            {
                ViewBag.Mesnaje = "Error al eliminar el carro";
            }
            return PartialView("Modal");
        }
    }

}