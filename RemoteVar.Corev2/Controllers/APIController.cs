using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RemoteVar.Corev2.ResponseData;
using RemoteVar.Corev2.Services;

namespace RemoteVar.Corev2.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class VariablesController : ControllerBase
    {

        private readonly IApplicationManagementService _appService;
        private readonly UserManager<IdentityUser> _userManager;

        public VariablesController(IApplicationManagementService service,
            UserManager<IdentityUser> userManager)
        {
            _appService = service;
            _userManager = userManager;
        }
        /// <summary>
        /// Gets the variable list for the application
        /// </summary>
        /// <remarks>
        /// Usage:
        /// 
        ///     GET /api/variables?id=xxx-xxx-xxx
        /// 
        /// </remarks>
        /// <returns>The JSON for the specified application</returns>
        /// <response code="200">Returns the JSON for the application variables</response>
        /// <response code="400">No application with specified ID was found</response>
        /// <param name="id">Id of application</param>
        /// <param name="mode">test for development mode and rel for release mode</param>
        /// <param name="parsing">Specifies the conversion of variable values to their specific types</param>
        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<IActionResult> App(string id, string mode = "test", string parsing = "on")
        {
            bool testMode = mode == "test";

            bool parsingOn = parsing == "on";

            if (!Guid.TryParse(id, out var result))
                return NotFound();
            var app = await _appService.GetApplicationByIdAsync(result);
            return Ok(app?.ConvertToResponse(testMode, parsingOn));
        }
    }
}