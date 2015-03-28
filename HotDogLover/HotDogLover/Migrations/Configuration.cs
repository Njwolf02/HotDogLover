namespace HotDogLover.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HotDogLover.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<HotDogLover.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HotDogLover.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Contacts.AddOrUpdate(p => p.Name,
           new Contact
           {
               Name = "Patrick Star",
               Bio = "I like walking my dog!",
               pastPark = "Krusty Crabs Park",
               ImageUrl = "https://pbs.twimg.com/profile_images/427828658477494272/ng9_Kb4P.jpeg",
               CurrentDog = "Worm",
               LastPark = "Krusty Crabs Park",
               LastParkDate = DateTime.Today,
               Score = 3
           }
           );
       }
    }
}
