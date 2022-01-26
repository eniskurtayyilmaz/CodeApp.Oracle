﻿using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace CodeApp.Oracle.Repositories
{
    public class OracleConnectionFactory : IDatabaseConnectionFactory
    {
        private readonly string _connectionString;

        public OracleConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            var sqlConnection = new OracleConnection(_connectionString);
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
