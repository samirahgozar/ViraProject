using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vira.Data
{
    public class DbContextFactory : DesignTimeDbContextFactoryBase<ViraDbContext>
    {
        protected override ViraDbContext CreateNewInstance(DbContextOptions<ViraDbContext> options)
        {
            return new ViraDbContext(options);
        }
    }
}
