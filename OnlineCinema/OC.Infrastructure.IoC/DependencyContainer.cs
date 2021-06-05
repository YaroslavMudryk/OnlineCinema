using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using OC.Application.Services.Implementations;
using OC.Application.Services.Intefaces;
using OC.Application.ViewModels;
using OC.Domain.Intefaces;
using OC.Infrastructure.Data.Repositories.EF;
namespace OC.Infrastructure.IoC
{
    public static class DependencyContainer
    {
        public static void AddCinemaServices(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, EFUserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRoleRepository, EFRoleRepository>();
            services.AddScoped<IUserLoginRepository, EFUserLoginRepository>();
            services.AddScoped<IUserRoleRepository, EFUserRoleRepository>();
            services.AddScoped<IUserSessionRepository, EFUserSessionRepository>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserRestoreRepository, UserRestoreRepository>();
            services.AddScoped<ICategoryRepository, EFCategoryRepository>();
            services.AddScoped<IMovieRepository, EFMovieRepository>();
        }

        public static void AddOnlineCinemaAutoMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mapConfiguration =>
            {
                mapConfiguration.AddProfile(new MapperConfig());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}