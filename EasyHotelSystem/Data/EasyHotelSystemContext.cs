using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EasyHotelSystem.Models;

namespace EasyHotelSystem.Models
{
    public class EasyHotelSystemContext : DbContext
    {
        public EasyHotelSystemContext (DbContextOptions<EasyHotelSystemContext> options)
            : base(options)
        {
        }

        public DbSet<EasyHotelSystem.Models.Employee> Employee { get; set; }

        public DbSet<EasyHotelSystem.Models.Escorts> Escorts { get; set; }

        public DbSet<EasyHotelSystem.Models.Guest> Guest { get; set; }

        public DbSet<EasyHotelSystem.Models.Payment> Payment { get; set; }

        public DbSet<EasyHotelSystem.Models.Reserva> Reserva { get; set; }

        public DbSet<EasyHotelSystem.Models.Room> Room { get; set; }
    }
}
