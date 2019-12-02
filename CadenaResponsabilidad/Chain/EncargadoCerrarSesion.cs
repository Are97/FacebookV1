using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookV1.CadenaResponsabilidad.Chain
{
    public class EncargadoCerrarSesion : Handler
    {
        public override void handleRequest(Request request)
        {
            if(request.GetRequesType() == "CerrarSesión")
            {
                request.SetNum(2);
            }
            else
            {
                successor.handleRequest(request);
            }
        }
    }
}
