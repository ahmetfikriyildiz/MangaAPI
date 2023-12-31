﻿using MangaAPI.Application.Services;
using MangaAPI.Persistance.Contexts;
using MangaAPI.Persistance.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace MangaAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<MangaAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IMangaService, MangaService>();
            services.AddScoped<IChapterService, ChapterService>();
            services.AddScoped<IUserService,UserService>();
        }

    }
}
