using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;

namespace ProfileMS.Models
{
    public class ProfileDbContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }

        public ProfileDbContext(DbContextOptions<ProfileDbContext> options) : base(options)
        {
        }

        // public List<Profile> getProfiles() => Profiles.Local.ToList<Profile>();

        // public void addProfile(Profile profile) => Profiles.Add(profile);

        // public Profile getById(int id) => Profiles.FirstOrDefault(p => p.Id == id);
    }
}
