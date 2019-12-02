using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.CadenaResponsabilidad.Chain
{
    public class EncargadoInicio : Handler
    {
        public override void handleRequest(Request request)
        {
            if (request.GetRequesType() == "Inicio")
            {
                request.SetNum(3);
            }
            else
            {
                successor.handleRequest(request);
            }
        }
    }
}
