using Microsoft.EntityFrameworkCore;
using ProductAccelerator.CRUDLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccelerator.CRUDLibrary.Infrastructure.Context
{
    public class DemoContext : BaseDataContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer();
        }

        public DbSet<DemoEntity> demoEntities { get; set; }

        //public override int SaveChanges()
        //{
        //    foreach (var entry in ChangeTracker.Entries())
        //    {
        //        var entity = entry.Entity;

        //        if (entity.State == EntityState.Deleted)
        //        {
        //            entry.State = EntityState.Modified;
        //            entity.GetType().GetProperty("Status").SetValue(entity, 'D');
        //        }
        //    }

        //    return base.SaveChanges();
        //}

    }
}
