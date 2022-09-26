using Microsoft.EntityFrameworkCore;
using ProductAccelerator.CRUDLibrary.Domain.Entities;
using ProductAccelerator.CRUDLibrary.Domain.Entities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccelerator.CRUDLibrary.Infrastructure.Context
{
    public class BaseDataContext : DbContext
    {
        public BaseDataContext(DbContextOptions options) : base(options)
        {
            

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer();
        }

        public override int SaveChanges()
        {
            ChangeTracker.SetAuditProperties();
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            ChangeTracker.SetAuditProperties();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }


    }
}
