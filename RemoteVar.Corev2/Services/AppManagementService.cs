using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RemoteVar.Corev2.Models;
using RemoteVar.Corev2.Models.Application;
using RemoteVar.Corev2.Sources;

namespace RemoteVar.Corev2.Services
{
    public class AppManagementService : IApplicationManagementService
    {
        private readonly RemoteVarContext _context;

        public AppManagementService(RemoteVarContext context)
        {
            _context = context;
        }

        public async Task<List<Application>> GetApplicationListForUserAsync(IdentityUser user)
        {
            return await _context.Applications.Where(x => x.UserId == user.Id).ToListAsync();
        }

        public async Task<bool> AddNewApplicationForUserAsync(IdentityUser user, AddAppModel model)
        {
            var app = new Application
            {
                UserId = user.Id,
                AppId = Guid.NewGuid(),
                AppName = model.AppName,
                Variables = new List<Variable>()
            };
            _context.Applications.Add(app);
            var success = await _context.SaveChangesAsync();
            return success == 1;
        }

        public async Task<Application> GetApplicationByIdAsync(IdentityUser user, Guid id)
        {
            var variables = await _context.Variables.Where(x => x.AppId == id).ToListAsync();
            var app = await _context.Applications.SingleOrDefaultAsync(x => x.AppId == id && x.UserId == user.Id);
            app.Variables = variables ?? new List<Variable>();
            return app;
        }

        public async Task<Application> GetApplicationByIdAsync(Guid id)
        {
            var variables = await _context.Variables.Where(x => x.AppId == id).ToListAsync();
            var app = await _context.Applications.SingleOrDefaultAsync(x => x.AppId == id);
            app.Variables = variables ?? new List<Variable>();
            return app;
        }

        public async Task<bool> AddNewVariableForApplicationAsync(IdentityUser user, AddVariableModel model)
        {
            var application = await GetApplicationByIdAsync(user, model.AppId);
            if (application == null)
                return false;

            if (!Validator.Validate(model))
                return false;

            var variableRel = new Variable()
            {
                AppId = model.AppId,
                Application = application,
                Id = Guid.NewGuid(),
                IsTestMode = false,
                VariableName = model.VarName,
                VariableType = model.VariableType,
                VariableValue = model.VariableValue
            };

            var variableDev = new Variable()
            {
                AppId = model.AppId,
                Application = application,
                Id = Guid.NewGuid(),
                IsTestMode = true,
                VariableName = model.VarName,
                VariableType = model.VariableType,
                VariableValue = model.VariableValue
            };

            if (application.Variables == null)
                application.Variables = new List<Variable>();

            application.Variables.Add(variableDev);
            application.Variables.Add(variableRel);

            var changes = await _context.SaveChangesAsync();

            return changes == 2;
        }

        public async Task<bool> UpdateValueOfVariableAsync(IdentityUser user, UpdateValueModel model)
        {
            //Add user identity check here

            var variable = await _context.Variables.SingleOrDefaultAsync(x => x.Id == model.Id);
            if (variable == null)
                return false;
            var app = await _context.Applications.SingleOrDefaultAsync(x => x.AppId == variable.AppId);
            if (app==null || app.UserId != user.Id)
                return false;
            variable.VariableValue = model.Value;
            return (await _context.SaveChangesAsync())==1;
        }

        public async Task<bool> DeleteVariableAsync(IdentityUser user, DeleteValueModel model, Action<Guid[]> deleteValues=null)
        {
            var variable = await _context.Variables.SingleOrDefaultAsync(x => x.Id == model.Id);
            if (variable == null)
                return false;
            var app = await _context.Applications.SingleOrDefaultAsync(x => x.AppId == variable.AppId);
            if (app == null || app.UserId != user.Id)
                return false;
            //Iterate via name to delete the one for the test mode too
            var toBeDeleted =
                await _context.Variables.Where(x => x.AppId == app.AppId && x.VariableName == variable.VariableName).ToArrayAsync();
            deleteValues?.Invoke(toBeDeleted.Select(x=>x.Id).ToArray());
            _context.Variables.RemoveRange(toBeDeleted);

            return (await _context.SaveChangesAsync()) == 2;

        }
    }
}
