using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorAcademy2.Models;

namespace BlazorAcademy2.Data
{
    public class BlazorAcademy2Context : DbContext
    {
        public BlazorAcademy2Context (DbContextOptions<BlazorAcademy2Context> options)
            : base(options)
        {
        }

        public DbSet<BlazorAcademy2.Models.Direction> Directions { get; set; } = default!;
        public DbSet<BlazorAcademy2.Models.Group> Groups { get; set; } = default!;
        public DbSet<BlazorAcademy2.Models.Teacher> Teachers { get; set; } = default!;
    }
}
