using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccelerator.CRUDLibrary.Domain.Entities
{
    public class DemoEntity : BaseEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public string? Name { get; set; } = null;

        public string? Address { get; set; } = null;


    }
}
