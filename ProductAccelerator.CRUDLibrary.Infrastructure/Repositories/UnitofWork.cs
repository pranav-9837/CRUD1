using ProductAccelerator.CRUDLibrary.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccelerator.CRUDLibrary.Infrastructure.Repositories
{
    public class UnitofWork : IUnitofWork 
    {
        // private BaseDataContext context;

        private DemoContext context;
        private EmployeeContext employeeContext;

        public UnitofWork(DemoContext context, EmployeeContext employeeContext)
        {
            this.context = context;
            this.employeeContext = employeeContext;
            Demo = new DemoRepository(this.context);
            Employee = new EmployeeRepository(this.employeeContext);

        }

        public IEmployeeRepository Employee { get;  set;  }

        public IDemoRepository Demo { get;  set; }


    }
}
