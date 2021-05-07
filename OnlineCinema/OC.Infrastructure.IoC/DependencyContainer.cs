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
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
