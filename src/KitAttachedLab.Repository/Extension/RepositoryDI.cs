using KitAttachedLab.Repository.Base;
using KitAttachedLab.Repository.EntityRepository;
using KitAttachedLab.Repository.IEntityRepository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitAttachedLab.Repository.Extension
{
    public static class RepositoryDI
    {
        public static IServiceCollection RegisterDI(this IServiceCollection services)
        {
            services.AddScoped<ICategoryRepository, ICategoryRepository>();
            services.AddScoped<IKitRepository, KitRepository>();
            services.AddScoped<ILabRepository, LabRepository>();
            services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<ISaleRepository, SaleRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            return services;
        }
    }
}
