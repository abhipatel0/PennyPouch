using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PennyPouch.Models;

namespace PennyPouch.Data
{
    public class PennyPouchContext : DbContext
    {
        public PennyPouchContext(DbContextOptions<PennyPouchContext> options)
            : base(options)
        {
        }

        public DbSet<Pouch> Pouch { get; set; }
    }
}