using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookV1.SQLConnection
{
    class DataService
    {
        private readonly PersonaDataService _dataService;

        public DataService(string connectionString)
        {
            _dataService = PersonaDataService.GetInstance(connectionString);
        }

        public bool UpdatePerfil(string idpersona, string nombre, string correo, string contra)
        {
            try
            {
                return _dataService.UpdatePerfil(idpersona, nombre, correo, contra);
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public bool Postear(string idpersona, string post, string urlimg)
        {
            try
            {
                return _dataService.Postear(idpersona, post, urlimg);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool AddAmigo1(string idamigo, string idpersona)
        {
            try
            {
                return _dataService.AddAmigo1(idamigo, idpersona);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool AmigosCount(string idpersona)
        {
            try
            {
                return _dataService.AmigosCount(idpersona);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool DeleteAmigo(string idamigo, string idpersona)
        {
            try
            {
                return _dataService.DeleteAmigo(idamigo, idpersona);
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool DarLike1(string post)
        {
            try
            {
                return _dataService.DarLike1(post);
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
