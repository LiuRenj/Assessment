namespace WebApplication2.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApplication2.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication2.Data.WebApplication2Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebApplication2.Data.WebApplication2Context";
        }

        protected override void Seed(WebApplication2.Data.WebApplication2Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var categories = new List<Category>
 {
new Category {Name = "Lenovo" },
new Category {Name = "Xiaomi" }
            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
            var products = new List<Products>
            {
               
new Products {Name = "XPro162023", Price = 5699,Description = "240HZ High refresh rate", CategoryID= categories.Single(c=>c.Name == "Lenovo").ID},
new Products {Name = "Redmibook14", Price = 3499,Description = "High performance, high fluency",  CategoryID= categories.Single(c=>c.Name == "Xiaomi").ID},
new Products {Name = "Redmibook15", Price = 3499,Description = "High performance, high fluency",  CategoryID= categories.Single(c=>c.Name == "Xiaomi").ID},
new Products {Name = "Redmibook16", Price = 3499,Description = "High performance, high fluency",  CategoryID= categories.Single(c=>c.Name == "Xiaomi").ID},
new Products {Name = "X60pro", Price = 3499,Description = "High performance, high fluency",  CategoryID= categories.Single(c=>c.Name == "Xiaomi").ID},
new Products {Name = "X70pro", Price = 4499,Description = "High performance, high fluency",  CategoryID= categories.Single(c=>c.Name == "Xiaomi").ID},
new Products {Name = "X80pro", Price = 5499,Description = "High performance, high fluency",  CategoryID= categories.Single(c=>c.Name == "Xiaomi").ID},
new Products {Name = "XPro162023", Price = 5699,Description = "240HZ High refresh rate", CategoryID= categories.Single(c=>c.Name == "Lenovo").ID},
new Products {Name = "XPro162024", Price = 6699,Description = "240HZ High refresh rate", CategoryID= categories.Single(c=>c.Name == "Lenovo").ID},
new Products {Name = "XPro162025", Price = 7699,Description = "240HZ High refresh rate", CategoryID= categories.Single(c=>c.Name == "Lenovo").ID},
new Products {Name = "XPro162026", Price = 8699,Description = "240HZ High refresh rate", CategoryID= categories.Single(c=>c.Name == "Lenovo").ID}
            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
        }
    }
    }

