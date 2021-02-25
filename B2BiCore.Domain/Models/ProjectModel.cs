using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2BiCore.Domain.Models
{
    public class ProjectModel : IProjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DatabaseType { get; set; }
        public string Server { get; set; }
        public string Port { get; set; }
        public string Database { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string SIVersion { get; set; }
        public DateTime InstallDate { get; set; }


    }
}
