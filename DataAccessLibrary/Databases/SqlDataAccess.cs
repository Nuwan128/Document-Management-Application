using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Databases
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public List<T> LoadData<T, U>(string sqlStatment,
                                     U parameter,
                                     string connectionStringName,
                                     bool isStoredProceduer = false)
        {
            string conectionString = _config.GetConnectionString(connectionStringName);

            CommandType commandType = CommandType.Text;
            if (isStoredProceduer == true)
            {
                commandType = CommandType.StoredProcedure;
            }


            using (IDbConnection connection = new SqlConnection(conectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatment, parameter, commandType: commandType).ToList();
                return rows;
            }
        }

        public void SaveData<T>(string sqlStatment,
                                T parameter,
                                string connectionStringName,
                                bool isStoredProceduer = false)
        {
            string conectionString = _config.GetConnectionString(connectionStringName);


            CommandType commandType = CommandType.Text;
            if (isStoredProceduer == true)
            {
                commandType = CommandType.StoredProcedure;
            }


            using (IDbConnection connection = new SqlConnection(conectionString))
            {
                connection.Query<T>(sqlStatment, parameter, commandType: commandType);
            }
        }
    }
}
