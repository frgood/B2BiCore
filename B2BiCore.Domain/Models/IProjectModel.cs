using System;

namespace B2BiCore.Domain.Models
{
    public interface IProjectModel
    {
        string Database { get; set; }
        string DatabaseType { get; set; }
        int Id { get; set; }
        DateTime InstallDate { get; set; }
        string Name { get; set; }
        string Password { get; set; }
        string Port { get; set; }
        string Server { get; set; }
        string SIVersion { get; set; }
        string Username { get; set; }
    }
}