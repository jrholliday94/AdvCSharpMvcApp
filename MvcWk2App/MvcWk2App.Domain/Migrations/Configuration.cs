namespace MvcWk2App.Domain.Migrations
{
    using MvcWk2App.Domain.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcWk2App.Domain.GameContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcWk2App.Domain.GameContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Games.AddOrUpdate(new Game
            {
                GameId = Guid.Parse("b7982953-79d4-4eb4-83e4-579fd1488187"),
                GameName = "Robot on the Run"
            });

            context.Games.AddOrUpdate(new Game
            {
                GameId = Guid.Parse("d41872c2-f6bb-4c55-9ca5-471cb860f77a"),
                GameName = "Escape from Kriltron"
            });

            context.Games.AddOrUpdate(new Game
            {
                GameId = Guid.Parse("579bfcb2-2f6f-47e3-bd7f-612056c2f4d0"),
                GameName = "Escape from Mobious"
            });


        }
    }
}
