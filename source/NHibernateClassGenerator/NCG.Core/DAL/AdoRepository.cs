using System.Data;
using System.Data.SqlClient;

namespace NCG.Core.DAL
{
    public class AdoRepository
    {
        private readonly string _connectionString;

        public AdoRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DataSet GetDataSetBySimpleSql(string sqlCommand)
        {
            var ds = new DataSet();
            using (var cmd = new SqlCommand(sqlCommand, new SqlConnection(_connectionString)))
            {
                cmd.Connection.Open();
                var table = new DataTable();
                table.Load(cmd.ExecuteReader());
                ds.Tables.Add(table);
            }
            return ds;
        }
    }
}