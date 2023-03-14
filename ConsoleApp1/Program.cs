using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            Console.WriteLine("1.- Agregar"); 
            Console.WriteLine("2.- Actualizar");
            Console.WriteLine("3.- Eliminar");
            Console.WriteLine("4.- Consultar todos los registros");
            Console.WriteLine("5.- Consultar por ID");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("6.- Agregar por EF");
            Console.WriteLine("7.- Actualizar por EF");
            Console.WriteLine("8.- Eliminar por EF");
            Console.WriteLine("9.- Consultar todos los registros por EF");
            Console.WriteLine("10.- Consultar por ID por EF");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("11.- Agregar por LINQ");
            Console.WriteLine("12.- Actualizar por LINQ");
            Console.WriteLine("13.- Eliminar por LINQ");
            Console.WriteLine("14.- Consultar todos los registros por LINQ");
            Console.WriteLine("15.- Consultar por ID por LINQ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Usuario.Add();
                    break;
                case 2:
                    Usuario.Update();
                    break;
                case 3:
                    Usuario.Delete();
                    break;
                case 4:
                    Usuario.GetAll();
                    break;
                //case 5:
                //    Usuario.GetById();
                //    break;
                case 6:
                    Usuario.Add();
                    break;
                case 7:
                    Usuario.Update();
                    break;
                case 8:
                    Usuario.Delete();
                    break;
                case 9:
                    Usuario.GetAll();
                    break;
                //case 10:
                //  Usuario.GetById();
                //    break;
                case 11:
                    Usuario.Add();
                    break;
                case 12:
                    Usuario.Update();
                    break;
                case 13:
                    Usuario.Delete();
                    break;
                case 14:
                    Usuario.GetAll();
                    break;
                //case 15:
                //    Usuario.GetById();
                //    break;
            }
            //Seleccion seleccion= new Seleccion();
            //seleccion.Show();

            //PL.Usuario.Add();
            //con parametros
            //Usuario.Add();

            //PL.Usuario.Delete();
            // con parametros
            // Usuario.Delete();

            //PL.Usuario.Update();
            // con parametros
            //Usuario.Update();

            //Usuario.GetAll();
            //Usuario.GetById();
        }
    }
}
