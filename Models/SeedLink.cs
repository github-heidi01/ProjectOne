using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectOne.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ProjectOne.Models
{
    public static class SeedLink
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                if (context.Link.Any())
                {
                    return;
                }

                context.Link.AddRange(
                    new Link
                    {
                        Title = "Google",
                        Url = "https://www.google.de",
                        Target = "_blank"
                    },
                    new Link
                    {
                        Title = "Amazon",
                        Url = "https://www.amazon.de",
                        Target = "_self"
                    },
                    new Link
                    {
                        Title = "bike24",
                        Url = "https://www.bike24.de"
                    },
                    new Link
                    {
                        Title = "Home",
                        Url = "https://h.4by.eu",
                        Target="_blank"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
