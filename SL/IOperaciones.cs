using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IOperaciones" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IOperaciones
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        int SumarNumeros(int a, int b);
        [OperationContract]
        int RestarNumeros(int a, int b);
        [OperationContract]
        int MultiplicarNumeros(int a, int b);
        [OperationContract]
        int DividirNumeros(int a, int b);
    }
}
