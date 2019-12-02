using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.Prototype
{
    public class Post
    {
        public string nombre;
        public string urlimg;
        public string post;

        public Post Clone()
        {
            return new Post { nombre = nombre, urlimg = urlimg, post = post};
        }
    }
}
