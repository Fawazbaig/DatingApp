using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APi.Entities;
using Microsoft.EntityFrameworkCore;

namespace APi.Data
{
    public class DataContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<AppUSer> Users { get; set; }
        
    }
}