namespace AndyYoungAlumDataLib.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Security;
    using WebMatrix.WebData;
    //using WebMatrix.WebData;

    internal sealed class Configuration : DbMigrationsConfiguration<AndyYoungAlumDataLib.AndyYoungAlumDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AndyYoungAlumDataLib.AndyYoungAlumDbContext context)
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

            SeedMembership();
        }

        private void SeedMembership()
        {
            WebSecurity.InitializeDatabaseConnection("AndyYoungAlumConnString", "SiteUsers", "UserId", "Username", autoCreateTables: true);

            var roles = (SimpleRoleProvider)Roles.Provider;
            var membership = (SimpleMembershipProvider)Membership.Provider;

            if (!roles.RoleExists("AndyYoungAdmin"))
            {
                roles.CreateRole("AndyYoungAdmin");
            }

            //if (membership.GetUser("themant", false) == null)
            //{
            //    membership.CreateUserAndAccount("themant", "oriutara");
            //}

            //if (!roles.GetRolesForUser("themant").Contains("AndyYoungAdmin"))
            //{
            //    roles.AddUsersToRoles(new[] { "themant" }, new[] { "AndyYoungAdmin" });
            //}
        }
    }
}
