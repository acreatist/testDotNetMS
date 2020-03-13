using System;
using System.Collections.Generic;
using ProfileMS.Models;

namespace ProfileMS.Repositories
{
    public interface IProfileRepository<T> where T : BaseRepositoryModel
    {
        IEnumerable<T> GetAll();
        T GetById(int Id);
        void Create(T entity);        
    }
}
