using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.CadenaResponsabilidad
{
    public abstract class Handler
    {
        protected int num;
        protected Handler successor;
        public void setSuccessor(Handler _successor)
        {
            successor = _successor;
        }
        public abstract void handleRequest(Request request);
    }
}
