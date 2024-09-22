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
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public AppDbContext Context { get { return Context as AppDbContext; } }
        public RoleRepository(AppDbContext context):base(context) { }
    }
}
