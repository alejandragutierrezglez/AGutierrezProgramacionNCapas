using BL;
using ML;
using PLMVC.AseguradoraReference;
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
        public ActionResult GetAll()
        {
            ML.Result result = new ML.Result();
            ML.Aseguradora aseguradora = new ML.Aseguradora();
            //ML.Result result = BL.Aseguradora.GetAllEF();
            AseguradoraReference.AseguradoraServiceClient aseguradoraClient = new AseguradoraReference.AseguradoraServiceClient();
            result = aseguradoraClient.GetAllEF();

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
        public ActionResult Form(int? IdAseguradora)

        {

            ML.Result resultUsuarios = BL.Usuarios.GetAll();

            ML.Aseguradora aseguradora = new ML.Aseguradora();
            aseguradora.usuario = new ML.Usuario();


            if (resultUsuarios.Correct)
            {

                aseguradora.usuario.Usuarios = resultUsuarios.Objects;
            }
            if (IdAseguradora == null)
            {
                //add //formulario vacio
                return View(aseguradora);
            }
            else
            {
                //getById
                //ML.Result result = BL.Aseguradora.GetByIdEF(IdAseguradora.Value); //2
                ML.Result result = new ML.Result();
                AseguradoraReference.AseguradoraServiceClient aseguradoraClient = new AseguradoraReference.AseguradoraServiceClient();
                result = aseguradoraClient.GetByIdEF(IdAseguradora.Value);

                if (result.Correct)
                {

                    aseguradora = (ML.Aseguradora)result.Object;//unboxing
                    aseguradora.usuario.Usuarios = resultUsuarios.Objects;
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

                //UPDATE
                AseguradoraReference.AseguradoraServiceClient aseguradoraClient = new AseguradoraReference.AseguradoraServiceClient();
                result = aseguradoraClient.UpdateEF(aseguradora);
                //result = BL.Aseguradora.UpdateEF(aseguradora);
                ViewBag.Message = "Se ha modificado el registro";
            }
            else
            {
                //Add
                AseguradoraReference.AseguradoraServiceClient aseguradoraClient = new AseguradoraReference.AseguradoraServiceClient();
                result = aseguradoraClient.AddEF(aseguradora);
                //result = BL.Aseguradora.AddEF(aseguradora);
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
            //ML.Result result = BL.Aseguradora.DeleteEF(IdAseguradora);
            ML.Result result = new ML.Result();

            AseguradoraReference.AseguradoraServiceClient aseguradoraClient = new AseguradoraReference.AseguradoraServiceClient();
            result = aseguradoraClient.DeleteEF(IdAseguradora);

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