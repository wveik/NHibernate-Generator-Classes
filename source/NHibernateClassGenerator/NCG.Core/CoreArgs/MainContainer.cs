using System;

namespace NCG.Core.CoreArgs
{
    [Serializable]
    public class MainContainer
    {
        public MainContainer()
        {
        }

        public MainContainer(string connectionString, string sheme, string table)
        {
            ConnectionString = connectionString;
            Table = table;
            Sheme = sheme;
        }

        public string ConnectionString { get; set; }
        public string Table { get; set; }
        public string Sheme { get; set; }
    }
}