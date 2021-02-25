using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2BiCore.Data
{
    public static class DataAccessSqlite
    {
        // For consideration, a more generic method where the controller can inject the query
        /*
         * public static Lits<T> GetData<T>(string sqlStatement, Dictinary<string,object> parameters, string dbName="Default") 
         * for example:
         *  GetData<PersonModel>("Select * from Person", null) = List<PersonModel>
         *  
         */
        public static List<T> GetData<T>(string sqlStatement, Dictionary<string, object> parameters, 
            string cnxStringName ="Default")
        {
            DynamicParameters p = parameters.ToDynamicParameters();

            using (IDbConnection cnn = new SQLiteConnection(DataAccessHelpers.LoadConnectionString(cnxStringName)))
            {
                var rows = cnn.Query<T>(sqlStatement, p);
                return rows.ToList();
            }
        }

        public static object GetDatabyId<T>(string sqlStatement, Dictionary<string, object> parameters, string cnxStringName)
        {
            DynamicParameters p = parameters.ToDynamicParameters();

            using (IDbConnection cnn = new SQLiteConnection(DataAccessHelpers.LoadConnectionString(cnxStringName)))
            {
                var row = cnn.Query<T>(sqlStatement, p).FirstOrDefault<T>();
                return row;
            }
        }

        public static void SaveData<T>(string sqlStatement, Dictionary<string,object> parameters, 
            string cnxStringName = "Default")
        {
            DynamicParameters p = parameters.ToDynamicParameters();

            using (IDbConnection cnn = new SQLiteConnection(DataAccessHelpers.LoadConnectionString(cnxStringName)))
            {
                cnn.Execute(sqlStatement, p);
            }
        }
        public static void DeleteData<T>(string sqlStatement, Dictionary<string, object> parameters, 
            string cnxStringName = "Default")
        {
            DynamicParameters p = parameters.ToDynamicParameters();

            using (IDbConnection cnn = new SQLiteConnection(DataAccessHelpers.LoadConnectionString(cnxStringName)))
            {
                cnn.Execute(sqlStatement, p);
            }
        }
        public static void ClearData<T>(string sqlStatement, Dictionary<string, object> parameters, 
            string cnxStringName = "Default")
        {

            using (IDbConnection cnn = new SQLiteConnection(DataAccessHelpers.LoadConnectionString(cnxStringName)))
            {
                cnn.Execute(sqlStatement, parameters);
            }
        }

        private static DynamicParameters ToDynamicParameters(this Dictionary<string, object> p)
        {
            DynamicParameters output = new DynamicParameters();
            p.ToList().ForEach(x => output.Add(x.Key, x.Value));
            return output;
        }

    }
}
