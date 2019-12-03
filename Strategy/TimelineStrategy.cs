using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.Strategy
{
    public abstract class TimelineStrategy
    {
        public abstract void Timeline(string _idpost, string _idpersona, string _post, string __urlimg, string _Likes, string _comments, string _nombre);
        public abstract int getCount();
        public abstract string getNombre(int idx);
        public abstract string getPost(int idx);
    }
}
