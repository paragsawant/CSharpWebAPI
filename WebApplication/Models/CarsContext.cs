using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication.Models
{
    public partial class CarsContext : DbContext
    {
        public CarsContext(DbContextOptions<CarsContext> options) :base(options)
        {
            
        }
        public virtual DbSet<Cars> Cars { get; set; }
    }
}