namespace PhoneBook.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PhoneBookDbContext : DbContext
    {

        public PhoneBookDbContext()
            : base("name=PhoneBookDbContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<PhoneBookDbContext, PhoneBook.Data.Migrations.Configuration>("PhoneBookDbContext"));
        }

        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
    }
}