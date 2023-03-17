using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Management.Instrumentation;
using System.Collections;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using ML;
using DL;
using System.Linq.Expressions;
namespace BL
{
    public class Empleado
    {
        public static ML.Result GetAllEF(ML.Empleado empleado)
        {
            ML.Result result = new ML.Result();
            {
                try
                {
                    using (DL.AGutierrezProgramacionNCapasEntities context = new DL.AGutierrezProgramacionNCapasEntities())
                    {
                        var query = context.EmpleadoGetAll(empleado.Nombre).ToList();

                        if (query != null)
                        {
                            result.Objects = new List<object>();

                            foreach (var resultEmpleado in query)
                            {
                                empleado = new ML.Empleado();
                                empleado.NumeroEmpleado = resultEmpleado.NumeroEmpleado;
                                empleado.RFC = resultEmpleado.RFC;
                                empleado.Nombre = resultEmpleado.Nombre;
                                empleado.ApellidoPaterno = resultEmpleado.ApellidoPaterno;
                                empleado.ApellidoMaterno = resultEmpleado.ApellidoMaterno;
                                empleado.Email = resultEmpleado.Email;
                                empleado.Telefono = resultEmpleado.Telefono;
                                empleado.FechaNacimiento = resultEmpleado.FechaNacimiento.Value.ToString("dd/MM/yyyy");
                                empleado.NSS = resultEmpleado.NSS;
                                empleado.FechaIngreso = resultEmpleado.FechaIngreso.Value.ToString("dd/MM/yyyy");
                                empleado.Foto = resultEmpleado.Foto;
                                empleado.Empresa = new ML.Empresa();
                                empleado.Empresa.IdEmpresa = resultEmpleado.IdEmpresa.Value;
                               
                                result.Objects.Add(empleado);
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

    }
}
