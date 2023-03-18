using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AseguradoraService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AseguradoraService.svc o AseguradoraService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AseguradoraService : IAseguradoraService
    {
        public ML.Result AddEF(ML.Aseguradora aseguradora)
        {
            ML.Result result = BL.Aseguradora.AddEF(aseguradora);
            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public ML.Result UpdateEF(ML.Aseguradora aseguradora)
        {
            ML.Result result = BL.Aseguradora.UpdateEF(aseguradora);

            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public ML.Result DeleteEF(int IdAseguradora)
        {
            ML.Result result = BL.Aseguradora.DeleteEF(IdAseguradora);

            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public ML.Result GetAllEF()
        {
            ML.Result result = BL.Aseguradora.GetAllEF();

            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
        public ML.Result GetByIdEF(int IdAseguradora)
        {
            ML.Result result = BL.Aseguradora.GetByIdEF(IdAseguradora);

            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }


    }
}
