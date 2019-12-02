using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.CadenaResponsabilidad.Chain
{
    public class EncargadoBuscarAmigos : Handler
    {
        public override void handleRequest(Request request)
        {
            if (request.GetRequesType() == "BuscarAmigos")
            {
                request.SetNum(5);
            }
            else
            {
                successor.handleRequest(request);
            }
        }
    }
}
