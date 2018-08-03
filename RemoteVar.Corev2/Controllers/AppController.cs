using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RemoteVar.Corev2.Models;
using RemoteVar.Corev2.Models.Application;
using RemoteVar.Corev2.Services;

namespace RemoteVar.Corev2.Controllers
{
    [Authorize]
    public class AppController : Controller
    {

        private readonly IApplicationManagementService _appService;
        private readonly UserManager<IdentityUser> _userManager;

        public AppController(IApplicationManagementService service,
            UserManager<IdentityUser> userManager)
        {
            _appService = service;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index([FromQuery]string id)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
                return Challenge();

            var app = await _appService.GetApplicationByIdAsync(currentUser,Guid.Parse(id));
            if (app == null)
                return Unauthorized();
            var varLVM = new VariableListViewModel()
            {
                Application = app,
                Variables = app.Variables??new List<Variable>()
            };

            
            return View(varLVM);
        }

        public async Task<IActionResult> List()
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
                return Challenge();
            ApplicationListViewModel appLVM = new ApplicationListViewModel();
            appLVM.Applications = await _appService.GetApplicationListForUserAsync(currentUser);
            return View(appLVM);
        }

        [HttpPost]
        public async Task<IActionResult> AddApp(AddAppModel appModel)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
                return Challenge();
            var success =  await _appService.AddNewApplicationForUserAsync(currentUser, appModel);
            if (!success)
            {
                return BadRequest();
            }

            return RedirectToAction("List");
        }

        [HttpPost]
        public async Task<IActionResult> AddVariable(AddVariableModel varModel)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
                return Challenge();

            var success = await _appService.AddNewVariableForApplicationAsync(currentUser, varModel);
            if (!success)
                return BadRequest();
            return RedirectToAction("Index","App", new {id = varModel.AppId.ToString()});
        }
    }
}