using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProfileMS.Models;
using ProfileMS.Services;

namespace ProfileMS.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly ILogger<ProfileController> _logger;
        private readonly IProfileService _service;

        public ProfileController(ILogger<ProfileController> logger, IProfileService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<Profile> profiles = _service.GetAll();
            return Ok(profiles);
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody]Profile profile)
        {
            _service.Create(profile);
            return Ok();
        }
    }
}
