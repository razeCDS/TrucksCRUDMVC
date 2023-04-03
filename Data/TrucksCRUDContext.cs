using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrucksCRUD.Models;

namespace TrucksCRUD.Data
{
    public class TrucksCRUDContext : DbContext
    {
        public TrucksCRUDContext (DbContextOptions<TrucksCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<TrucksCRUD.Models.Truck> Truck { get; set; } = default!;
    }
}
