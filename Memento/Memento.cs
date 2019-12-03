using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.Memento
{
    public class Memento
    {
        private string nombre;
        private string correo;

        public Memento(string _nombre, string _correo)
        {
            nombre = _nombre;
            correo = _correo;
        }
       
        public string getNombre()
        {
            return nombre;
        }
        public string getCorreo()
        {
            return correo;
        }
    }
}
