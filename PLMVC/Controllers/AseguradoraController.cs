using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PLMVC.Controllers
{
    public class AseguradoraController : Controller
    {
        // GET: Aseguradora
        [HttpGet]
        public ActionResult GetAll(ML.Aseguradora aseguradora)
        {
            ML.Result result = BL.Aseguradora.GetAllEF();
            //ML.Usuario usuario = new ML.Usuario();

            if (result.Correct)
            {
                aseguradora.Aseguradoras = result.Objects;
                return View(aseguradora);
            }
            else
            {
                return View(aseguradora);
            }
        }

        [HttpGet]
        public ActionResult Form(int IdAseguradora)
        {
            ML.Result resultAseguradora = BL.Aseguradora.GetAllEF();
            ML.Aseguradora aseguradora = new ML.Aseguradora();

            if (resultAseguradora.Correct)
            {
                aseguradora.Aseguradoras = resultAseguradora.Objects;
            }
            if (IdAseguradora == null)
            {
                //add //formulario vacio
                return View(aseguradora);
            }
            else
            {
                //getById
                ML.Result result = BL.Aseguradora.GetByIdEF(IdAseguradora); //2
                if (result.Correct)
                {
                    aseguradora = (ML.Aseguradora)result.Object;//unboxing
                    aseguradora.Aseguradoras = resultAseguradora.Objects;
                    //update
                    return View(aseguradora);
                }
                else
                {
                    ViewBag.Message = "Ocurrio al consultar la información de la aseguradora";
                    return View("Modal");
                }
            }
        }

        [HttpPost] //Hacer el registro
        public ActionResult Form(ML.Aseguradora aseguradora)
        {
           ML.Result result = new ML.Result();
            if (aseguradora.IdAseguradora != null)
            {
                //Update
                result = BL.Aseguradora.UpdateEF(aseguradora);
                ViewBag.Message = "Se ha actualizado el registro";
            }
            else
            {
                //Add
                result = BL.Aseguradora.AddEF(aseguradora);
                ViewBag.Message = "Se ha agregado el registro";
            }
            if (result.Correct)
            {
                return PartialView("Modal");
            }
            else
            {
                return PartialView("Modal");
            }
        }


        public ActionResult Delete(int IdAseguradora)
        {
            ML.Result result = BL.Aseguradora.DeleteEF(IdAseguradora);

            if (result.Correct)
            {
                ViewBag.Message = "Se ha eliminado el registro";
                return PartialView("Modal");
            }
            else
            {
                ViewBag.Message = "No se ha podido eliminar el registro seleccionado" + result.ErrorMessage;
                return PartialView("Modal");
            }
        }



    }
}