using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using StaffService.Entity;

namespace StaffService.Data
{
    public class EmployeeDbContex: DbContext
    {
        public EmployeeDbContex() : base("name = MyEmployee")
        {


        }

        public DbSet<Employee> Employees { get; set; }
    }
}