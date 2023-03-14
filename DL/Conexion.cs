using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DL
{
    public class Conexion
    {
        //se llama a la cadena de conexion
        public static string GetConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings["AGutierrezProgramacionNCapas"].ConnectionString.ToString();
        }
    }
    
}
