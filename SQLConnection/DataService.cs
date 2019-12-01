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
    }
}
