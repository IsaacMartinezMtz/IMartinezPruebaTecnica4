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
        public ActionResult Form(int? IdCarro)
        {
            ML.Carro carro= new ML.Carro();
            if(IdCarro != null)
            {
                ML.Result result = BL.Carro.GetById(IdCarro.Value);
                if(result.Correct) {
                    carro = (ML.Carro)result.Object;
                }

            }
            else
            {
                
            }
            return View(carro);
        }
        [HttpPost]
        public ActionResult Form(ML.Carro carro)
        {
            if(carro.IdCarro == 0)
            {
                ML.Result result = BL.Carro.Add(carro);
                if(result.Correct)
                {
                    ViewBag.Mensaje = "Se ha registrado correctamente el carro";

                }
                else
                {
                    ViewBag.Mensaje = "Error al registrar el carro";
                }
            }
            else
            {
                ML.Result result = BL.Carro.Upadate(carro);
                if(result.Correct)
                {
                    ViewBag.Mensaje = "Actualizacion exitosa de la informacion del carro";
                }
                else
                {
                    ViewBag.Mensaje = "Error al actualizar la informacion del carro";
                }
            }
            return PartialView("Modal");

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