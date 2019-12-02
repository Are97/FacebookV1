using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.CadenaResponsabilidad.Chain
{
    public class EncargadoPerfil : Handler
    {
        public override void handleRequest(Request request)
        {
            if (request.GetRequesType() == "Perfil")
            {
                request.SetNum(4);
            }
            else
            {
                successor.handleRequest(request);
            }
        }
    }
}
