using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.Prototype
{
    public class Post
    {
        public string idpost;
        public string idpersona;
        public string post;
        public string urlimg;
        public string Likes;
        public string comments;
        public string nombre;


        public Post() { }

        public Post(string _idpost, string _idpersona, string _post, string __urlimg, string _Likes, string _comments, string _nombre)
        {
            idpost = _idpost;
            idpersona = _idpersona;
            nombre = _nombre;
            urlimg = __urlimg;
            post = _post;
            Likes = _Likes;
            comments = _comments;
        }

        public Post Clone()
        {
            return new Post { nombre = nombre, urlimg = urlimg, post = post, Likes=Likes};
        }
    }
}
