using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Vira.Core.Domain;

namespace Vira.Data
{
   public  class ViraDbContext : DbContext
    {
        public ViraDbContext(DbContextOptions<ViraDbContext> options) : base(options)
        {
        }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
