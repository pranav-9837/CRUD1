using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace ProductAccelerator.CRUDLibrary.Domain.Entities.Extensions
{
    public static class ChangeTrackerExtensions
    {
        public static void SetAuditProperties(this ChangeTracker changeTracker)
        {
            changeTracker.DetectChanges();
            IEnumerable<EntityEntry> entities =
                changeTracker
                    .Entries()
                    .Where(t => t.Entity is BaseEntity && t.State == EntityState.Deleted);

            if (entities.Any())
            {
                foreach (EntityEntry entry in entities)
                {
                    BaseEntity entity = (BaseEntity)entry.Entity;
                    entity.IsDeleted = true;
                    entry.State = EntityState.Unchanged;
                }
            }
        }
    }
}
