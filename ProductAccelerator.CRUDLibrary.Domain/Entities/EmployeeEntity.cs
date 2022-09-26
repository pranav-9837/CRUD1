using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccelerator.CRUDLibrary.Domain.Entities
{
    public class EmployeeEntity : BaseEntity
    {
        [Key]
        public int EmployeeID { get; set; }

        public String EmployeeName { get; set; }

        public string EmployeeDescription { get; set; }
    }
}
