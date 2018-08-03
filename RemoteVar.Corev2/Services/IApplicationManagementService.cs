using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using RemoteVar.Corev2.Models;
using RemoteVar.Corev2.Models.Application;

namespace RemoteVar.Corev2.Services
{
    public interface IApplicationManagementService
    {
        Task<List<Application>> GetApplicationListForUserAsync(IdentityUser user);

        Task<bool> AddNewApplicationForUserAsync(IdentityUser user, AddAppModel model);

        Task<Application> GetApplicationByIdAsync(IdentityUser user, Guid id);

        Task<Application> GetApplicationByIdAsync(Guid id);

        Task<bool> AddNewVariableForApplicationAsync(IdentityUser user, AddVariableModel model);

        Task<bool> UpdateValueOfVariableAsync(IdentityUser user, UpdateValueModel model);

        Task<bool> DeleteVariableAsync(IdentityUser user, DeleteValueModel model, Action<Guid[]> deleteValues);

    }
}
