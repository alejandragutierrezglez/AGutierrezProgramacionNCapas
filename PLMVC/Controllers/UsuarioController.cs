using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebGrease;

namespace PLMVC.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        [HttpGet]
        public ActionResult GetAll(ML.Usuario usuario)
        {
            ML.Result result = BL.Usuario.GetAllEF(usuario);
            //ML.Usuario usuario = new ML.Usuario();

            if (result.Correct)
            {
                usuario.Usuarios = result.Objects;
                return View(usuario);
            }
            else
            {
                return View(usuario);
            }
        }

        //para obtener nuevamente la vista

        [HttpGet]//para mostrar la vista
        public ActionResult Form(int? IdUsuario)
        {
            ML.Result resultRol = BL.Rol.GetAll();
            ML.Result resultPais = BL.Pais.GetAll();

            ML.Usuario usuario = new ML.Usuario();
            usuario.Rol = new ML.Rol();

            usuario.Direccion = new ML.Direccion();
            usuario.Direccion.Colonia = new ML.Colonia();
            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();

            if (resultRol.Correct && resultPais.Correct)
            {

                usuario.Rol.Roles = resultRol.Objects;
                usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;
            }
            if (IdUsuario == null)
            {
                //add //formulario vacio
                return View(usuario);
            }
            else
            {
                //getById

                ML.Result result = BL.Usuario.GetByIdEF(IdUsuario.Value); //2

                if (result.Correct)
                {
                    usuario = (ML.Usuario)result.Object;//unboxing
                    usuario.Rol.Roles = resultRol.Objects;                   
                    usuario.Direccion.Colonia.Municipio.Estado.Pais.Paises = resultPais.Objects;

                    ML.Result resultEstado = BL.Estado.GetByIdPais(usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais);
                    ML.Result resultMunicipio = BL.Municipio.GetByIdEstado(usuario.Direccion.Colonia.Municipio.Estado.IdEstado);
                    ML.Result resultColonia = BL.Colonia.GetByIdMunicipio(usuario.Direccion.Colonia.Municipio.IdMunicipio);

                    usuario.Direccion.Colonia.Municipio.Estado.Estados = resultEstado.Objects;
                    usuario.Direccion.Colonia.Municipio.Municipios = resultMunicipio.Objects;
                    usuario.Direccion.Colonia.Colonias = resultColonia.Objects;
                    //update
                    return View(usuario);
                }
                else
                {
                    ViewBag.Message = "Ocurrio al consultar la información del alumno";
                    return View("Modal");
                }
            }
        }

        [HttpPost] //Hacer el registro
        public ActionResult Form(ML.Usuario usuario)
        {
            HttpPostedFileBase file = Request.Files["fuImage"];

            if (file != null)
            {
                byte[] imagen = ConvertToBytes(file);

                usuario.Imagen = Convert.ToBase64String(imagen);
            }


            ML.Result result = new ML.Result();

            if (usuario.IdUsuario != null)
            {
                //Update
                result = BL.Usuario.UpdateEF(usuario);
                ViewBag.Message = "Se ha actualizado el registro";
            }
            else
            {
                //Add
                result = BL.Usuario.AddEF(usuario);
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
        public ActionResult Delete(int idUsuario)
        {
            ML.Result result = BL.Usuario.DeleteEF(idUsuario);

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

        [HttpPost]
        public JsonResult EstadoGetByIdPais(int idPais)
        {
            ML.Result result = new ML.Result();
            result = BL.Estado.GetByIdPais(idPais);

            return Json(result.Objects);
        }

        [HttpPost]
        public JsonResult MunicipioGetByIdEstado(int idEstado)
        {
            ML.Result result = new ML.Result();
            result = BL.Municipio.GetByIdEstado(idEstado);

            return Json(result.Objects);
        }
        [HttpPost]
        public JsonResult ColoniaGetByIdMunicipio(int idMunicipio)
        {
            ML.Result result = new ML.Result();
            result = BL.Colonia.GetByIdMunicipio(idMunicipio);

            return Json(result.Objects);
        }
        public byte[] ConvertToBytes(HttpPostedFileBase Foto)
        {
            byte[] data = null;
            System.IO.BinaryReader reader = new System.IO.BinaryReader(Foto.InputStream);
            data = reader.ReadBytes((int)Foto.ContentLength);

            return data;
        }
    }
}
