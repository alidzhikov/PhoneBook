namespace PhoneBook.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PhoneBook.Data.PhoneBookDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "PhoneBook.Data.PhoneBookDbContext";
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(PhoneBook.Data.PhoneBookDbContext context)
        {
            PhoneBookDbContext ctx = new PhoneBookDbContext();
            ctx.PhoneNumbers.Add(new Models.PhoneNumber
            {
                Phone = "0893454345",
                UserName = "Dexter Brick",
                Information = "Lorem ipsun dolor sit amet",
                CreatedAt = DateTime.Now,
            });
            ctx.SaveChanges();
        }
    }
}
