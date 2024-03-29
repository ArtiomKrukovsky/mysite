﻿namespace AllExpirience.Models
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity.Owin;
    using Microsoft.Owin;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ApplicationUser : IdentityUser
    {
    }

    public class HelpDBContext : IdentityDbContext<ApplicationUser>
    {
        public HelpDBContext()
            : base("name=HelpDBContext")
        {}

        public static HelpDBContext Create()
        {
            return new HelpDBContext();
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Help> Helps { get; set; }
    }

    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        public ApplicationUserManager(IUserStore<ApplicationUser> store)
                : base(store)
        {
        }
        public static ApplicationUserManager Create(IdentityFactoryOptions<ApplicationUserManager> options,
                                                IOwinContext context)
        {
            HelpDBContext db = context.Get<HelpDBContext>();
            ApplicationUserManager manager = new ApplicationUserManager(new UserStore<ApplicationUser>(db));
            return manager;
        }
    }

    public class Init: DropCreateDatabaseAlways<HelpDBContext>
    {
        protected override void Seed(HelpDBContext context)
        {
            context.Countries.Add(new Country {CountryId=1, Name="Беларусь"});
            context.Countries.Add(new Country { CountryId = 2, Name = "Россия" });
            context.Countries.Add(new Country { CountryId = 3, Name = "Украина" });
            context.Countries.Add(new Country { CountryId = 4, Name = "Литва" });
            context.Countries.Add(new Country { CountryId = 5, Name = "Латвия" });
            context.Countries.Add(new Country { CountryId = 6, Name = "Молдова" });
            context.Countries.Add(new Country { CountryId = 7, Name = "Польша" });
            context.Countries.Add(new Country { CountryId = 8, Name = "Армения" });
            context.Countries.Add(new Country { CountryId = 9, Name = "Азербайджан" });
            context.Countries.Add(new Country { CountryId = 10, Name = "Туркмения" });
            context.Countries.Add(new Country { CountryId = 11, Name = "Казахстан" });
            context.Countries.Add(new Country { CountryId = 12, Name = "Таджикистан" });
            context.Countries.Add(new Country { CountryId = 13, Name = "Великобритания" });
            context.Countries.Add(new Country { CountryId = 14, Name = "США" });
            context.Countries.Add(new Country { CountryId = 15, Name = "Германия" });
            context.Countries.Add(new Country { CountryId = 16, Name = "Испания" });
            context.Countries.Add(new Country { CountryId = 17, Name = "Италия" });
            context.Countries.Add(new Country { CountryId = 18, Name = "Другая страна..." });
            base.Seed(context);
        }
    }
}