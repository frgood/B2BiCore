using B2BiCore.Domain.Models;
using System.Collections.Generic;

namespace B2BiCore.Domain
{
    public interface IDomainController
    {
        void DeleteProjectModel(ProjectModel project);
        ProjectModel GetProjectModelbyId(int Id);
        List<ProjectModel> GetProjectModels();
        void SaveProjectModel(ProjectModel project);
    }
}