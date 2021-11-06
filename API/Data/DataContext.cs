using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext:DbContext
    {
        //  This constructor passes a parameter of type DbContextOptios in order to instantiate an object
        // in the Startup class
        public DataContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<AppUser> Users { get; set; }
    }
}