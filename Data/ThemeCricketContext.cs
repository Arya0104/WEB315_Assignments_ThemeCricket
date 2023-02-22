using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WEB315_Assignments_ThemeCricket.Models;

    public class ThemeCricketContext : DbContext
    {
        public ThemeCricketContext (DbContextOptions<ThemeCricketContext> options)
            : base(options)
        {
        }

        public DbSet<WEB315_Assignments_ThemeCricket.Models.ThemeCricket> ThemeCricket { get; set; }
    }
