using ProductAccelerator.CRUDLibrary.Domain.Entities;
using ProductAccelerator.CRUDLibrary.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccelerator.CRUDLibrary.Infrastructure.Repositories
{
    public class EmployeeRepository : BaseRepository<EmployeeEntity> , IEmployeeRepository
    {
        public EmployeeRepository(BaseDataContext _context) : base(_context) { }



     
    }
}
