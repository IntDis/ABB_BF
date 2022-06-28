using ABB_BF.BLL.Services;
using ABB_BF.BLL.Services.Interfaces;
using ABB_BF.DAL.Repositories;
using ABB_BF.DAL.Repositories.Interfaces;

namespace ABB_BF.Extensions
{
    public static class IServiceCollectionExtension
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProbationRepository, ProbationRepository>();
            services.AddScoped<IGrantRepository, GrantRepository>();
        }

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProbationService, ProbationService>();
            services.AddScoped<IGrantService, GrantService>();
        }
    }
}
