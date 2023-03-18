using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAseguradoraService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IAseguradoraService
    {
       
        [OperationContract]
        ML.Result AddEF(ML.Aseguradora aseguradora);


        [OperationContract]
        ML.Result UpdateEF(ML.Aseguradora aseguradora);


        [OperationContract]
        ML.Result DeleteEF(int IdAseguradora);


        [OperationContract]
        [ServiceKnownType(typeof(ML.Aseguradora))]
        ML.Result GetByIdEF(int IdAseguradora);

        [OperationContract]
        [ServiceKnownType(typeof(ML.Aseguradora))]
        ML.Result GetAllEF();

    }
}
