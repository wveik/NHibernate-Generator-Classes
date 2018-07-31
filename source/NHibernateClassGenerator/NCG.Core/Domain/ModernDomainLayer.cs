using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using NCG.Core.CoreArgs;
using NCG.Core.DAL;
using NCG.Core.Domain.inter;

namespace NCG.Core.Domain
{
    public class ModernDomainLayer : IDomainLayer
    {
        private const string PathScripts = "ModernScripts";
        private const string PathToClass = "class.sql";
        private const string PathToColumn = "columns.sql";

        private const string Scheme = "%Scheme%";
        private const string TableName = "%TableName%";

        private const string ErrorDidNotGetData = "Error: executer did't get data from DataBase";


        private readonly MainArg _arg;
        private AdoRepository _repositiry;


        public ModernDomainLayer(MainArg arg)
        {
            _arg = arg;
            _repositiry = new AdoRepository(_arg.ConnectionString);
        }

        public string GetClass()
        {
            var table = GetDataFromDb(PathToColumn);



            throw new System.NotImplementedException();
        }

        public string GetMap()
        {
            throw new System.NotImplementedException();
        }

        public string GetServices()
        {
            throw new System.NotImplementedException();
        }

        private DataTable GetDataFromDb(string pathArg)
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
            return table;
        }
    }
}