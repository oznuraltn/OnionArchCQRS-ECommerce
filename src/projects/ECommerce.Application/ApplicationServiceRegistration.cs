﻿using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServiceDependencies(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(con => con.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        return services;
    }
}
