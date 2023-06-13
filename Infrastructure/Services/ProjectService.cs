using ApplicationCore.Commons.Repository;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.DatabaseContext;
using Infrastructure.EF.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ApplicationCore.Interfaces;

namespace Infrastructure.Services
{


    public class ProjectService : IProjectService
    {
        private readonly AppDbContext context;

        public ProjectService(AppDbContext context)
        {
            this.context = context;
        }

        public Task AddUserToProject(int projectId, int leaderId, int userId, int roleId)
        {
            throw new NotImplementedException();
        }

        public Task ApplyUserToProject(int userId, int projectId)
        {
            throw new NotImplementedException();
        }

        public Task ChangeUserRole(int projectId, int leaderId, int userId, int roleId)
        {
            throw new NotImplementedException();
        }

        public Task<Project> CreateProject(int userId, Project project, List<int> technologies, List<int> languages)
        {
            var newP
        }

        public Task<List<Project>> GetAllProjects()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetAllProjectWithPrivateRecruitment()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetApplicants(int leaderId, int projectId)
        {
            throw new NotImplementedException();
        }

        public Task<Project> GetProjectById(int projectId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TeamUser>> GetProjectMembers(int projectId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetProjectsByLanguage(int langId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Project>> GetProjectsByTech(int techId)
        {
            throw new NotImplementedException();
        }

        public Task SetProjectStatus(int projectId, int leaderId, int statusId)
        {
            throw new NotImplementedException();
        }

        public Task SetRepositoryUrl(int userId, int projectId, string repositoryUrl)
        {
            throw new NotImplementedException();
        }

        public Task<Project> UpdateProject(int userId, int projectId, Project project)
        {
            throw new NotImplementedException();
        }
    }
}
