using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RemoteVar.Corev2.Models;
using RemoteVar.Corev2.Services;

namespace RemoteVar.Corev2.Controllers
{
    [Authorize]
    public class AJAXController : Controller
    {
        private readonly IApplicationManagementService _appService;
        private readonly UserManager<IdentityUser> _userManager;

        public AJAXController(IApplicationManagementService service,
            UserManager<IdentityUser> userManager)
        {
            _appService = service;
            _userManager = userManager;
        }

        [HttpPost]
        public async Task <IActionResult> UpdateValue(UpdateValueModel model)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
                return Challenge();
            if (String.IsNullOrEmpty(model?.Value))
            {
                return Json("Empty String");
            }

            var succeeded = await _appService.UpdateValueOfVariableAsync(currentUser, model);
            return Json(new {success = succeeded});

        }

        [HttpPost]
        public async Task<IActionResult> DeleteValue(DeleteValueModel model)
        {
            var currentUser = await _userManager.GetUserAsync(User);
            if (currentUser == null)
                return Challenge();

            Guid[] deletedValues = null;

            var succeeded = await _appService.DeleteVariableAsync(currentUser, model, (x)=>deletedValues=x);
            return Json(new { success = succeeded, values = deletedValues });

        }
    }
}