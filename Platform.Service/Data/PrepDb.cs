using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Platform.Service.Models;

namespace Platform.Service.Data
{
    public static class PrepDb
    {
        public static void PrepPopulation(IApplicationBuilder app)
        {
            // Create a scope to get the service provider
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedData(serviceScope.ServiceProvider.GetService<AppDbContext>());
            }
        }
        // Add a SeedData method that takes an AppDbContext parameter
        private static void SeedData(AppDbContext context)
        {
            if(!context.Platforms.Any())
            {
                Console.WriteLine("--> Seeding data...");
                // Add a new PlatformModel object to the Platforms DbSet
                context.Platforms.AddRange(
                    new PlatformModel() { Name = "Dot Net", Publisher = "Microsoft", Cost = "Free" },
                    new PlatformModel() { Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free" },
                    new PlatformModel() { Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free" }
                );
                // Save the changes to the database
                context.SaveChanges();

            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}