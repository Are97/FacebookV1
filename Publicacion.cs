using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1
{
    public class Publicacion
    {
        public string nombre;
        public string urlimg;
        public string post;
        public string idpersona;
        public string idpost;
        public string likes;
        public string comments;

        public Publicacion(string _idpost, string _idpersona, string _post, string __urlimg,string _Likes, string _comments, string _nombre)
        {
            nombre = _nombre;
            urlimg = __urlimg;
            post = _post;
            idpersona = _idpersona;
            idpost = _idpost;
            likes = _Likes;
            comments = _comments;
        }

    }
}
