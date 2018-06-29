using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using NCG.Core.CoreArgs;
using NCG.Core.DAL;

namespace NCG.Core.Domain
{
    public class DomainLayer
    {
        private const string PathScripts = "Scripts";
        private const string PathToClass = "class.sql";
        private const string PathToMap = "map.sql";

        private const string Scheme = "%Scheme%";
        private const string TableName = "%TableName%";

        private const string ErrorDidNotGetData = "Error: executer did't get data from DataBase";

        private const string RepositoryStr = "public class %TableName%Repository : Repository<%TableName%>, I%TableName%Repository";
        private const string ServiceStr = @"public class %TableName%Service : ApplicationService, I%TableName%Service
    {
        public I%TableName%Repository Repository { get; set; }";

        private readonly MainArg _arg;
        private AdoRepository _repositiry;

        public DomainLayer(MainArg arg)
        {
            _arg = arg;
            _repositiry = new AdoRepository(_arg.ConnectionString);
        }

        public string GetClass()
        {
            var list = GetDataFromDb(PathToClass);

            var result = string.Join(Environment.NewLine, list);

            return result;
        }

        public string GetMap()
        {
            var list = GetDataFromDb(PathToMap);

            var result = string.Join(Environment.NewLine, list);

            return result;
        }

        public string GetServices()
        {
            var builder = new StringBuilder();
            var className = _arg.TableName.ToLower().First().ToString().ToUpper() + _arg.TableName.ToLower().Substring(1);

            builder.Append(RepositoryStr.Replace(TableName, className));
            builder.Append(Environment.NewLine);

            builder.Append(ServiceStr.Replace(TableName, className));
            builder.Append(Environment.NewLine);
            /*
             public class MenuService : ApplicationService, IMenuService
    {
        public IMenuRepository Repository { get; set; }
             */

            return builder.ToString();
        }

        private IEnumerable<string> GetDataFromDb(string pathArg)
        {
            _repositiry = new AdoRepository(_arg.ConnectionString);
            var path = Path.Combine(Directory.GetCurrentDirectory(), PathScripts, pathArg);
            var sqlArray = File.ReadAllLines(path);
            var sql = string.Join(Environment.NewLine, sqlArray);
            sql = sql.Replace(Scheme, _arg.Scheme);
            sql = sql.Replace(TableName, _arg.TableName);

            DataTable table;
            DataSet set;
            using (set = _repositiry.GetDataSetBySimpleSql(sql))
            {
                if (set == null || set.Tables.Count == 0)
                {
                    throw new ArgumentException(ErrorDidNotGetData);
                }

                table = set.Tables[0];
            }
            var list = (from DataRow row in table.Rows select row[0].ToString()).ToList();
            return list;
        }
        
    }
}