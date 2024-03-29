﻿using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Infra.Repository;
using Infra.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Configuration
{
    public static class InterfaceExtensions
    {
        public static void InterfaceSettings(this IServiceCollection services)
        {
            //Register General
            services.AddScoped<ITokenClaimService, TokenClaimService>();                 
            services.AddScoped<IEmailService, EmailService>();

            //Register Repository
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
