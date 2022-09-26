using Microsoft.EntityFrameworkCore;
using ProductAccelerator.CRUDLibrary.Domain.Entities;
using ProductAccelerator.CRUDLibrary.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccelerator.CRUDLibrary.Infrastructure.Repositories
{
    public class DemoRepository : BaseRepository<DemoEntity> , IDemoRepository
    {
        public DemoRepository(BaseDataContext _context) : base(_context) { }

    }
}
