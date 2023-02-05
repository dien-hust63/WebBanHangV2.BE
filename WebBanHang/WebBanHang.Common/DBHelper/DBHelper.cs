using Dapper;
using Microsoft.Extensions.Configuration;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebBanHang.Common.DBHelper
{
    public class DBHelper:IDBHelper
    {
        private static IConfiguration _configuration;
        private IDbConnection _dbConnection;
        private string _connectionString = "";
        public DBHelper(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("MasterDB");
        }
        /// <summary>
        /// query
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="dynamicParam"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public List<T> Query<T>(string query, DynamicParameters dynamicParam, CommandType? commandType = null)
        {
            using (_dbConnection = new MySqlConnection(_connectionString))
            {
                return _dbConnection.Query<T>(query, param: dynamicParam, commandType: commandType).ToList();
            }
        }
        /// <summary>
        /// query first or default
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="dynamicParam"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public T QueryFirstOrDefault<T>(string query, DynamicParameters dynamicParam, CommandType? commandType = null)
        {
            using (_dbConnection = new MySqlConnection(_connectionString))
            {
                return _dbConnection.QueryFirstOrDefault<T>(query, param: dynamicParam, commandType:commandType);
            }
        }
        /// <summary>
        /// xóa dữ liệu
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entityID"></param>
        /// <returns></returns>
        public bool Delete<T>(long entityID)
        {
            using (_dbConnection = new MySqlConnection(_connectionString))
            {
                string tableName = typeof(T).Name.ToLower();
                var sqlCommand = $"DELETE FROM {tableName} WHERE {tableName}Id = @{tableName}Id";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add($"@{tableName}Id", entityID);
                var rowEffects = _dbConnection.Execute(sqlCommand, param: parameters);
                return rowEffects > 0;
            }
        }
        
        /// <summary>
        /// Query multiple return two list
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="query"></param>
        /// <param name="dynamicParam"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public (List<T1>, List<T2>) QueryMultipleResult<T1, T2>(string query, DynamicParameters dynamicParam, CommandType? commandType = null)
        {
            using (_dbConnection = new MySqlConnection(_connectionString))
            {
                var result = _dbConnection.QueryMultiple(query, dynamicParam, commandType: commandType);
                List<T1> listOne = result.Read<T1>().ToList();
                List<T2> listTwo = result.Read<T2>().ToList();
                return (listOne, listTwo);
            }
            
        }

        /// <summary>
        /// Query multiple return three result
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="query"></param>
        /// <param name="dynamicParam"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public (List<T1>, List<T2>, List<T3>) QueryMultipleResult<T1, T2, T3>(string query, DynamicParameters dynamicParam, CommandType? commandType = null)
        {
            using (_dbConnection = new MySqlConnection(_connectionString))
            {
                var result = _dbConnection.QueryMultiple(query, dynamicParam, commandType: commandType);
                List<T1> listOne = result.Read<T1>().ToList();
                List<T2> listTwo = result.Read<T2>().ToList();
                List<T3> listThree = result.Read<T3>().ToList();
                return (listOne, listTwo, listThree);
            }
        }
        /// <summary>
        /// execute query
        /// </summary>
        /// <param name="query"></param>
        /// <param name="dynamicParam"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public int Execute(string query, DynamicParameters dynamicParam, CommandType? commandType = null)
        {
            using (_dbConnection = new MySqlConnection(_connectionString))
            {
                return _dbConnection.Execute(query, dynamicParam, commandType: commandType);
            }
        }
    }
}
