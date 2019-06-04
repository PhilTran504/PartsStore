using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace PartsStore.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
                {
                context.Products.AddRange(
                    new Product
                    {
                        ProductName = "2013 Toyota FR-S Exhaust", Description = "Exhaust for Toyota FR-S",
                        Category = "Toyota", Price = 1300
                    },
                    new Product
                    {
                        ProductName = "2020 Toyota Supra Coilover",
                        Description = "Supra Coilover",
                        Category = "Toyota",
                        Price = 1000
                    },
                    new Product
                    {
                        ProductName = "2013 Subarau WRX Exhaust",
                        Description = "Exhaust for Subaru WRX",
                        Category = "Subaru",
                        Price = 1200
                    },
                    new Product
                    {
                        ProductName = "2004-2006 Subaru WRX Turbo kit",
                        Description = "Full Turbo kit for Subaru WRX",
                        Category = "Subaru",
                        Price = 4500
                    },
                    new Product
                    {
                        ProductName = "2018 Subaru WRX Short Shifter",
                        Description = "Lowers the shifting throw",
                        Category = "Subaru",
                        Price = 67
                    },
                    new Product
                    {
                        ProductName = "Porsche 718 Cayman Sport Seats",
                        Description = "Sport-styled seats for the new 718",
                        Category = "Porsche",
                        Price = 2300
                    },
                    new Product
                    {
                        ProductName = "2018 Porsche GT3 Wing",
                        Description = "Rear wing for new Porsche GT3",
                        Category = "Porsche",
                        Price = 1000
                    },
                    new Product
                    {
                        ProductName = "Porsche 718 Cayman Factory Wheels",
                        Description = "Factory wheels for 718 Cayman",
                        Category = "Porsche",
                        Price = 2600
                    },
                    new Product
                    {
                        ProductName = "Porsche GT3 Exhaust",
                        Description = "Exhaust from GT3",
                        Category = "Porsche",
                        Price = 2000
                    
                    }
                    );
                    context.SaveChanges();
            }

        }
    }
}
