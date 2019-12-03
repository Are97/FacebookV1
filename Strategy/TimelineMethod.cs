using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.Strategy
{
    public class TimelineMethod
    {
        private string prueba;
        private TimelineStrategy timelineStrategy;
        public string nombre;
        public string urlimg;
        public string post;
        public string idpersona;
        public string idpost;
        public string likes;
        public string comments;

        public void SetTimelineStrategy(TimelineStrategy _timelineStrategy)
        {
            timelineStrategy = _timelineStrategy;
        }
        public void SetPrueba(string _idpost, string _idpersona, string _post, string __urlimg, string _Likes, string _comments, string _nombre)
        {
            nombre = _nombre;
            urlimg = __urlimg;
            post = _post;
            idpersona = _idpersona;
            idpost = _idpost;
            likes = _Likes;
            comments = _comments;
        }
        public void Timeline()
        {
            timelineStrategy.Timeline(idpost,idpersona,post,urlimg, likes,comments,nombre);
            Console.WriteLine();
        }
        public int getCount()
        {
            return timelineStrategy.getCount();
        }

        public string getNombre(int idx)
        {
            return timelineStrategy.getNombre(idx);
        }
        public string getPost(int idx)
        {
            return timelineStrategy.getPost(idx);
        }
        public string getLikes(int idx)
        {
            return timelineStrategy.getLikes(idx);
        }
    }
}
