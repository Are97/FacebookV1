using FacebookV1.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.Strategy
{
    public class Inicio : TimelineStrategy
    {
        public Stack<Post> StackInicio = new Stack<Post>();

        public override int getCount()
        {
            return StackInicio.Count;
        }

        public override string getLikes(int idx)
        {
            return StackInicio.ElementAt(idx).Likes;
        }

        public override string getNombre(int idx)
        {
            return StackInicio.ElementAt(idx).nombre;
        }

        public override string getPost(int idx)
        {
            return StackInicio.ElementAt(idx).post;
        }

        public override void Timeline(string _idpost, string _idpersona, string _post, string __urlimg, string _Likes, string _comments, string _nombre)
        {
            Post post = new Post(_idpost, _idpersona, _post, __urlimg, _Likes, _comments, _nombre);
            StackInicio.Push(post);
        }
    }
}
