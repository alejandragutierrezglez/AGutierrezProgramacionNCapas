using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Usuarios
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.AGutierrezProgramacionNCapasEntities context = new DL.AGutierrezProgramacionNCapasEntities())
                {
                    var query = context.UsuariosGetAll().ToList();

                    if (query != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var obj in query)
                        {
                            ML.Usuario usuario = new ML.Usuario();

                            usuario.IdUsuario = obj.IdUsuario;
                            usuario.UserName= obj.UserName;
                            usuario.Nombre = obj.Nombre;
                            usuario.ApellidoPaterno= obj.ApellidoPaterno;
                            usuario.ApellidoMaterno= obj.ApellidoMaterno;
                            usuario.NombreCompleto = usuario.Nombre+" " + usuario.ApellidoPaterno+" "+ usuario.ApellidoMaterno;


                            result.Objects.Add(usuario);

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

