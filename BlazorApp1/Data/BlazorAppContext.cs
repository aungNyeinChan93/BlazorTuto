using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Models;

namespace BlazorApp1.Data
{
    public class BlazorAppContext : DbContext
    {

        public  BlazorAppContext() { }
        public BlazorAppContext (DbContextOptions<BlazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp1.Models.Student> Student { get; set; } = default!;
    }
}
