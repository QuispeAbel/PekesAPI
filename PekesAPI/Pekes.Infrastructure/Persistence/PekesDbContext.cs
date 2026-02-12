using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pekes.Infrastructure.Persistence
{
    public class PekesDbContext : DbContext
    {
        public PekesDbContext (DbContextOptions<PekesDbContext> options) : base(options){}


    }
}
