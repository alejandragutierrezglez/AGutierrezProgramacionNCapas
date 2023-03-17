using ML;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Aseguradora
    {
        public static ML.Result AddEF(ML.Aseguradora aseguradora)
        {
            using (DL.AGutierrezProgramacionNCapasEntities context = new DL.AGutierrezProgramacionNCapasEntities())
            {
                Result result = new ML.Result();
                try
                {

                    var query = context.AseguradoraAdd(aseguradora.Nombre, DateTime.Parse(aseguradora.FechaCreacion), DateTime.Parse(aseguradora.FechaModificacion), aseguradora.usuario.IdUsuario);

                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
                catch (Exception ex)
                {

                    result.ErrorMessage = ex.Message;
                    result.Ex = ex;
                    result.Correct = false;
                }
                return result;

            }
        }

        public static ML.Result DeleteEF(int idAseguradora)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AGutierrezProgramacionNCapasEntities context = new DL.AGutierrezProgramacionNCapasEntities())
                {
                    var query = context.AseguradoraDelete(idAseguradora);

                    if (query > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }

        public static ML.Result UpdateEF(ML.Aseguradora aseguradora)
        {
            using (DL.AGutierrezProgramacionNCapasEntities context = new DL.AGutierrezProgramacionNCapasEntities())
            {
                Result result = new ML.Result();
                try
                {

                    var query = context.AseguradoraUpdate(aseguradora.IdAseguradora, aseguradora.Nombre, DateTime.Parse(aseguradora.FechaCreacion), DateTime.Parse(aseguradora.FechaModificacion), aseguradora.usuario.IdUsuario);

                    if (Convert.ToInt32(query) > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
                catch (Exception ex)
                {

                    result.ErrorMessage = ex.Message;
                    result.Ex = ex;
                    result.Correct = false;
                }
                return result;

            }
        }

        public static ML.Result GetAllEF()
        {
            ML.Result result = new ML.Result();
            {
                try
                {
                    using (DL.AGutierrezProgramacionNCapasEntities context = new DL.AGutierrezProgramacionNCapasEntities())
                    {
                        var query = context.AseguradoraGetAll().ToList();

                        if (query != null)
                        {
                            result.Objects = new List<object>();

                            foreach (var resultAseguradora in query)
                            {
                                ML.Aseguradora aseguradora = new ML.Aseguradora();
                                aseguradora.Nombre = resultAseguradora.Nombre;
                                aseguradora.FechaCreacion = resultAseguradora.FechaCreacion.Value.ToString("dd/MM/yyyy");
                                aseguradora.FechaModificacion = resultAseguradora.FechaModificacion.Value.ToString("dd/MM/yyyy");
                                aseguradora.usuario = new ML.Usuario();
                                aseguradora.usuario.IdUsuario = resultAseguradora.IdUsuario;


                                result.Objects.Add(aseguradora);
                            }
                            result.Correct = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    result.Correct = false;
                    result.Ex = ex;
                    result.ErrorMessage = ex.Message;
                }
                return result;
            }
        }

        public static ML.Result GetByIdEF(int IdAseguradora)
        {
            ML.Result result = new ML.Result();
            {
                try
                {
                    using (DL.AGutierrezProgramacionNCapasEntities context = new DL.AGutierrezProgramacionNCapasEntities())
                    {
                        var query = context.AseguradoraGetById(IdAseguradora).FirstOrDefault();

                        if (query != null)
                        {
                            ML.Aseguradora aseguradora = new ML.Aseguradora();
                            aseguradora.Nombre = query.Nombre;
                            aseguradora.FechaCreacion = query.FechaCreacion.Value.ToString("dd/MM/yyyy");
                            aseguradora.FechaModificacion = query.FechaModificacion.Value.ToString("dd/MM/yyyy");
                            aseguradora.usuario = new ML.Usuario();
                            aseguradora.usuario.IdUsuario = query.IdUsuario;

                       
                            result.Object = aseguradora;

                            result.Correct = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    result.Correct = false;
                    result.Ex = ex;
                    result.ErrorMessage = ex.Message;
                }
                return result;
            }

        }
    }
}
