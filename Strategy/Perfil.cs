using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookV1.Prototype;
namespace FacebookV1.Strategy
{
    public class Perfil : TimelineStrategy
    {
        public Stack<Post> StackPerfil = new Stack<Post>();
        public override void Timeline(string _idpost, string _idpersona, string _post, string __urlimg, string _Likes, string _comments, string _nombre)
        {
            Post post = new Post(_idpost, _idpersona, _post, __urlimg, _Likes, _comments, _nombre);
            StackPerfil.Push(post);
        }

        public override int getCount()
        {
            return StackPerfil.Count;
        }

        public override string getNombre(int idx)
        {
            return StackPerfil.ElementAt(idx).nombre;
        }

        public override string getPost(int idx)
        {
            return StackPerfil.ElementAt(idx).post;
        }
    }
}
