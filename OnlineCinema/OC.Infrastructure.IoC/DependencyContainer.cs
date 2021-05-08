using Microsoft.Extensions.DependencyInjection;
using OC.Application.Services.Implementations;
using OC.Application.Services.Intefaces;
using OC.Domain.Intefaces;
using OC.Infrastructure.Data.Repositories.EF;
using System;

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
        }
    }
}
