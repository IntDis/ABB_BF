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
            services.AddScoped<IUniversityRepository, UniversityFormRepository>();
            services.AddScoped<IPracticeRepository, PracticeRepository>();
        }

        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProbationService, ProbationService>();
            services.AddScoped<IGrantService, GrantService>();
            services.AddScoped<IUniversityService, UniversityService>();
            services.AddScoped<IPracticeService, PracticeService>();

            services.AddScoped<IFileHelper, FileHelper>();
            services.AddScoped<IEmailSenderService, EmailSenderService>();
            services.AddScoped<ICollegeService, CollegeService>();
        }
    }
}
