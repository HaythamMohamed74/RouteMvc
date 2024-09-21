using DataAcsessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);

        void UpdateEntity(T entity);
        void DeleteEntity(T entity);

    }
}
