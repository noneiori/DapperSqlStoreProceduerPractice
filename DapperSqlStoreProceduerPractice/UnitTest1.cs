using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace DapperSqlStoreProceduerPractice
{
    [TestClass]
    public class UnitTest1
    {
        string connectionString = "Data Source=DESKTOP\\SQLEXPRESS;Initial Catalog=mingkuan;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        [TestMethod]
        public void QueryFromFunction()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                //ID
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("id", 1);

                //查詢的函數，若返回值為table，則用一般查詢的方式使用select
                var datas = connection.Query<QandA>("SELECT * FROM dbo.FN_TEST(@id) as t", parameters);                
            }
        }

        [TestMethod]
        public void QueryFromStoreProcedure()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                //ID
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("id", 1);

                //使用預存程序時，直接呼叫即可
                var datas = connection.Query<QandA>("GetQandAById", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}