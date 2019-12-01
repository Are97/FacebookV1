using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FacebookV1.SQLConnection
{
    public class PersonaDataService
    {
        private readonly SqlClient _client;

        public PersonaDataService(string connectionString)
        {
            _client = new SqlClient(connectionString);
        }

        //public bool addPersona(Amigo amigo)
        //{
        //    var result = false;
        //    try
        //    {
        //        if (_client.Open())
        //        {
        //            var command = new SqlCommand
        //            {
        //                Connection = _client.Conecction,
        //                CommandText = "addPersona",
        //                CommandType = CommandType.StoredProcedure
        //            };

        //            var par1 = new SqlParameter("@nombre", SqlDbType.NVarChar)
        //            {
        //                Direction = ParameterDirection.Input,
        //                Value = amigo.nombre
        //            };

        //            var par2 = new SqlParameter("@fecnac", SqlDbType.DateTime)
        //            {
        //                Direction = ParameterDirection.Input,
        //                Value = amigo.fecnac
        //            };

        //            var par3 = new SqlParameter("@direccion", SqlDbType.NVarChar)
        //            {
        //                Direction = ParameterDirection.Input,
        //                Value = amigo.direccion
        //            };

        //            var par4 = new SqlParameter("@telefono", SqlDbType.NVarChar)
        //            {
        //                Direction = ParameterDirection.Input,
        //                Value = amigo.telefono
        //            };

        //            var par5 = new SqlParameter("@haserror", SqlDbType.Bit)
        //            {
        //                Direction = ParameterDirection.Output
        //            };

        //            command.Parameters.Add(par1);
        //            command.Parameters.Add(par2);
        //            command.Parameters.Add(par3);
        //            command.Parameters.Add(par4);
        //            command.Parameters.Add(par5);

        //            command.ExecuteNonQuery();

        //            result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());


        //        }
        //    }
        //    catch (Exception)
        //    {
        //        result = false;
        //    }
        //    finally
        //    {
        //        _client.Close();
        //    }

        //    return result;
        //}

    }
}
