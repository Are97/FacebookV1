using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.CadenaResponsabilidad.Chain
{
    public class EncargadoModificarPerfil : Handler
    {
        public override void handleRequest(Request request)
        {
            if (request.GetRequesType() == "ModificarPerfil")
            {
                request.SetNum(1);
            }
            else
            {
                successor.handleRequest(request);
            }
        }
    }
}
