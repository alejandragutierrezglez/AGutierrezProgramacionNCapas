using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Estado
    {
        public static ML.Result GetByIdPais(int idPais)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.AGutierrezProgramacionNCapasEntities context = new DL.AGutierrezProgramacionNCapasEntities())
                {
                    var query = context.EstadoGetByIdPais(idPais).ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var obj in query)
                        {
                            ML.Estado estado = new ML.Estado();

                            estado.IdEstado = obj.IdEstado;
                            estado.Nombre = obj.Nombre;


                            result.Objects.Add(estado);
                        }
                    }
                }
                result.Correct = true;

            }
            catch (Exception ex)
            {

                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
    }
}
