using System;
using System.Collections.Generic;
using ProfileMS.Models;

namespace ProfileMS.Services
{
    public interface IProfileService
    {
        IEnumerable<Profile> GetAll();

        Profile GetById(int Id);

        void Create(Profile profile);
    }
}
