using GifteeWebApiAngularBasedUI.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GifteeWebApiAngularBasedUI.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GifteeDbContext context;

        public UnitOfWork(GifteeDbContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
