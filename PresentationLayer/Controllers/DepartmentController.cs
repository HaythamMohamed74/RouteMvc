using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Interfaces;

namespace PresentationLayer.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public IActionResult Index()
        {
            var departments= _departmentRepository.GetAll();
            return View(departments);
        }
    }
}
