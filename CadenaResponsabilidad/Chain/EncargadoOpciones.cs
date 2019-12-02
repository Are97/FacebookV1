using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.CadenaResponsabilidad.Chain
{
    public class EncargadoOpciones : Handler
    {
        public override void handleRequest(Request request)
        {
            request.SetNum(0);
        }
    }
}
