using System;
using ProfileMS.Repositories;
using ProfileMS.Models;
using System.Collections.Generic;

namespace ProfileMS.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository<Profile> _repo;

        public ProfileService(IProfileRepository<Profile> repo)
        {
            _repo = repo;
        }

        public IEnumerable<Profile> GetAll()
        {
            return _repo.GetAll();
        }

        public Profile GetById(int Id)
        {
            return _repo.GetById(Id);
        }

        public void Create(Profile profile)
        {
            _repo.Create(profile);
        }
    }
}
