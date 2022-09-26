﻿using Microsoft.EntityFrameworkCore;
using ProductAccelerator.CRUDLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAccelerator.CRUDLibrary.Infrastructure.Context
{
    public class EmployeeContext : BaseDataContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer();
        }

        public DbSet<EmployeeEntity> employeeEntities { get; set; }

    }
}
