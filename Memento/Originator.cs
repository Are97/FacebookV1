using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.Memento
{
    public class Originator
    {
        private string nombre;
        private string correo;

        public string getNombre()
        {
            return nombre;
        }
        public string getCorreo()
        {
            return correo;
        }
        public void setNombre(string _nombre)
        {
            nombre = _nombre;
        }
        public void setCorreo(string _correo)
        {
            correo = _correo;
        }

        public Memento save()
        {
            return new Memento(nombre, correo);
        }
        public void revert(Memento mem)
        {
            nombre = mem.getNombre();
            correo = mem.getCorreo();
        }
    }
}
