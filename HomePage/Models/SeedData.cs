using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;

namespace HomePage.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            //if (!context.Movies.Any())
            //{
            //    context.Movies.AddRange(
            //        new Movie
            //        {
            //            Title = "",
            //            Country = "",
            //            Description ="",
            //            Duration = DateTime.,
            //            Genre= "",
            //            Language = "",
            //            ReleaseDate = 
            //        });
            //    context.SaveChanges();
            //}
        }
    }
}
