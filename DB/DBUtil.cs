using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CRUD.DB
{
    public class DBUtil : IDisposable
    {
        private static SqlConnection objCon;
        public DBUtil()
        { }
        public bool conectar()
        {
            objCon = new SqlConnection(ConfigurationManager.ConnectionStrings["conexaoBanco"].ConnectionString);

            try
            {
                objCon.Open();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool desconectar()
        {
            if (objCon.State != ConnectionState.Closed)
            {
                objCon.Close();
                objCon.Dispose();
                return true;
            }
            else
            {
                objCon.Dispose();
                return false;
            }
        }

        public SqlConnection getConexao()
        {
            return objCon;
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
