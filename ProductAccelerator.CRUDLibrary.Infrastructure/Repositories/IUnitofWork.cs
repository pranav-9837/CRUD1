using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccelerator.CRUDLibrary.Infrastructure.Repositories
{
    public interface IUnitofWork
    {
        IEmployeeRepository Employee{ get; }

        IDemoRepository Demo { get; }

    }
}
