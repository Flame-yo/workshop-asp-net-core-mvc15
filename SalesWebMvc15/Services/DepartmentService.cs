using SalesWebMvc15.Data;
using SalesWebMvc15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc15.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvc15Context _context;

        public DepartmentService(SalesWebMvc15Context context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
