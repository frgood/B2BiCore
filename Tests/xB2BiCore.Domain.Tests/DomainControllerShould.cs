using B2BiCore.Data;
using B2BiCore.Domain;
using B2BiCore.Domain.Models;
using System;
using System.Collections.Generic;
using Xunit;

namespace xB2BiCore.Domain.Tests
{
    public class DomainControllerShould :IDisposable 
    {
        [Fact]
        public void GetProjectModels()
        {
            
            DomainController  sut = new DomainController();
            List<ProjectModel> models = sut.GetProjectModels();

            Assert.NotNull(models);
        }

        [Fact]
        public void SaveProjectModel()
        {
            ProjectModel put = new ProjectModel
            {
                Name = "Test Project",
                DatabaseType = "SQL Server",
                Server = "WIN-B2B-DEV",
                Port = "1433",
                Database = "SI52",
                Username = "FirstUser",
                Password="password1234"
            };

            DomainController sut = new DomainController();
            sut.SaveProjectModel(put);
            List<ProjectModel> aut = sut.GetProjectModels();

            Assert.Contains(aut, i => i.Name == put.Name);
        }

        [Fact]
        public void GetProjectModelById() 
        {
            ProjectModel confirm = new ProjectModel();
            ProjectModel put = new ProjectModel
            {
                Name = "Test Project",
                DatabaseType = "SQL Server",
                Server = "WIN-B2B-DEV",
                Port = "1433",
                Database = "SI52",
                Username = "FirstUser",
                Password = "password1234"
            };

            DomainController sut = new DomainController();
            sut.SaveProjectModel(put);
            var rtr = sut.GetProjectModels();
            confirm = sut.GetProjectModelbyId(rtr[0].Id );

            Assert.NotNull(confirm);
        }

        /*
        [Fact ]
        public void DeleteProjectModel() // Not implemented yet
        {
            ProjectModel confirm = new ProjectModel();
            ProjectModel put = new ProjectModel
            {
                Name = "Test Project",
                DatabaseType = "SQL Server",
                Server = "WIN-B2B-DEV",
                Port = "1433",
                Database = "SI52",
                Username = "FirstUser",
                Password = "password1234"
            };

            DomainController sut = new DomainController();
            sut.SaveProjectModel(put);
            var rtr = sut.GetProjectModels();
            var confirm = sut.DeleteProjectModel(rtr[0].Id);


            sut.DeleteProjectModel(put);
            List<ProjectModel> aut = sut.GetProjectModels();

            Assert.DoesNotContain (aut, i => i.Name == put.Name);
        }
        */
        public void Dispose()
        {
            string sql = "DELETE FROM Projects";
            Dictionary<string, object> p = new Dictionary<string, object>();
            DataAccessSqlite.ClearData<ProjectModel>(sql, p);
        }

    }
}
