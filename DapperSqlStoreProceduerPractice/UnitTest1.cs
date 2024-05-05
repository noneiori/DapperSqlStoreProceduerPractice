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

                //�d�ߪ���ơA�Y��^�Ȭ�table�A�h�Τ@��d�ߪ��覡�ϥ�select
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

                //�ϥιw�s�{�ǮɡA�����I�s�Y�i
                var datas = connection.Query<QandA>("GetQandAById", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}