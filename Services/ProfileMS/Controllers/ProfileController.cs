using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ProfileMS.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly ILogger<ProfileController> _logger;

        private IEnumerable<Profile> _profiles;

        public ProfileController(ILogger<ProfileController> logger)
        {
            _logger = logger;
            _profiles = new List<Profile>();

            for (int i = 0; i < 3; i++)
            {
                _profiles.Append(new Profile {
                    Id = i,
                    Name = " User" + i.ToString() 
                });
            }
        }

        [HttpGet]
        public IEnumerable<Profile> GetAll()
        {
            return _profiles;
        }
    }
}
