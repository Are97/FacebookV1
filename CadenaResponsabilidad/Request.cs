using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.CadenaResponsabilidad
{
    public class Request
    {
        //private RequestType requestType;
        private int num;
        private string requestType;

        public Request(string _requestType)
        {
            requestType = _requestType;
        }
        public string GetRequesType()
        {
            return requestType;
        }

        public void SetNum(int _num)
        {
            num = _num;
        }
        public int GetNum()
        {
            return num;
        }
    }
}
