
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using pursify.Data;
using System;
using System.Linq;

namespace pursify.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new pursifyContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<pursifyContext>>()))
        {
            // Look for any purses.
            if (context.Purse.Any())
            {
                return;   // DB has been seeded
            }
            context.Purse.AddRange(
                new Purse
                {
                    Name = "Wallet 1",
                    Type = "Wallet",
                    Color = "Red",
                    Material = "Leather",
                    Comp = 4,
                    Size = "Small",
                    Price = 500

                },
                new Purse
                {
                    Name = "Messenger bag 1",
                    Type = "Messenger bag",
                    Color = "Blue",
                    Material = "Cotton",
                    Comp = 3,
                    Size = "Medium",
                    Price = 800
                },
               new Purse
               {
                   Name = "Backpack 1",
                   Type = "Backpack",
                   Color = "Green",
                   Material = "Nylon",
                   Comp = 2,
                   Size = "Large",
                   Price = 1300
               },
                 new Purse
                 {
                     Name = "Duffle bag 1",
                     Type = "Duffle bag",
                     Color = "Yellow",
                     Material = "Leather",
                     Comp = 3,
                     Size = "Large",
                     Price = 950
                 }
            );
            context.SaveChanges();
        }
    }
}