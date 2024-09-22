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
    public class DepartmentRepository : GenericRepository<Department>, IDepartmentRepository
    {
        private readonly ApplicatioDbContext _applicatioDbContext;

        public DepartmentRepository(ApplicatioDbContext applicatioDbContext) : base(applicatioDbContext)
        {
            _applicatioDbContext = applicatioDbContext;
        }

       
    }
}
