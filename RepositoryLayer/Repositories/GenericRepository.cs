using DataAcsessLayer.Data;
using DataAcsessLayer.Entities;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly ApplicatioDbContext _applicatioDbContext;

        public GenericRepository(ApplicatioDbContext applicatioDbContext) {
            _applicatioDbContext = applicatioDbContext;
        }
        public void Add(T entity)
        {
            _applicatioDbContext.Add(entity);
        }


        public void DeleteEntity(T entity)
        {
             _applicatioDbContext.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
          return  _applicatioDbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        =>  _applicatioDbContext.Set<T>().FirstOrDefault(x=>x.Id==id)!;
        

        public void UpdateEntity(T entity)
        {
            _applicatioDbContext.Update(entity);
        }
    }
}
