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
    public class Usuario
    {
        //public static void Add(ML.Usuario usuario)
        //{
        //    using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //    {
        //        //using (var conn = new SqlConnection("Data Source=.;Initial Catalog=AGutierrezProgramacionNCapas;Persist Security Info=True;User ID=sa;Password=pass@word1"))
        //        {
        //            //var cmd = new SqlCommand("INSERT INTO [dbo].[usuario]([Nombre],[ApellidoPaterno],[ApellidoMaterno],[Email],[Username],[Passwordd],[FechaRegistro])VALUES(@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Email,@Username,@Passwordd,@FechaRegistro)", conn);
        //            // var cmd = new SqlCommand("INSERT INTO [dbo].[usuario]([Nombre],[ApellidoPaterno],[ApellidoMaterno],[Email],[Username],[Passwordd],[FechaRegistro])VALUES(@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Email,@Username,@Passwordd,@FechaRegistro)");
        //            string query = "INSERT INTO usuario (Nombre, ApellidoPaterno, ApellidoMaterno, Email, Username, Passwordd, FechaRegistro) VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Email, @Username, @Passwordd, @FechaRegistro)";
        //            using (SqlCommand cmd = new SqlCommand())

        //            {
        //                //asignar la conexion al command
        //                cmd.Connection = context;
        //                //asignamos la sentencia
        //                cmd.CommandText = query;
        //                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
        //                cmd.Parameters.AddWithValue("@ApellidoPaterno", usuario.ApellidoPaterno);
        //                cmd.Parameters.AddWithValue("@ApellidoMaterno", usuario.ApellidoMaterno);
        //                cmd.Parameters.AddWithValue("@Email", usuario.Email);
        //                cmd.Parameters.AddWithValue("@Username", usuario.Username);
        //                cmd.Parameters.AddWithValue("@Passwordd", usuario.Passwordd);
        //                cmd.Parameters.AddWithValue("@FechaRegistro", usuario.FechaRegistro);

        //                //conn.Open();
        //                cmd.Connection.Open();
        //                cmd.ExecuteNonQuery();
        //            }
        //        }
        //    }
        //}


        //public static void Delete(ML.Usuario usuario)
        //{
        //    using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //    {
        //        //using (var conn = new SqlConnection("Data Source=.;Initial Catalog=AGutierrezProgramacionNCapas;Persist Security Info=True;User ID=sa;Password=pass@word1"))
        //        {
        //            string query = "DELETE FROM usuario WHERE IdUsuario = @IdUsuario";
        //            using (SqlCommand cmd = new SqlCommand())
        //            {
        //                //asignar la conexion al command
        //                cmd.Connection = context;
        //                //asignamos la sentencia
        //                cmd.CommandText = query;
        //                //  var cmd = new SqlCommand("DELETE FROM [dbo].[usuario]WHERE IdUsuario = @IdUsuario", conn);
        //                cmd.Parameters.AddWithValue("@IdUsuario", Convert.ToInt32(usuario.IdUsuario));
        //                cmd.Connection.Open();
        //                cmd.ExecuteNonQuery();

        //            }
        //        }
        //    }
        //}
        //public static void Update(ML.Usuario usuario)
        //{
        //    using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
        //    {
        //        // using (var conn = new SqlConnection("Data Source=.;Initial Catalog=AGutierrezProgramacionNCapas;Persist Security Info=True;User ID=sa;Password=pass@word1"))

        //        string query = "UPDATE usuario SET Nombre = @Nombre,ApellidoPaterno = @ApellidoPaterno,ApellidoMaterno = @ApellidoMaterno,Email = @Email,Username = @Username,Passwordd = @Passwordd,FechaRegistro = @FechaRegistro WHERE IdUsuario = @IdUsuario";
        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            //asignar la conexion al command
        //            cmd.Connection = context;
        //            //asignamos la sentencia
        //            cmd.CommandText = query;
        //            //var cmd = new SqlCommand("UPDATE [dbo].[usuario]SET [Nombre] = @Nombre,[ApellidoPaterno] = @ApellidoPaterno,[ApellidoMaterno] = @ApellidoMaterno,[Email] = @Email,[Username] = @Username,[Passwordd] = @Passwordd,[FechaRegistro] = @FechaRegistro WHERE [IdUsuario] = @IdUsuario", conn);
        //            cmd.Parameters.AddWithValue("@IdUsuario", Convert.ToInt32(usuario.IdUsuario));
        //            cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
        //            cmd.Parameters.AddWithValue("@ApellidoPaterno", usuario.ApellidoPaterno);
        //            cmd.Parameters.AddWithValue("@ApellidoMaterno", usuario.ApellidoMaterno);
        //            cmd.Parameters.AddWithValue("@Email", usuario.Email);
        //            cmd.Parameters.AddWithValue("@Username", usuario.Username);
        //            cmd.Parameters.AddWithValue("@Passwordd", usuario.Passwordd);
        //            cmd.Parameters.AddWithValue("@FechaRegistro", usuario.FechaRegistro);
        //            //conn.Open();
        //            cmd.Connection.Open();
        //            cmd.ExecuteNonQuery();
        //        }
        //    }
        //}

        public static ML.Result Add(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result(); //instancia

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "UsuarioAdd";

                    //ejecutar una sentencia, necesita una conexion 
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        //asignar la conexion al command
                        cmd.Connection = context;
                        //asignamos la sentencia
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] parameters = new SqlParameter[7];

                        parameters[0] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                        parameters[0].Value = usuario.Nombre;

                        parameters[1] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
                        parameters[1].Value = usuario.ApellidoPaterno;

                        parameters[2] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
                        parameters[2].Value = usuario.ApellidoMaterno;

                        parameters[3] = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                        parameters[3].Value = usuario.Email;

                        parameters[4] = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar);
                        parameters[4].Value = usuario.UserName;

                        parameters[5] = new SqlParameter("@Passwordd", System.Data.SqlDbType.VarChar);
                        parameters[5].Value = usuario.Passwordd;

                        parameters[6] = new SqlParameter("@FechaNacimiento", System.Data.SqlDbType.DateTime);
                        parameters[6].Value = usuario.FechaNacimiento
                            ;

                        //asignarle los parametros al command
                        cmd.Parameters.AddRange(parameters);
                        cmd.Connection.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }

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
        public static ML.Result AddEF(ML.Usuario usuario)
        {
            using (DL.AGutierrezProgramacionNCapasEntities context = new DL.AGutierrezProgramacionNCapasEntities())
            {
                Result result = new ML.Result();
                try
                {

                    var query = context.UsuarioAdd(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Email, usuario.UserName, usuario.Passwordd, DateTime.Parse(usuario.FechaNacimiento), usuario.Rol.IdRol, usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.CURP, usuario.Imagen, usuario.Direccion.Calle, usuario.Direccion.NumeroInterior, usuario.Direccion.NumeroExterior, usuario.Direccion.Colonia.IdColonia);

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
        public static ML.Result AddLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (AGutierrezProgramacionNCapasEntities context = new AGutierrezProgramacionNCapasEntities())
                {
                    DL.usuario usuarioDL = new DL.usuario();

                    usuarioDL.Nombre = usuario.Nombre;
                    usuarioDL.ApellidoPaterno = usuario.ApellidoPaterno;
                    usuarioDL.ApellidoMaterno = usuario.ApellidoMaterno;
                    usuarioDL.Email = usuario.Email;
                    usuarioDL.UserName = usuario.UserName;
                    usuarioDL.Passwordd = usuario.Passwordd;
                    usuarioDL.FechaNacimiento = DateTime.Parse(usuario.FechaNacimiento);
                    usuarioDL.IdRol = usuario.Rol.IdRol;

                    context.usuarios.Add(usuarioDL);

                    var query = context.SaveChanges();
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
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }


        public static ML.Result Delete(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result(); //instancia

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "UsuarioDelete";

                    //ejecutar una sentencia, necesita una conexion 
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        //asignar la conexion al command
                        cmd.Connection = context;
                        //asignamos la sentencia
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] parameters = new SqlParameter[1];

                        parameters[0] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                        parameters[0].Value = usuario.IdUsuario;

                        //asignarle los parametros al command
                        cmd.Parameters.AddRange(parameters);
                        cmd.Connection.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }

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
        public static ML.Result DeleteEF(int idUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.AGutierrezProgramacionNCapasEntities context = new DL.AGutierrezProgramacionNCapasEntities())
                {
                    var query = context.UsuarioDelete(idUsuario);

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
        public static ML.Result DeleteLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (AGutierrezProgramacionNCapasEntities context = new AGutierrezProgramacionNCapasEntities())
                {
                    var query = (from a in context.usuarios
                                 where a.IdUsuario == usuario.IdUsuario
                                 select a).First();
                    context.usuarios.Remove(query);
                    context.SaveChanges();
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }


        public static ML.Result Update(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result(); //instancia

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "UsuarioUpdate";

                    //ejecutar una sentencia, necesita una conexion 
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        //asignar la conexion al command
                        cmd.Connection = context;
                        //asignamos la sentencia
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] parameters = new SqlParameter[8];

                        parameters[0] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                        parameters[0].Value = usuario.IdUsuario;

                        parameters[1] = new SqlParameter("@Nombre", System.Data.SqlDbType.VarChar);
                        parameters[1].Value = usuario.Nombre;

                        parameters[2] = new SqlParameter("@ApellidoPaterno", System.Data.SqlDbType.VarChar);
                        parameters[2].Value = usuario.ApellidoPaterno;

                        parameters[3] = new SqlParameter("@ApellidoMaterno", System.Data.SqlDbType.VarChar);
                        parameters[3].Value = usuario.ApellidoMaterno;

                        parameters[4] = new SqlParameter("@Email", System.Data.SqlDbType.VarChar);
                        parameters[4].Value = usuario.Email;

                        parameters[5] = new SqlParameter("@UserName", System.Data.SqlDbType.VarChar);
                        parameters[5].Value = usuario.UserName;

                        parameters[6] = new SqlParameter("@Passwordd", System.Data.SqlDbType.VarChar);
                        parameters[6].Value = usuario.Passwordd;

                        parameters[7] = new SqlParameter("@FechaNacimiento", System.Data.SqlDbType.DateTime);
                        parameters[7].Value = usuario.FechaNacimiento;

                        //asignarle los parametros al command
                        cmd.Parameters.AddRange(parameters);
                        cmd.Connection.Open();

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }

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
        public static ML.Result UpdateEF(ML.Usuario usuario)
        {
            using (DL.AGutierrezProgramacionNCapasEntities context = new DL.AGutierrezProgramacionNCapasEntities())
            {
                Result result = new ML.Result();
                try
                {

                    var query = context.UsuarioUpdate(usuario.IdUsuario, usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno, usuario.Email, usuario.UserName, usuario.Passwordd, DateTime.Parse(usuario.FechaNacimiento), usuario.Rol.IdRol, usuario.Sexo, usuario.Telefono, usuario.Celular, usuario.CURP, usuario.Imagen, usuario.Direccion.Calle, usuario.Direccion.NumeroInterior, usuario.Direccion.NumeroExterior, usuario.Direccion.Colonia.IdColonia);

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
        public static Result UpdateLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (AGutierrezProgramacionNCapasEntities context = new AGutierrezProgramacionNCapasEntities())
                {
                    var query = (from a in context.usuarios
                                 where a.IdUsuario == usuario.IdUsuario
                                 select a).SingleOrDefault();

                    if (query != null)
                    {
                        query.Nombre = usuario.Nombre;
                        query.ApellidoPaterno = usuario.ApellidoPaterno;
                        query.ApellidoMaterno = usuario.ApellidoMaterno;
                        query.Email = usuario.Email;
                        query.UserName = usuario.UserName;
                        query.Passwordd = usuario.Passwordd;
                        query.FechaNacimiento = DateTime.Parse(usuario.FechaNacimiento);
                        query.IdRol = usuario.Rol.IdRol;
                        context.SaveChanges();

                        result.Correct = true;
                    }

                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontró el grupo" + usuario.IdUsuario;
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


        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    var query = "UsuarioGetAll";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;

                        //Crear tabla virtual
                        DataTable tableUsuario = new DataTable();

                        //Permite leer la información de la consulta
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        //llenar la tabla virtual
                        adapter.Fill(tableUsuario);

                        if (tableUsuario.Rows.Count > 0)
                        {
                            result.Objects = new List<object>();

                            foreach (DataRow row in tableUsuario.Rows)
                            {
                                ML.Usuario usuario = new ML.Usuario();

                                usuario.IdUsuario = int.Parse(row[0].ToString());
                                usuario.Nombre = row[1].ToString();
                                usuario.ApellidoPaterno = row[2].ToString();
                                usuario.ApellidoMaterno = row[3].ToString();
                                usuario.Email = row[4].ToString();
                                usuario.UserName = row[5].ToString();
                                usuario.Passwordd = row[6].ToString();
                                usuario.FechaNacimiento = row[7].ToString();
                                usuario.Rol = new ML.Rol();
                                usuario.Rol.IdRol = byte.Parse(row[8].ToString());
                                usuario.Rol.Nombre = row[9].ToString();
                                usuario.Sexo = row[10].ToString();
                                usuario.Telefono = row[11].ToString();
                                usuario.Celular = row[12].ToString();
                                usuario.CURP = row[13].ToString();
                                usuario.NombreCompleto = usuario.Nombre + usuario.ApellidoPaterno + usuario.ApellidoMaterno;

                                result.Objects.Add(usuario);
                            }

                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result GetAllEF(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();
            {
                try
                {
                    using (DL.AGutierrezProgramacionNCapasEntities context = new DL.AGutierrezProgramacionNCapasEntities())
                    {
                        var query = context.UsuarioGetAll(usuario.Nombre, usuario.ApellidoPaterno, usuario.ApellidoMaterno).ToList();

                        if (query != null)
                        {
                            result.Objects = new List<object>();

                            foreach (var resultUsuario in query)
                            {
                                usuario = new ML.Usuario();
                                usuario.IdUsuario = resultUsuario.IdUsuario;
                                usuario.Nombre = resultUsuario.Nombre;
                                usuario.ApellidoPaterno = resultUsuario.ApellidoPaterno;
                                usuario.ApellidoMaterno = resultUsuario.ApellidoMaterno;
                                usuario.Email = resultUsuario.Email;
                                usuario.UserName = resultUsuario.UserName;
                                usuario.Passwordd = resultUsuario.Passwordd;
                                usuario.FechaNacimiento = resultUsuario.FechaNacimiento.ToString("dd/MM/yyyy");
                                usuario.Rol = new ML.Rol();
                                usuario.Rol.IdRol = resultUsuario.IdRol.Value;
                                usuario.Rol.Nombre = resultUsuario.Nombre_Rol;
                                usuario.Sexo = resultUsuario.Sexo;
                                usuario.Telefono = resultUsuario.Telefono;
                                usuario.Celular = resultUsuario.Celular;
                                usuario.CURP = resultUsuario.CURP;
                                usuario.Imagen= resultUsuario.Imagen;
                                usuario.Direccion = new ML.Direccion();
                                usuario.Direccion.IdDireccion = resultUsuario.IdDireccion.Value;
                                usuario.Direccion.Calle = resultUsuario.Calle;
                                usuario.Direccion.NumeroInterior= resultUsuario.NumeroInterior;
                                usuario.Direccion.NumeroExterior = resultUsuario.NumeroExterior;
                                usuario.Direccion.Colonia = new ML.Colonia();
                                usuario.Direccion.Colonia.IdColonia = resultUsuario.IdColonia.Value;
                                result.Objects.Add(usuario);
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
        public static ML.Result GetAllLINQ()
        {
            ML.Result result = new ML.Result();

            try
            {
                using (AGutierrezProgramacionNCapasEntities context = new AGutierrezProgramacionNCapasEntities())
                {
                    var query = (from usuario in context.usuarios
                                 join rol in context.rols on usuario.IdRol equals rol.IdRol
                                 select new { IdUser = usuario.IdUsuario, NombreUser = usuario.Nombre, ApellidoPaternoUser = usuario.ApellidoPaterno, ApellidoMaternoUser = usuario.ApellidoMaterno, EmailUser = usuario.Email, UsernameUser = usuario.UserName, PassworddUser = usuario.Passwordd, FechaNacimientoUser = usuario.FechaNacimiento, Id_Rol = rol.IdRol, Nombre_Rol = rol.Nombre });
                    result.Objects = new List<object>();

                    if (query != null && query.ToList().Count > 0)
                    {
                        foreach (var obj in query)
                        {

                            ML.Usuario usu = new ML.Usuario();
                            usu.IdUsuario = obj.IdUser;
                            usu.Nombre = obj.NombreUser;
                            usu.ApellidoPaterno = obj.ApellidoPaternoUser;
                            usu.ApellidoMaterno = obj.ApellidoMaternoUser;
                            usu.Email = obj.EmailUser;
                            usu.UserName = obj.UsernameUser;
                            usu.Passwordd = obj.PassworddUser;
                            usu.FechaNacimiento = obj.FechaNacimientoUser.ToString("dd/MM/yyyy");
                            usu.Rol = new ML.Rol();
                            usu.Rol.IdRol = obj.Id_Rol;
                            usu.Rol.Nombre = obj.Nombre_Rol;

                            result.Objects.Add(usu);
                        }
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
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }


        public static ML.Result GetById(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    var query = "UsuarioGetById";

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = context;
                        cmd.CommandText = query;
                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter[] parameters = new SqlParameter[1];

                        parameters[0] = new SqlParameter("@IdUsuario", System.Data.SqlDbType.Int);
                        parameters[0].Value = IdUsuario;

                        cmd.Parameters.AddRange(parameters);

                        //Crear tabla virtual
                        DataTable tableUsuario = new DataTable();

                        //Permite leer la información de la consulta
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        //llenar la tabla virtual
                        adapter.Fill(tableUsuario);

                        if (tableUsuario.Rows.Count > 0)
                        {
                            DataRow row = tableUsuario.Rows[0];

                            ML.Usuario resultUsuario = new ML.Usuario();

                            resultUsuario.IdUsuario = int.Parse(row[0].ToString());
                            resultUsuario.Nombre = row[1].ToString();
                            resultUsuario.ApellidoPaterno = row[2].ToString();
                            resultUsuario.ApellidoMaterno = row[3].ToString();
                            resultUsuario.Email = row[4].ToString();
                            resultUsuario.UserName = row[5].ToString();
                            resultUsuario.Passwordd = row[6].ToString();
                            resultUsuario.FechaNacimiento = row[7].ToString();
                            resultUsuario.Rol = new ML.Rol();
                            resultUsuario.Rol.IdRol = byte.Parse(row[8].ToString());
                            resultUsuario.Sexo = row[9].ToString();
                            resultUsuario.Telefono = row[10].ToString();
                            resultUsuario.Celular = row[11].ToString();
                            resultUsuario.CURP = row[12].ToString();

                            resultUsuario.Direccion = new ML.Direccion();
                            resultUsuario.Direccion.IdDireccion = int.Parse(row[13].ToString());
                            resultUsuario.Direccion.Calle = row[14].ToString();
                            resultUsuario.Direccion.NumeroInterior = row[15].ToString();
                            resultUsuario.Direccion.NumeroExterior = row[16].ToString();

                            resultUsuario.Direccion.Colonia = new ML.Colonia();
                            resultUsuario.Direccion.Colonia.IdColonia = int.Parse(row[17].ToString());
                            resultUsuario.Direccion.Colonia.Nombre = row[18].ToString();
                            resultUsuario.Direccion.Colonia.CodigoPostal = row[19].ToString();

                            resultUsuario.Direccion.Colonia.Municipio = new ML.Municipio();
                            resultUsuario.Direccion.Colonia.Municipio.IdMunicipio = int.Parse(row[20].ToString());
                            resultUsuario.Direccion.Colonia.Municipio.Nombre = row[21].ToString();


                            resultUsuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            resultUsuario.Direccion.Colonia.Municipio.Estado.IdEstado = int.Parse(row[22].ToString());
                            resultUsuario.Direccion.Colonia.Municipio.Estado.Nombre = row[23].ToString();

                            resultUsuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                            resultUsuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = int.Parse(row[24].ToString());
                            resultUsuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = row[25].ToString();


                            result.Object = resultUsuario;


                            result.Correct = true;
                        }
                        else
                        {
                            result.Correct = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;
        }
        public static ML.Result GetByIdEF(int IdUsuario)
        {
            ML.Result result = new ML.Result();
            {
                try
                {
                    using (DL.AGutierrezProgramacionNCapasEntities context = new DL.AGutierrezProgramacionNCapasEntities())
                    {
                        var query = context.UsuarioGetById(IdUsuario).FirstOrDefault();

                        if (query != null)
                        {
                            ML.Usuario usuario = new ML.Usuario();

                            usuario.IdUsuario = query.IdUsuario;
                            usuario.Nombre = query.Nombre;
                            usuario.ApellidoPaterno = query.ApellidoPaterno;
                            usuario.ApellidoMaterno = query.ApellidoMaterno;
                            usuario.Email = query.Email;
                            usuario.UserName = query.UserName;
                            usuario.Passwordd = query.Passwordd;
                            usuario.FechaNacimiento = query.FechaNacimiento.ToString("dd/MM/yyyy");
                            usuario.Sexo = query.Sexo;
                            usuario.Telefono = query.Telefono;
                            usuario.Celular = query.Celular;
                            usuario.CURP = query.CURP;
                            usuario.Imagen = query.Imagen;
                            //usuario.Rol.IdRol = query.id  

                            usuario.Rol = new ML.Rol();
                            usuario.Rol.IdRol = query.IdRol.Value;


                            usuario.Direccion = new ML.Direccion();
                            usuario.Direccion.IdDireccion = query.IdDireccion;
                            usuario.Direccion.Calle = query.Calle;
                            usuario.Direccion.NumeroInterior = query.NumeroInterior;
                            usuario.Direccion.NumeroExterior = query.NumeroExterior;

                            usuario.Direccion.Colonia = new ML.Colonia();
                            usuario.Direccion.Colonia.IdColonia = query.IdColonia.Value;
                            usuario.Direccion.Colonia.Nombre = query.Nombre_Colonia;
                            usuario.Direccion.Colonia.CodigoPostal = query.CodigoPostal;

                            usuario.Direccion.Colonia.Municipio = new ML.Municipio();
                            usuario.Direccion.Colonia.Municipio.IdMunicipio = query.IdMunicipio.Value;
                            usuario.Direccion.Colonia.Municipio.Nombre = query.Nombre_Municipio;

                            usuario.Direccion.Colonia.Municipio.Estado = new ML.Estado();
                            usuario.Direccion.Colonia.Municipio.Estado.IdEstado = query.IdEstado.Value;
                            usuario.Direccion.Colonia.Municipio.Estado.Nombre = query.Nombre_Estado;


                            usuario.Direccion.Colonia.Municipio.Estado.Pais = new ML.Pais();
                            usuario.Direccion.Colonia.Municipio.Estado.Pais.IdPais = query.IdPais.Value;
                            usuario.Direccion.Colonia.Municipio.Estado.Pais.Nombre = query.Nombre_Pais;


                            result.Object = usuario;

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
        public static ML.Result GetByIdLINQ(ML.Usuario usuario)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (AGutierrezProgramacionNCapasEntities context = new AGutierrezProgramacionNCapasEntities())
                {
                    var query = (from usuarioo in context.usuarios
                                 join rol in context.rols on usuarioo.IdRol equals rol.IdRol
                                 where usuarioo.IdUsuario == usuario.IdUsuario
                                 select new { IdUser = usuarioo.IdUsuario, NombreUser = usuarioo.Nombre, ApellidoPaternoUser = usuarioo.ApellidoPaterno, ApellidoMaternoUser = usuarioo.ApellidoMaterno, EmailUser = usuarioo.Email, UsernameUser = usuarioo.UserName, PassworddUser = usuarioo.Passwordd, FechaNacimientoUser = usuarioo.FechaNacimiento, Id_Rol = rol.IdRol, Nombre_Rol = rol.Nombre }).FirstOrDefault();

                    if (query != null)
                    {

                        ML.Usuario usu = new ML.Usuario();

                        usu.IdUsuario = query.IdUser;
                        usu.Nombre = query.NombreUser;
                        usu.ApellidoPaterno = query.ApellidoPaternoUser;
                        usu.ApellidoMaterno = query.ApellidoMaternoUser;
                        usu.Email = query.EmailUser;
                        usu.UserName = query.UsernameUser;
                        usu.Passwordd = query.PassworddUser;
                        usu.FechaNacimiento = query.FechaNacimientoUser.ToString("dd/MM/yyyy");
                        usu.Rol = new ML.Rol();
                        usu.Rol.IdRol = query.Id_Rol;
                        usu.Rol.Nombre = query.Nombre_Rol;

                        result.Object = usu;
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se encontraron registros";
                    }
                }
            }
            catch (Exception ex)
            {
                result.Ex = ex;
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }


    }
}

