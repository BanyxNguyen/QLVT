using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVT.Extensions
{
    public static class DbExtension
    {
        public static void ResetState(this DbContext dbContext)
        {
            dbContext.ChangeTracker.Entries()
            .Where(e => e.Entity != null).ToList()
            .ForEach(e => e.State = EntityState.Detached);
        }
    }
}
