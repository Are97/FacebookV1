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
        private static PersonaDataService _instance;

        private PersonaDataService(string connectionString)
        {
            _client = new SqlClient(connectionString);
        }

        public static PersonaDataService GetInstance(string connectionString)
        {
            if(_instance == null)
            {
                _instance = new PersonaDataService(connectionString);
            }
            return _instance;
        }


        public bool UpdatePerfil(string idpersona, string nombre, string correo, string contra)
        {
            var result = false;
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.Conecction,
                        CommandText = "UpdatePerfil",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@idpersona", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = System.Convert.ToInt32(idpersona)
                    };

                    var par2 = new SqlParameter("@nombre", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = nombre
                    };

                    var par3 = new SqlParameter("@correo", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = correo
                    };

                    var par4 = new SqlParameter("@contras", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = contra
                    };

                    var par5 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par3);
                    command.Parameters.Add(par4);
                    command.Parameters.Add(par5);

                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());


                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _client.Close();
            }

            return result;
        }


        public bool Postear(string idpersona, string post, string urlimg)
        {
            var result = false;
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.Conecction,
                        CommandText = "Postear",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@idpersona", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = System.Convert.ToInt32(idpersona)
                    };

                    var par2 = new SqlParameter("@post", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = post
                    };

                    var par3 = new SqlParameter("@urlimg", SqlDbType.NVarChar)
                    {
                        Direction = ParameterDirection.Input,
                        Value = urlimg
                    };

                    var par4 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par3);
                    command.Parameters.Add(par4);

                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());


                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _client.Close();
            }

            return result;
        }


        public bool AddAmigo1(string idamigo, string idpersona)
        {
            var result = false;
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.Conecction,
                        CommandText = "AddAmigo1",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@idamigo", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = System.Convert.ToInt32(idamigo)
                    };

                    var par2 = new SqlParameter("@idpersona", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = System.Convert.ToInt32(idpersona)
                    };

                    var par3 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par3);

                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());


                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _client.Close();
            }

            return result;
        }

        public bool AmigosCount(string idpersona)
        {
            var result = false;
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.Conecction,
                        CommandText = "AmigosCount",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@idpersona", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = System.Convert.ToInt32(idpersona)
                    };

                    var par2 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);

                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());


                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _client.Close();
            }

            return result;
        }


        public bool DeleteAmigo(string idamigo, string idpersona)
        {
            var result = false;
            try
            {
                if (_client.Open())
                {
                    var command = new SqlCommand
                    {
                        Connection = _client.Conecction,
                        CommandText = "DeleteAmigo",
                        CommandType = CommandType.StoredProcedure
                    };

                    var par1 = new SqlParameter("@idamigo", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = System.Convert.ToInt32(idamigo)
                    };

                    var par2 = new SqlParameter("@idpersona", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Input,
                        Value = System.Convert.ToInt32(idpersona)
                    };

                    var par3 = new SqlParameter("@haserror", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par3);

                    command.ExecuteNonQuery();

                    result = !Convert.ToBoolean(command.Parameters["@haserror"].Value.ToString());


                }
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _client.Close();
            }

            return result;
        }




    }
}
