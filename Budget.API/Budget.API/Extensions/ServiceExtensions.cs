using Budget.API.Repository;
using Microsoft.EntityFrameworkCore;

namespace Budget.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigurePsqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<BudgetApiDBContext>(opts =>
                                            opts.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
    }
}
