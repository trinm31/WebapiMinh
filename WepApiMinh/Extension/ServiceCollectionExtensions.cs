using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WepApiMinh.DbContext;

namespace WepApiMinh.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection service)
        {
            //Configure DbContext with Scoped Lifetime
            service.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(AppSettings.ConnectionStrings,
                    sqlOptions => sqlOptions.CommandTimeout(12000));
            });
            return service;
        }
    }
}