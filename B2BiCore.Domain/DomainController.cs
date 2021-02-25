using B2BiCore.Data;
using B2BiCore.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2BiCore.Domain
{
    public class DomainController : IDomainController
    {

        public DomainController()
        {
        }
        public List<ProjectModel> GetProjectModels()
        {

            return DataAccessSqlite.GetData<ProjectModel>("Select * from Projects", new Dictionary<string, object>(), "AppData");
            //            List < ProjectModel> ProjectModels = DataAccessSqlite.GetData<ProjectModel>("Select * from Projects", new Dictionary<string, object>(), dbconnectionString);
        }
        public ProjectModel GetProjectModelbyId(int Id)
        {
            string sql = "Select * from Projects where Id == @Id";
            Dictionary<string, object> p = new Dictionary<string, object>() { { "@Id", Id } };

            return (ProjectModel)DataAccessSqlite.GetDatabyId<ProjectModel>(sql, p, "AppData");
        }
        public void SaveProjectModel(ProjectModel project)
        {
            string sql = "Insert Into Projects " +
                "(Name, DatabaseType, Server, Port, Database, Username, Password) VALUES " +
                "(@Name, @DatabaseType, @Server, @Port, @Database, @Username, @Password) ";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@Name", project.Name },
                {"@DatabaseType", project.DatabaseType },
                {"@Server", project.Server },
                {"@Port", project.Port },
                {"@Database", project.Database },
                {"@Username", project.Username },
                {"@Password", project.Password }
            };

            DataAccessSqlite.SaveData<ProjectModel>(sql, parameters);
        }
        public void DeleteProjectModel(ProjectModel project)
        {
            string sql = "DELETE FROM Projects WHERE " +
                "Id = @Id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                {"@Id", project.Id }
            };

            DataAccessSqlite.DeleteData<ProjectModel>(sql, parameters);
        }




    }
}
