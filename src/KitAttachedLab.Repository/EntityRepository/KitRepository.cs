using KitAttachedLab.Data.Entities;
using KitAttachedLab.Repository.Base;
using KitAttachedLab.Repository.IEntityRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitAttachedLab.Repository.EntityRepository
{
    public class KitRepository : Repository<Kit>, IKitRepository
    {
        public AppDbContext Context { get { return Context as AppDbContext; } }
        public KitRepository(AppDbContext context) : base(context) { }
    }
}
