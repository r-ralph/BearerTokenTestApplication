using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet.Security.OAuth.Validation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BearerTokenTestApplication.Controllers
{
    [Produces("application/json")]
    [Route("api/sample")]
    [Authorize(AuthenticationSchemes = OAuthValidationDefaults.AuthenticationScheme)]
    public class SampleController : Controller
    {
        public IActionResult Get()
        {
            return Ok("success");
        }
    }
}