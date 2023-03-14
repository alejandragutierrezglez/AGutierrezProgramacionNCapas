using BL;
using ML;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Usuario
    {
        public static void Add()
        {
            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Ingresa tu Nombre(s)");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu Apellido Paterno");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa tu Apellido Materno");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa tu correo electronico");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingresa un Username");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingresa un Password");
            usuario.Passwordd = Console.ReadLine();

            Console.WriteLine("Indica fecha en que realizas el registro, siguiendo la estructura 2001-12-25");
            usuario.FechaNacimiento = Console.ReadLine();
  
            usuario.Rol = new ML.Rol();
            Console.WriteLine("Ingresa el ID del rol del usuario");
            usuario.Rol.IdRol = byte.Parse(Console.ReadLine());

            Console.WriteLine("Indica el sexo, F o M");
            usuario.Sexo= Console.ReadLine();

            Console.WriteLine("Indica el telefono");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Indica el numero de celular");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Indica el CURP");
            usuario.CURP = Console.ReadLine();


            //enviamos la información a BL

            //BL.Usuario.Add(usuario);
            //ML.Result result = BL.Usuario.Add(usuario);
            ML.Result result = BL.Usuario.AddEF(usuario);
            //ML.Result result = BL.Usuario.AddLINQ(usuario);

            if (result.Correct == true)
            {
                Console.WriteLine("Se ha agregado el registro");
            }
            else
            {
                Console.WriteLine("No se ha podido agregar el registro debido a: " + result.ErrorMessage);
            }
            Console.ReadKey();

        }

        public static void Update()
        {
            ML.Usuario usuario = new ML.Usuario();

            Console.WriteLine("Indica el ID del registro que deseas modificar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe el Nombre");
            usuario.Nombre = Console.ReadLine();

            Console.WriteLine("Ingresa tu Apellido Paterno");
            usuario.ApellidoPaterno = Console.ReadLine();

            Console.WriteLine("Ingresa tu Apellido Materno");
            usuario.ApellidoMaterno = Console.ReadLine();

            Console.WriteLine("Ingresa tu correo electronico");
            usuario.Email = Console.ReadLine();

            Console.WriteLine("Ingresa un Username");
            usuario.UserName = Console.ReadLine();

            Console.WriteLine("Ingresa un Password");
            usuario.Passwordd = Console.ReadLine();

            Console.WriteLine("Indica fecha en que realizas el registro, siguiendo la estructura 2001-12-25");
            usuario.FechaNacimiento =Console.ReadLine();

            usuario.Rol = new ML.Rol();
            Console.WriteLine("Ingresa el ID del rol del usuario");
            usuario.Rol.IdRol = byte.Parse(Console.ReadLine());

            Console.WriteLine("Indica el sexo, F o M");
            usuario.Sexo = Console.ReadLine();

            Console.WriteLine("Indica el telefono");
            usuario.Telefono = Console.ReadLine();

            Console.WriteLine("Indica el numero de celular");
            usuario.Celular = Console.ReadLine();

            Console.WriteLine("Indica el CURP");
            usuario.CURP = Console.ReadLine();

            //BL.Usuario.Update(usuario);
            //ML.Result result = BL.Usuario.Update(usuario);
            ML.Result result = BL.Usuario.UpdateEF(usuario);
            //ML.Result result = BL.Usuario.UpdateLINQ(usuario);
            if (result.Correct == true)
            {
                Console.WriteLine("Se ha modificado el registro");
            }
            else
            {
                Console.WriteLine("No se ha podido modificar el registro debido a: " + result.ErrorMessage);
            }
            Console.ReadKey();
        }

        public static void Delete()
        {
            ML.Usuario usuario = new ML.Usuario();
            Console.WriteLine("Indica el ID del registro a eliminar");
            usuario.IdUsuario = int.Parse(Console.ReadLine());

            //BL.Usuario.Delete(usuario);
            ML.Result result = BL.Usuario.Delete(usuario);
            //ML.Result result = BL.Usuario.DeleteEF(usuario);
            //ML.Result result = BL.Usuario.DeleteLINQ(usuario);

            if (result.Correct == true)
            {
                Console.WriteLine("Se ha eliminado el registro");
            }
            else
            {
                Console.WriteLine("No se ha podido eliminar el registro debido a: " + result.ErrorMessage);
            }
            Console.ReadKey();
        }
        public static void GetAll()
        {
            //ML.Result result = BL.Usuario.GetAll();
            ML.Result result = BL.Usuario.GetAllEF();
            //ML.Result result = BL.Usuario.GetAllLINQ();


            foreach (ML.Usuario usuario in result.Objects)
            {
                Console.WriteLine("--------------------");
                Console.WriteLine("ID: " + usuario.IdUsuario);
                Console.WriteLine("Nombre: " + usuario.Nombre);
                Console.WriteLine("ApellidoPaterno: " + usuario.ApellidoPaterno);
                Console.WriteLine("ApellidoMaterno: " + usuario.ApellidoMaterno);
                Console.WriteLine("Email: " + usuario.Email);
                Console.WriteLine("UserName: " + usuario.UserName);
                Console.WriteLine("Password: " + usuario.Passwordd);
                Console.WriteLine("Fecha de Nacimiento: " + usuario.FechaNacimiento);
                Console.WriteLine("IdRol: " + usuario.Rol.IdRol);
                Console.WriteLine("Nombre Rol: "+usuario.Rol.Nombre);
                Console.WriteLine("Sexo: " + usuario.Sexo);
                Console.WriteLine("Telefono: "+usuario.Telefono);
                Console.WriteLine("Celular: "+usuario.Celular);
                Console.WriteLine("CURP: "+usuario.CURP);
                Console.WriteLine("---------------------");

            }
            Console.ReadKey();
        }

        //public static void GetById()
        //{
        //    ML.Usuario usuario = new ML.Usuario();
        //    Console.WriteLine("Indica el ID que quieres visualizar");
        //    usuario.IdUsuario = int.Parse(Console.ReadLine());
        //    //ML.Result result = BL.Usuario.GetById(usuario);
        //    ML.Result result = BL.Usuario.GetByIdEF(usuario);
        //    //ML.Result result = BL.Usuario.GetByIdLINQ(usuario);

        //    usuario = (ML.Usuario)result.Object;

        //    Console.WriteLine("--------------------");
        //    Console.WriteLine("ID: " + usuario.IdUsuario);
        //    Console.WriteLine("Nombre: " + usuario.Nombre);
        //    Console.WriteLine("ApellidoPaterno: " + usuario.ApellidoPaterno);
        //    Console.WriteLine("ApellidoMaterno: " + usuario.ApellidoMaterno);
        //    Console.WriteLine("Email: " + usuario.Email);
        //    Console.WriteLine("UserName: " + usuario.UserName);
        //    Console.WriteLine("Password: " + usuario.Passwordd);
        //    Console.WriteLine("Fecha de Nacimiento: " + usuario.FechaNacimiento);
        //    Console.WriteLine("IdRol: " + usuario.Rol.IdRol);
        //    Console.WriteLine("Nombre Rol: " + usuario.Rol.Nombre);
        //    Console.WriteLine("Sexo: " + usuario.Sexo);
        //    Console.WriteLine("Telefono: " + usuario.Telefono);
        //    Console.WriteLine("Celular: " + usuario.Celular);


        //    Console.WriteLine("---------------------");
        //    Console.ReadKey();
        //}
    }
}
