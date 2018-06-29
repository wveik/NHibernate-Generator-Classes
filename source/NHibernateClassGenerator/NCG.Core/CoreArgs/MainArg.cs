namespace NCG.Core.CoreArgs
{
    public class MainArg
    {
        public string ConnectionString { get; set; }
        public string Scheme { get; set; }
        public string TableName { get; set; }

        public MainArg(string connectionString, string scheme, string tableName)
        {
            ConnectionString = connectionString;
            Scheme = scheme;
            TableName = tableName;
        }
    }
}