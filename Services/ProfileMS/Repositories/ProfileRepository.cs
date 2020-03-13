using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using ProfileMS.Models;
using System.Linq;

namespace ProfileMS.Repositories
{
    public class ProfileRepository<T> : IProfileRepository<T> where T : Profile
    {
        private readonly ProfileDbContext _context;
        private DbSet<T> _entities;

        public ProfileRepository(ProfileDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public IEnumerable<T> GetAll() 
        {
            return _entities.AsEnumerable();
        }
        public T GetById(int Id)
        {
            return _entities.SingleOrDefault(e => e.Id == Id);
        }

        public void Create(T entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
        }
    }
}
