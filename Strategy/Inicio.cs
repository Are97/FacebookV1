using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.Strategy
{
    public class Inicio : TimelineStrategy
    {
        public override int getCount()
        {
            return 0;
        }

        public override string getLikes(int idx)
        {
            return "";
        }

        public override string getNombre(int idx)
        {
            return "";
        }

        public override string getPost(int idx)
        {
            return "";
        }

        public override void Timeline(string _idpost, string _idpersona, string _post, string __urlimg, string _Likes, string _comments, string _nombre)
        {
            Console.WriteLine("Inicio ");
        }
    }
}
