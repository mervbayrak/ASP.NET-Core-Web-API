﻿using bsStoreApp.Presentation.ActionFilters;
using bsStoreApp.Repositories.Contracts;
using bsStoreApp.Repositories.EFCore;
using bsStoreApp.Services;
using bsStoreApp.Services.Contract;
using Microsoft.EntityFrameworkCore;

namespace bsStoreApp.WebApi.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(options => options.UseSqlServer(configuration.GetConnectionString("sqlConnection")));


        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager, RepositoryManager>();

        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();

        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerService, LoggerManager>();

        public static void ConfigureActionFilters(this IServiceCollection services) =>
            services.AddSingleton<LogFilterAttribute>();

    }
}
