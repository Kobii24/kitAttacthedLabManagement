using KitAttachedLab.Data.Base;
using KitAttachedLab.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitAttachedLab.Data.Repository
{
    public class KitRepository : GenericRepository<Kit>
    {
        public KitRepository(prn231Context context)
        {
            _context = context;
        }
    }
}
