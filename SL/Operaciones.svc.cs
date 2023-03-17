using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Operaciones" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Operaciones.svc o Operaciones.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Operaciones : IOperaciones
    {
        public void DoWork()
        {
        }
        public int SumarNumeros(int a, int b)
        {
            return a + b;
        }
        public int RestarNumeros(int a, int b)
        {
            return a - b;
        }
        public int MultiplicarNumeros(int a, int b)
        {
            return a * b;
        }
        public int DividirNumeros(int a, int b)
        {
            return a / b;
        }
    }
}
